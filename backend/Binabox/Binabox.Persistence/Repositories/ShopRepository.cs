using Binabox.Application.Common.Enums;
using Binabox.Application.Common.Exceptions;
using Binabox.Application.Common.Messages.Error;
using Binabox.Application.Common.Responses;
using Binabox.Application.DTOs.Shop;
using Binabox.Application.Interfaces.Repositories;
using Binabox.Domain.Entities;
using Binabox.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Binabox.Persistence.Repositories;

public class ShopRepository(ApplicationDbContext applicationDbContext): IShopRepository
{
    public async Task<ShopItem[]> GetAllItemsAsync() => 
        await applicationDbContext.ShopItems.AsNoTracking().Select(x => x).ToArrayAsync();

    public async Task<ShopItem[]> GetItemsPaginatedAsync(int offset, int limit) =>
        await applicationDbContext.ShopItems.AsNoTracking().Skip(offset)
            .Take(limit).ToArrayAsync();
    
    public async Task<ShopItem[]> GetItemSuggestionsAsync() => 
        await applicationDbContext.ShopItems.AsNoTracking().Take(9).ToArrayAsync();

    public async Task<ItemResponse> GetItemDetailsByIdAsync(int id)
    {
        var item = await applicationDbContext.ShopItems.AsNoTracking()
            .Include(si => si.ItemDetail)
            .ThenInclude(detail => detail.ItemCategories)
            .FirstOrDefaultAsync(x => x.Id == id);

        if (item == null)
            throw new NotFoundException(StaticErrorMessages.ItemNotFound);

        List<CategoryResponse> categoryResponses = new List<CategoryResponse>();
        ShopItem[] suggestions = await GetItemSuggestionsAsync();
        List<ShopResponse> suggestionsList = new List<ShopResponse>();

        foreach (var category in item.ItemDetail.ItemCategories)
        {
            categoryResponses.Add(new CategoryResponse
            {
                ResponseType = ResponseTypes.Success,
                Id = category.Id,
                Name = category.Name,
                Info = category.Info
            });
        }
        
        foreach (var s in suggestions)
        {
            if (item.Id != s.Id)
                suggestionsList.Add(new ShopResponse
                {
                    Id = s.Id,
                    Title = s.Title,
                    Image = s.Image
                });
        }

        return new ItemResponse
        {
            Id = item.Id,
            Title = item.Title,
            Image = item.Image,
            Description = item.ItemDetail.Description,
            Categories = categoryResponses,
            Price = item.ItemDetail.Price,
            Suggestions = suggestionsList
        };
    }

    public async Task<DeleteResponse> DeleteItemByIdAsync(int id)
    {
        var item = await applicationDbContext.ShopItems
            .Include(si => si.ItemDetail)
            .ThenInclude(itemDetail => itemDetail.ItemCategories) 
            .FirstOrDefaultAsync(x => x.Id == id);

        if (item == null)
            throw new NotFoundException(StaticErrorMessages.ItemNotFound);

        applicationDbContext.ShopItems.Remove(item);
        await applicationDbContext.SaveChangesAsync();

        return new DeleteResponse { ResponseType = ResponseTypes.Success};
    }

    public async Task<ShopItem[]> GetFilteredItemsAsync(FilteredDto filteredDto)
    {
        var query = applicationDbContext.ShopItems.AsNoTracking()
            .Include(si => si.ItemDetail)
            .ThenInclude(detail => detail.ItemCategories)
            .AsQueryable();

        if (!string.IsNullOrEmpty(filteredDto.Search))
            query = query.Where(si => si.Title.ToLower().Contains(filteredDto.Search));

        if (!string.IsNullOrEmpty(filteredDto.Clothing))
            query = query.Where(si => si.ItemDetail.ItemCategories.Any(ic => ic.Name.ToLower() == "clothing" && ic.Info == filteredDto.Clothing));

        if (!string.IsNullOrEmpty(filteredDto.Eyes))
            query = query.Where(si => si.ItemDetail.ItemCategories.Any(ic => ic.Name.ToLower() == "eyes" && ic.Info.ToLower() == filteredDto.Eyes.ToLower()));

        if (!string.IsNullOrEmpty(filteredDto.Face))
            query = query.Where(si => si.ItemDetail.ItemCategories.Any(ic => ic.Name.ToLower() == "face" && ic.Info.ToLower() == filteredDto.Face.ToLower()));

        if (!string.IsNullOrEmpty(filteredDto.Skin))
            query = query.Where(si => si.ItemDetail.ItemCategories.Any(ic => ic.Name.ToLower() == "skin" && ic.Info.ToLower() == filteredDto.Skin.ToLower()));

        if (!string.IsNullOrEmpty(filteredDto.Background))
            query = query.Where(si => si.ItemDetail.ItemCategories.Any(ic => ic.Name.ToLower() == "background" && ic.Info.ToLower() == filteredDto.Background.ToLower()));

        if (!string.IsNullOrEmpty(filteredDto.Special))
            query = query.Where(si => si.ItemDetail.ItemCategories.Any(ic => ic.Name.ToLower() == "special" && ic.Info.ToLower() == filteredDto.Special.ToLower()));

        var items = await query.ToArrayAsync();

        if (items.Length == 0)
            throw new NotFoundException(StaticErrorMessages.ItemNotFound);

        return items;
    }

    public async Task<ItemCategory[]> GetCategoriesByNameAsync(string name)
    {
        var categories = await applicationDbContext.ItemCategories.AsNoTracking()
            .Select(x => x).Where(x => x.Name.ToLower() == name.ToLower()).ToArrayAsync();

        if (categories == null)
            throw new NotFoundException(StaticErrorMessages.CategoryNotFound);

        return categories.DistinctBy(x => x.Info).ToArray();
    }

    public async Task<BaseResponse> AddNewShopItemAsync(ShopItem item)
    {
        try
        {
            await applicationDbContext.ShopItems.AddAsync(item);
            await applicationDbContext.SaveChangesAsync();

            return new BaseResponse { ResponseType = ResponseTypes.Success };
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ShopRepository/AddNewShopItemAsync: " + ex.Message);
            Console.ResetColor();

            return new BaseResponse { ResponseType = ResponseTypes.Error, Errors = new List<string> { ex.Message } };
        }
    }
}