using Binabox.Application.Common.Responses;
using Binabox.Domain.Common.Enums;
using Binabox.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace Binabox.Application.Interfaces.Repositories;

public interface IUserRepository
{
    /// <summary>
    /// Получение User по адресу электронной почты
    /// </summary>
    /// <param name="email">Адрес электронной почты</param>
    /// <returns>Пользователь (email, nickname, type, subscription)</returns>
    Task<User> GetUserByEmailAsync(string email);
    
    /// <summary>
    /// Получение User по ID
    /// </summary>
    /// <param name="id">ID пользователя</param>
    /// <returns>Пользователь (email, nickname, type, subscription)</returns>
    Task<User> GetUserByIdAsync(string id);

    /// <summary>
    /// Получение списка всех пользователей
    /// </summary>
    /// <returns>Список пользователей</returns>
    Task<List<User>> GetUsersListAsync();

    /// <summary>
    /// Поиск пользователя по ID
    /// </summary>
    /// <param name="id">ID пользователя</param>
    /// <returns>Пользователь</returns>
    Task<User> FindUserByIdAsync(string id);

    /// <summary>
    /// Подтверждение почты пользователя
    /// </summary>
    /// <param name="user">Пользователь</param>
    /// <param name="token">Токен подтверждения</param>
    /// <returns>Результат выполнения success/error</returns>
    Task<IdentityResult> ConfirmUserEmailAsync(User user, string token);

    /// <summary>
    /// Добавление нового пользователя
    /// </summary>
    /// <param name="user">Пользователь</param>
    /// <param name="password">Пароль пользователя</param>
    /// <returns>Результат выполнения success/error</returns>
    Task<IdentityResult> CreateUserAsync(User user, string password);

    /// <summary>
    /// Создание токена подтверждения для пользователя
    /// </summary>
    /// <param name="user">Пользователь</param>
    /// <returns>Токен подтверждения</returns>
    Task<string> GenerateConfirmationTokenAsync(User user);

    /// <summary>
    /// Удаление пользователя
    /// </summary>
    /// <param name="user">Пользователь</param>
    /// <returns>Результат выполнения success/error</returns>
    Task<IdentityResult> DeleteUserAsync(User user);

    /// <summary>
    /// Проверка пароля пользователея
    /// </summary>
    /// <param name="user">Пользователь</param>
    /// <param name="password">Пароль для входа в аккаунт</param>
    /// <returns>Результат проверки true/false в зависимости от соответствия пароля</returns>
    Task<bool> CheckPasswordAsync(User user, string password);

    /// <summary>
    /// Поиск пользователя по адресу электронной почты
    /// </summary>
    /// <param name="email">Адрес электронной почты пользователя</param>
    /// <returns>Пользователь(email, id, password)</returns>
    Task<User> FindUserByEmailAsync(string email);

    /// <summary>
    /// Смена никнейма у пользователя
    /// </summary>
    /// <param name="nickname">новый никнейм</param>
    /// <param name="userId">Id пользователя</param>
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
    /// Добавление денег на баланс пользователя
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
    Task<Transaction[]> GetUserTransactionsAsync(string userId);

    /// <summary>
    /// Покупка подписки у пользователя
    /// </summary>
    /// <param name="userId">ID пользователя</param>
    /// <param name="price">Цена подписки</param>
    /// <param name="subscriptionType">Тип подписки</param>
    /// <returns>Результат выполнения success/error</returns>
    Task<BaseResponse> BuySubscriptionAsync(string userId, decimal price, SubscriptionType subscriptionType);
}