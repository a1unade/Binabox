using Binabox.Application.Common.Responses;
using Binabox.Application.DTOs.Shop;
using Binabox.Domain.Entities;

namespace Binabox.Application.Interfaces.Repositories;

public interface IShopRepository
{
    /// <summary>
    /// Получение всех предметов магазина
    /// </summary>
    /// <returns>Список всех товаров в магазине</returns>
    Task<ShopItem[]> GetAllItemsAsync();

    /// <summary>
    /// Получение предметов в магазиние при пагинации
    /// </summary>
    /// <param name="offset">Начало списка</param>
    /// <param name="limit">Конец списка</param>
    /// <returns>Список товаров в магазине</returns>
    Task<ShopItem[]> GetItemsPaginatedAsync(int offset, int limit);
    
    /// <summary>
    /// Получение списка похожих товаров в магазине
    /// </summary>
    /// <returns>Список похожих товаров в магазине</returns>
    Task<ShopItem[]> GetItemSuggestionsAsync();

    /// <summary>
    /// Получение полной информации о товаре в магазине по ID
    /// </summary>
    /// <param name="id">ID товара</param>
    /// <returns>Полная информация о товаре</returns>
    Task<ItemResponse> GetItemDetailsByIdAsync(int id);

    /// <summary>
    /// Удаление товара из магазина по Id
    /// </summary>
    /// <param name="id">ID товара</param>
    /// <returns>Резльтат выполнения success/error</returns>
    Task<DeleteResponse> DeleteItemByIdAsync(int id);

    /// <summary>
    /// Получение списка товаров по фильтру
    /// </summary>
    /// <param name="filteredDto">Параметры для фильтрации</param>
    /// <returns>Список отфильрованных товаров</returns>
    Task<ShopItem[]> GetFilteredItemsAsync(FilteredDto filteredDto);

    /// <summary>
    /// Получение фильтров категории по названию
    /// </summary>
    /// <param name="name">Название категории</param>
    /// <returns>Список фильтров в определенной категории</returns>
    Task<ItemCategory[]> GetCategoriesByNameAsync(string name);

    /// <summary>
    /// Добавление товара в магазин
    /// </summary>
    /// <param name="item">Товар</param>
    /// <returns>Результат выполнения success/error</returns>
    Task<BaseResponse> AddNewShopItemAsync(ShopItem item);
}