using Binabox.Application.Common.Responses;
using Binabox.Domain.Entities;
using Microsoft.AspNetCore.Http;

namespace Binabox.Application.Interfaces.Services;

public interface IStaticService
{
    /// <summary>
    /// Получение информации для баннера на главной странице
    /// </summary>
    /// <param name="language">Язык для локализации</param>
    /// <returns>Информация для баннера</returns>
    Task<Banner> GetBannerDataAsync(string language);

    /// <summary>
    /// Получение информации для блока "как работает сайт"
    /// </summary>
    /// <param name="language">Язык для локализации</param>
    /// <returns>Информация из блока "как работает сайт"</returns>
    Task<Work[]> GetHowSiteWorksInfoAsync(string language);

    /// <summary>
    /// Получение информации для блока "о нас"
    /// </summary>
    /// <param name="language">Язык для локализации</param>
    /// <returns>Информация для блока "о нас"</returns>
    Task<AboutResponse> GetAboutUsInfoAsync(string language);
    
    /// <summary>
    /// Получение информации для блока "наша команда"
    /// </summary>
    /// <param name="language">Язык локализации</param>
    /// <returns>Информация для блока "наша команда"</returns>
    Task<Team[]> GetOurTeamInfoAsync(string language);

    /// <summary>
    /// Получение информации для блока "контакты"
    /// </summary>
    /// <param name="language">Язык локализации</param>
    /// <returns>Информация для блока "контакты"</returns>
    Task<Contact[]> GetContactUsInfoAsync(string language);

    /// <summary>
    /// Получение информации для блока "отзывы"
    /// </summary>
    /// <param name="language">Язык локализации</param>
    /// <returns>Информация для блока "отзывы"</returns>
    Task<ReviewResponse> GetReviewsInfoAsync(string language);
    
    /// <summary>
    /// Получение информации для блока "вопросы"
    /// </summary>
    /// <param name="language">Язык локализации</param>
    /// <returns>Информация для блока "вопросы"</returns>
    Task<Faq[]> GetFaqsInfoAsync(string language);
    
    /// <summary>
    /// Получение информации для блока "дорожная карта"
    /// </summary>
    /// <param name="language">Язык локализации</param>
    /// <returns>Информация для блока "дорожная карта"</returns>
    Task<RoadMapResponse[]> GetRoadMapInfoAsync(string language);
    
    /// <summary>
    /// Получение информации для блока "платежи"
    /// </summary>
    /// <param name="language">Язык локализации</param>
    /// <returns>Информация для блока "платежи"</returns>
    Task<PaymentsResponse> GetPaymentsInfoAsync(string language);

    /// <summary>
    /// Добавление нового отзыва
    /// </summary>
    /// <param name="name">Никнейм автора</param>
    /// <param name="avatar">Аватарка автора</param>
    /// <param name="text">Текст отзыва</param>
    /// <param name="language">Язык локализации</param>
    /// <returns>Резульат выполнения success/error</returns>
    Task<BaseResponse> AddNewReviewAsync(string name, string avatar, string text, string language);
    
    /// <summary>
    /// Получение списка аватарок
    /// </summary>
    /// <returns></returns>
    Task<Avatar[]> GetAvatarsListAsync();

    /// <summary>
    /// Сохранение файла
    /// </summary>
    /// <param name="file">Файл, который нужно сохранить</param>
    /// <returns>Результат выполнения  success + url картинки/error</returns>
    Task<SaveFileResponse> SaveFileAsync(IFormFile file);
    
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
    
    // <summary>
    /// Получение списка всех отзывов
    /// </summary>
    /// <returns>Список всех отзывов</returns>
    Task<ReviewListResponse[]> GetAllReviewsAsync();

    /// <summary>
    /// Удаление отзыва по ID
    /// </summary>
    /// <param name="id">ID отзыва</param>
    /// <returns></returns>
    Task<BaseResponse> DeleteReviewByIdAsync(int id);
}