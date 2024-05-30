using Binabox.Application.Common.Responses;
using Binabox.Domain.Entities;

namespace Binabox.Application.Interfaces.Repositories;

public interface IStaticRepository
{
    /// <summary>
    /// Получение данных для баннера сайта с учетом локализации
    /// </summary>
    /// <param name="language">Язык локализации</param>
    /// <returns>Данные для баннера</returns>
    Task<Banner> GetBannerDataByLanguageAsync(string language);

    /// <summary>
    /// Получение информации для блока "как работает сайт" с учетом локализации
    /// </summary>
    /// <param name="language">Язык локализации</param>
    /// <returns>Данные для блока "как работает сайт"</returns>
    Task<Work[]> GetHowItWorksInfoByLanguageAsync(string language);

    /// <summary>
    /// Получение информации для блока "о нас" с учетом локализации
    /// </summary>
    /// <param name="language">Язык локализации</param>
    /// <returns>Данные для блока "о нас"</returns>
    Task<About> GetAboutUsInfoByLanguageAsync(string language);

    /// <summary>
    /// Получение информации для блока "наша команда" с учетом локализации
    /// </summary>
    /// <param name="language">Язык локализации</param>
    /// <returns>Данные для блока "наша команда"</returns>
    Task<Team[]> GetTeamInfoByLanguageAsync(string language);

    /// <summary>
    /// Получение информации для блока "контакты" с учетом локализации
    /// </summary>
    /// <param name="language">Язык локализации</param>
    /// <returns>Данные для блока "контакты"</returns>
    Task<Contact[]> GetContactsInfoByLanguageAsync(string language);

    /// <summary>
    /// Получение информации для блока "отзывы" с учетом локализации
    /// </summary>
    /// <param name="language">Язык локализации</param>
    /// <returns>Данные для блока "отзывы"</returns>
    Task<ReviewInfo> GetReviewsInfoByLanguageAsync(string language);

    /// <summary>
    /// Получение информации для блока "вопросы" с учетом локализации
    /// </summary>
    /// <param name="language">Язык локализации</param>
    /// <returns>Данные для блока "вопросы"</returns>
    Task<Faq[]> GetFaqsInfoByLanguageAsync(string language);
    
    /// <summary>
    /// Получение информации для блока "дорожная карта" с учетом локализации
    /// </summary>
    /// <param name="language">Язык локализации</param>
    /// <returns>Данные для блока "дорожная карта"</returns>
    Task<RoadMap[]> GetRoadMapInfoByLanguageAsync(string language);
    
    /// <summary>
    /// Получение информации для блока "платежи" с учетом локализации
    /// </summary>
    /// <param name="language">Язык локализации</param>
    /// <returns>Данные для блока "платежи"</returns>
    Task<Payment> GetPaymentsInfoByLanguageAsync(string language);

    /// <summary>
    /// Добавление нового отзыва
    /// </summary>
    /// <param name="name">Никнейм автора</param>
    /// <param name="avatar">Аватарка автора</param>
    /// <param name="text">Текст отзыва</param>
    /// /// <param name="reviewInfoId">Id для локализации</param>
    /// <returns>Резульат выполнения success/error</returns>
    Task<BaseResponse> AddNewReviewAsync(string name, string avatar, string text, int reviewInfoId);

    /// <summary>
    /// Получение списка аватарок
    /// </summary>
    /// <returns></returns>
    Task<Avatar[]> GetAvatarsListAsync();

    /// <summary>
    /// Получение списка с фидбеком от пользователей
    /// </summary>
    /// <returns>Список с фидбеком от пользователей</returns>
    Task<UserFeedback[]> GetUsersFeedbackAsync();

    /// <summary>
    /// Добавление фидбека от пользователя
    /// </summary>
    /// <param name="name">Имя пользователя</param>
    /// <param name="email">Почта пользователя</param>
    /// <param name="message">Фидбек</param>
    /// <returns>Результат выполнения success/error</returns>
    Task<BaseResponse> AddNewFeedbackAsync(string name, string email, string message);

    /// <summary>
    /// Получение списка всех отзывов
    /// </summary>
    /// <returns>Список всех отзывов</returns>
    Task<Review[]> GetAllReviewsAsync();

    /// <summary>
    /// Удаление отзыва по ID
    /// </summary>
    /// <param name="id">ID отзыва</param>
    /// <returns></returns>
    Task<BaseResponse> DeleteReviewByIdAsync(int id);
}