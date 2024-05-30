using Binabox.Application.Common.Responses;
using Binabox.Application.DTOs.Shop;
using Binabox.Domain.Common.Enums;

namespace Binabox.Application.Interfaces.Services;

public interface IUserService
{
    /// <summary>
    /// Получение пользователя по адресу электронной почты
    /// </summary>
    /// <param name="email">Электронная почта пользователя</param>
    /// <returns>Пользователь</returns>
    Task<UserResponse> GetUserByEmailAsync(string email);
    
    /// <summary>
    /// Получение пользователя по ID
    /// </summary>
    /// <param name="id">ID пользователя</param>
    /// <returns>Пользователь</returns>
    Task<UserResponse> GetUserByIdAsync(string id);

    /// <summary>
    /// Смена никнейма у пользователя
    /// </summary>
    /// <param name="nickname">Новый никнейм</param>
    /// <param name="userId">ID пользователя</param>
    /// <returns>Результат выполнения success/error</returns>
    Task<BaseResponse> ChangeUserNicknameAsync(string nickname, string userId);
    
    /// <summary>
    /// Смена аватарки у пользователя
    /// </summary>
    /// <param name="avatar">Новая аватарка</param>
    /// <param name="userId">Id пользователя</param>
    /// <returns>Результат выполнения success/error</returns>
    Task<BaseResponse> ChangeUserAvatarAsync(string avatar, string userId);
    
    /// <summary>
    /// Пополнение баланса пользователя
    /// </summary>
    /// <param name="userId">ID пользователя</param>
    /// <param name="value">Сумма, на которую необходимо пополнить баланс</param>
    /// <returns>Результат выполнения success/error</returns>
    Task<BaseResponse> AddFundsToBalanceAsync(string userId, decimal value);
    
    /// <summary>
    /// Списание денег с баланса пользователя
    /// </summary>
    /// <param name="userId">ID пользователя</param>
    /// <param name="value">Сумма, которую необходимо списать</param>
    /// <returns>Результат выполнения success/error</returns>
    Task<BaseResponse> RemoveFundsFromBalanceAsync(string userId, decimal value);
    
    /// <summary>
    /// Получение всех транзакций пользователя по ID
    /// </summary>
    /// <param name="userId">ID пользователя</param>
    /// <returns>Список транзакций пользователя</returns>
    Task<TransactionResponse[]> GetUserTransactionsAsync(string userId);
    
    /// <summary>
    /// Покупка подписки у пользователя
    /// </summary>
    /// <param name="userId">ID пользователя</param>
    /// <param name="price">Цена подписки</param>
    /// <param name="subscriptionType">Тип подписки</param>
    /// <returns>Результат выполнения success/error</returns>
    Task<BaseResponse> BuySubscriptionAsync(string userId, decimal price, SubscriptionType subscriptionType);
}