using Binabox.Application.Common.Enums;
using Binabox.Application.Common.Responses;
using Binabox.Application.DTOs.Shop;
using Binabox.Application.Interfaces.Repositories;
using Binabox.Application.Interfaces.Services;
using Binabox.Domain.Entities;

namespace Binabox.Infrastructure.Services;

public class ShopService(IShopRepository shopRepository, IEmailService emailService): IShopService
{
    public async Task<ShopResponse[]> GetAllShopItemsAsync()
    {
        try
        {
            ShopItem[] shopItems = await shopRepository.GetAllItemsAsync();
            List<ShopResponse> response = new List<ShopResponse>();

            if (shopItems.Length != 0)
            {
                foreach (var item in shopItems)
                {
                    response.Add(
                        new ShopResponse
                        {
                            Id = item.Id,
                            Image = item.Image,
                            Title = item.Title
                        });
                }
            }

            return response.ToArray();
        }
        catch(Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ShopService/GetAllShopItemsAsync: " + ex.Message);
            Console.ResetColor();

            return [];
        }
    }

    public async Task<BaseResponse> BuyItemByIdAsync(int id, string userEmail)
    {
        try
        {
            var item = await shopRepository.GetItemDetailsByIdAsync(id);
            //await shopRepository.DeleteItemByIdAsync(id);
            
            await emailService.SendEmailAsync(userEmail, "Покупка товара", emailService.GenerateBoughtItemMessage(item));

            return new BaseResponse { ResponseType = ResponseTypes.Success };
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ShopService/BuyItemByIdAsync: " + ex.Message);
            Console.ResetColor();

            return new BaseResponse
                { ResponseType = ResponseTypes.Error, Errors = new List<string> { "Не получилось купить предмет!" } };
        }
    }

    public async Task<ShopResponse[]> GetShopItemsPaginatedAsync(int offset, int limit)
    {
        try
        {
            ShopItem[] shopItems = await shopRepository.GetItemsPaginatedAsync(offset, limit);
            List<ShopResponse> response = new List<ShopResponse>();

            if (shopItems.Length != 0)
            {
                foreach (var item in shopItems)
                {
                    response.Add(
                        new ShopResponse
                        {
                            Id = item.Id,
                            Image = item.Image,
                            Title = item.Title
                        });
                }
            }

            return response.ToArray();
        }
        catch(Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ShopService/GetShopItemsPaginatedAsync: " + ex.Message);
            Console.ResetColor();

            return [];
        }
    }

    public async Task<ShopResponse[]> GetItemSuggestions()
    {
        try
        {
            ShopItem[] suggestions = await shopRepository.GetItemSuggestionsAsync();
            List<ShopResponse> response = new List<ShopResponse>();

            if (suggestions.Length != 0)
            {
                foreach (var item in suggestions)
                {
                    response.Add(
                        new ShopResponse
                        {
                            Id = item.Id,
                            Image = item.Image,
                            Title = item.Title
                        });
                }
            }

            return response.ToArray();
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ShopService/GetShopItemsPaginatedAsync: " + ex.Message);
            Console.ResetColor();
            
            return [];
        }
    }

    public async Task<DeleteResponse> DeleteItemByIdAsync(int id)
    {
        try
        {
            return await shopRepository.DeleteItemByIdAsync(id);
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ShopService/DeleteItemByIdAsync: " + ex.Message);
            Console.ResetColor();

            return new DeleteResponse { ResponseType = ResponseTypes.Error };
        }
    }

    public async Task<ShopResponse[]> GetFilteredItemsAsync(FilteredDto filteredDto)
    {
        try
        {
            ShopItem[] shopItems = await shopRepository.GetFilteredItemsAsync(filteredDto);
            List<ShopResponse> response = new List<ShopResponse>();

            if (shopItems.Length != 0)
            {
                foreach (var item in shopItems)
                {
                    response.Add(
                        new ShopResponse
                        {
                            Id = item.Id,
                            Image = item.Image,
                            Title = item.Title
                        });
                }
            }

            return response.ToArray();
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ShopService/GetFilteredItemsAsync: " + ex.Message);
            Console.ResetColor();
            
            return [];
        }
    }

    public async Task<ItemResponse> GetItemDetailsByIdAsync(int id)
    {
        try
        {
            return await shopRepository.GetItemDetailsByIdAsync(id);
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ShopService/GetItemDetailsByIdAsync: " + ex.Message);
            Console.ResetColor();
            
            return new ItemResponse { ResponseType = ResponseTypes.Error, Errors = new List<string> {ex.Message} };
        }
    }

    public async Task<FiltersResponse> GetCategoryFiltersByNameAsync(string name)
    {
        try
        {
            var filters = await shopRepository.GetCategoriesByNameAsync(name);
            List<string> filtersResponse = new List<string>();

            if (filters.Length == 0)
                return new FiltersResponse
                {
                    ResponseType = ResponseTypes.Error,
                    Errors = new List<string> { "Фильтры в данной категории не найдены!" }
                };
            
            foreach (var f in filters)
                filtersResponse.Add(f.Info);

            return new FiltersResponse { ResponseType = ResponseTypes.Success, Filters = filtersResponse };
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ShopService/GetCategoryFiltersByNameAsync: " + ex.Message);
            Console.ResetColor();
            
            return new FiltersResponse { ResponseType = ResponseTypes.Error, Errors = new List<string> {ex.Message} };
        }
    }
    
    public async Task<BaseResponse> AddNewShopItemAsync(AddItemDto dto)
    {
        try
        {
            List<ItemCategory> categories = [
                new ItemCategory { Name = "FACE", Info = dto.Face },
                new ItemCategory { Name = "EYES", Info = dto.Eyes },
                new ItemCategory { Name = "CLOTHING", Info = dto.Clothing },
                new ItemCategory { Name = "BACKGROUND", Info = dto.Background },
                new ItemCategory { Name = "SPECIAL", Info = dto.Special },
                new ItemCategory { Name = "SKIN", Info = dto.Skin }
            ];

            ItemDetail detail = new ItemDetail
            {
                Description = dto.Description,
                Price = dto.Price,
                ItemCategories = categories
            };

            ShopItem item = new ShopItem
            {
                Title = dto.Title,
                Image = dto.Image,
                ItemDetail = detail
            };

            return await shopRepository.AddNewShopItemAsync(item);
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("UserService/AddNewShopItemAsync: " + ex.Message);
            Console.ResetColor();

            return new BaseResponse { ResponseType = ResponseTypes.Error, Errors = new List<string> { ex.Message } };
        }
    }
}