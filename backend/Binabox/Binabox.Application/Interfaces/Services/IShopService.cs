using Binabox.Application.Common.Responses;
using Binabox.Application.DTOs.Shop;

namespace Binabox.Application.Interfaces.Services;

public interface IShopService
{
    /// <summary>
    /// Получение списка всех товаров в магазине
    /// </summary>
    /// <returns>Список товаров в маагазине</returns>
    Task<ShopResponse[]> GetAllShopItemsAsync();
    
    /// <summary>
    /// Получение списка товаров в магазине при пагинации
    /// </summary>
    /// <param name="offset">С какого товара получить список</param>
    /// <param name="limit">До какого товара получить список</param>
    /// <returns>Список товаров в магазине</returns>
    Task<ShopResponse[]> GetShopItemsPaginatedAsync(int offset, int limit);
    
    /// <summary>
    /// Получение похожих товаров в магазине
    /// </summary>
    /// <returns>Список похожих товаров в магазине</returns>
    Task<ShopResponse[]> GetItemSuggestions();

    /// <summary>
    /// Удаление предмета по ID
    /// </summary>
    /// <param name="id">ID предмета</param>
    /// <returns></returns>
    Task<DeleteResponse> DeleteItemByIdAsync(int id);

    /// <summary>
    /// Получение предметов в магазине по фильтру
    /// </summary>
    /// <param name="filteredDto"></param>
    /// <returns></returns>
    Task<ShopResponse[]> GetFilteredItemsAsync(FilteredDto filteredDto);

    /// <summary>
    /// Получение полной информации о товаре в магазине по ID
    /// </summary>
    /// <param name="id">ID товара</param>
    /// <returns>Полная информация о товаре</returns>
    Task<ItemResponse> GetItemDetailsByIdAsync(int id);

    /// <summary>
    /// Покупка предмета пользователем
    /// </summary>
    /// <param name="id">ID товара</param>
    /// <param name="userEmail">Почта пользователя для отправки предмета</param>
    /// <returns>Результат выполнения success/error</returns>
    Task<BaseResponse> BuyItemByIdAsync(int id, string userEmail);

    /// <summary>
    /// Получение фильтров в категории по названию
    /// </summary>
    /// <param name="name">Название категории</param>
    /// <returns>Результат выполнения success/error + список фильтров при success</returns>
    Task<FiltersResponse> GetCategoryFiltersByNameAsync(string name);
    
    /// <summary>
    /// Добавление нового товара в магазин
    /// </summary>
    /// <param name="dto">Товар</param>
    /// <returns>Результат выполнения</returns>
    Task<BaseResponse> AddNewShopItemAsync(AddItemDto dto);
}