using Binabox.Application.DTOs.Shop;
using Binabox.Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Binabox.WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ShopController(IShopService shopService) : ControllerBase
{
    /// <summary>
    /// Получение списка всех предметов магазина
    /// </summary>
    /// <returns>Список всех предметов в магазине</returns>
    [HttpGet("getAllShopItems")]
    public async Task<IActionResult> GetAllShopItems()
    {
        try
        {
            var response = await shopService.GetAllShopItemsAsync();

            return Ok(response);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    
    /// <summary>
    /// Получение списка предметов магазина при пагинации
    /// </summary>
    /// <returns>Список предметов в магазине</returns>
    [HttpGet("getShopItemsPaginated")]
    public async Task<IActionResult> GetShopItemsPaginated([FromQuery] int offset, [FromQuery] int limit)
    {
        try
        {
            if (offset < 0 || limit <= 0)
                return BadRequest("Invalid arguments!");
            
            var response = await shopService.GetShopItemsPaginatedAsync(offset, limit);

            return Ok(response);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    /// <summary>
    /// Удаление предмета по ID
    /// </summary>
    /// <param name="id">ID предмета</param>
    /// <returns>Результат выполнения success/error</returns>
    [HttpDelete("deleteItem")]
    public async Task<IActionResult> DeleteItem(int id)
    {
        try
        {
            var response = await shopService.DeleteItemByIdAsync(id);

            return Ok(response);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    /// <summary>
    /// Получение предметов при фильтрации
    /// </summary>
    /// <param name="filteredDto">Парматеры для фильтрации</param>
    /// <returns>Список предметов в магазине</returns>
    [HttpGet("getFilteredShopItems")]
    public async Task<IActionResult> GetFilteredShopItems([FromQuery] FilteredDto filteredDto)
    {
        try
        {
            var response = await shopService.GetFilteredItemsAsync(filteredDto);

            return Ok(response);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    /// <summary>
    /// Получение детальной информации о предмете
    /// </summary>
    /// <param name="id">ID предмета</param>
    /// <returns>Детальная информация о предмете</returns>
    [HttpGet("getItemDetails")]
    public async Task<IActionResult> GetItemDetailsById(int id)
    {
        try
        {
            var response = await shopService.GetItemDetailsByIdAsync(id);

            return Ok(response);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    /// <summary>
    /// Покупка предметов
    /// </summary>
    /// <param name="buyDto">ID товара и почта пользователя</param>
    /// <returns>Результат выполнения success/error</returns>
    [HttpPost("buyItem")]
    public async Task<IActionResult> BuyItemById(BuyDto buyDto)
    {
        try
        {
            var response = await shopService.BuyItemByIdAsync(buyDto.Id, buyDto.UserEmail);

            return Ok(response);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    /// <summary>
    /// Получение параметров для фильтрации в категории
    /// </summary>
    /// <param name="name">Название категории</param>
    /// <returns>Параметры для фильтрации в категории</returns>
    [HttpGet("getCategoryFilters")]
    public async Task<IActionResult> GetCategoryFilters(string name)
    {
        try
        {
            var response = await shopService.GetCategoryFiltersByNameAsync(name);

            return Ok(response);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    /// <summary>
    /// Добавление товара в магазин
    /// </summary>
    /// <param name="dto">Товар</param>
    /// <returns>Результат выполнения success/error</returns>
    [HttpPost("addItem")]
    public async Task<IActionResult> AddNewShopItem(AddItemDto dto)
    {
        try
        {
            var response = await shopService.AddNewShopItemAsync(dto);

            return Ok(response);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}