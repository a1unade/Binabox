using Binabox.Application.Common.Enums;
using Binabox.Application.DTOs.Static;
using Binabox.Application.Interfaces.Services;
using Binabox.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Binabox.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SiteController(IStaticService staticService): ControllerBase
{
    /// <summary>
    /// Получение информации для баннера с учетом локализации
    /// </summary>
    /// <param name="lang">Язык локализации</param>
    /// <returns>Информация для баннера на главной странице</returns>
    [HttpGet("banner")]
    public async Task<IActionResult> GetBannerData([FromQuery] string lang)
    {
        try
        {
            var response = await staticService.GetBannerDataAsync(lang);
            return Ok(response);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    /// <summary>
    /// Получение информации для блока "как работает сайт" с учетом локализации
    /// </summary>
    /// <param name="lang">Язык локализации</param>
    /// <returns>Информация для блока "как работает сайт"</returns>
    [HttpGet("works")]
    public async Task<IActionResult> GetHowSiteWorksData([FromQuery] string lang)
    {
        try
        {
            var response = await staticService.GetHowSiteWorksInfoAsync(lang);

            return Ok(response);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    
    /// <summary>
    /// Получение информации для блока "о нас" с учетом локализации
    /// </summary>
    /// <param name="lang">Язык локализации</param>
    /// <returns>Информация для блока "о нас"</returns>
    [HttpGet("about")]
    public async Task<IActionResult> GetAboutUsData([FromQuery] string lang)
    {
        try
        {
            var response = await staticService.GetAboutUsInfoAsync(lang);
            return Ok(response);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    /// <summary>
    /// Получение информации для блока "наша команда" с учетом локализации
    /// </summary>
    /// <param name="lang">Язык локализации</param>
    /// <returns>Информация для блока "наша команда"</returns>
    [HttpGet("team")]
    public async Task<IActionResult> GetOurTeamData([FromQuery] string lang)
    {
        try
        {
            var response = await staticService.GetOurTeamInfoAsync(lang);
            return Ok(response);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    /// <summary>
    /// Получение информации для блока "контакты" с учетом локализации
    /// </summary>
    /// <param name="lang">Язык локализации</param>
    /// <returns>Информация для блока "контакты"</returns>
    [HttpGet("contact")]
    public async Task<IActionResult> GetContactUsData([FromQuery] string lang)
    {
        try
        {
            var response = await staticService.GetContactUsInfoAsync(lang);
            return Ok(response);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    
    /// <summary>
    /// Получение информации для блока "вопросы" с учетом локализации
    /// </summary>
    /// <param name="lang">Язык локализации</param>
    /// <returns>Информация для блока "вопросы"</returns>
    [HttpGet("faq")]
    public async Task<Faq[]> GetFaqsData([FromQuery] string lang) =>
        await staticService.GetFaqsInfoAsync(lang);
    
    /// <summary>
    /// Получение информации для блока "отзывы" с учетом локализации
    /// </summary>
    /// <param name="lang">Язык локализации</param>
    /// <returns>Информация для блока "отзывы"</returns>
    [HttpGet("reviews")]
    public async Task<IActionResult> GetReviewsData([FromQuery] string lang)
    {
        try
        {
            var response = await staticService.GetReviewsInfoAsync(lang);
            return Ok(response);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    /// <summary>
    /// Получение информации для блока "дорожная карта" с учетом локализации
    /// </summary>
    /// <param name="lang">Язык локализации</param>
    /// <returns>Информация для блока "дорожная карта"</returns>
    [HttpGet("roadMap")]
    public async Task<IActionResult> GetRoadMapData([FromQuery] string lang)
    {
        try
        {
            var response = await staticService.GetRoadMapInfoAsync(lang);
            return Ok(response);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    /// <summary>
    /// Получение информации для блока "платежи" с учетом локализации
    /// </summary>
    /// <param name="lang">Язык локализации</param>
    /// <returns>Информация для блока "платежи"</returns>
    [HttpGet("payments")]
    public async Task<IActionResult> GetPaymnetsData([FromQuery] string lang)
    {
        try
        {
            var response = await staticService.GetPaymentsInfoAsync(lang);
            return Ok(response);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    /// <summary>
    /// Добавление нового отзыва с учетом локализации
    /// </summary>
    /// <param name="reviewDto">Никнейм и аватарка пользователя, текст отзыва и язык локализации</param>
    /// <returns>Результат выполнения success/error</returns>
    [HttpPost("addReview")]
    public async Task<IActionResult> AddNewReview(ReviewDto reviewDto)
    {
        try
        {
            var response = await staticService.AddNewReviewAsync(reviewDto.Nickname, reviewDto.Avatar, 
                reviewDto.Text, reviewDto.Language);

            if (response.ResponseType == ResponseTypes.Error)
                return BadRequest(response.Errors);
            
            return Ok(response);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    /// <summary>
    /// Получение списка аватарок
    /// </summary>
    /// <returns>Список аватарок</returns>
    [HttpGet("getAvatarsList")]
    public async Task<IActionResult> GetAvatarsList()
    {
        try
        {
            var response = await staticService.GetAvatarsListAsync();

            return Ok(response);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    /// <summary>
    /// Сохранение файла
    /// </summary>
    /// <param name="dto">Файл, который нужно сохранить</param>
    /// <returns>Результат выполнения success + url картинки/error</returns>
    [HttpPost("saveFile")]
    public async Task<IActionResult> SaveFile(SaveFileDto dto)
    {
        try
        {
            var response = await staticService.SaveFileAsync(dto.File);

            return Ok(response);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    
    /// <summary>
    /// Получение списка фидбека от пользователей
    /// </summary>
    /// <returns>Фидбек</returns>
    [HttpGet("getFeedback")]
    public async Task<IActionResult> GetUsersFeedback()
    {
        try
        {
            var response = await staticService.GetUsersFeedbackAsync();

            return Ok(response);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    /// <summary>
    /// Добавление фидбека от пользователя
    /// </summary>
    /// <param name="dto">Имя, почта, фидбек</param>
    /// <returns>Результат выполнения success/error</returns>
    [HttpPost("addFeedback")]
    public async Task<IActionResult> AddNewFeedback(FeedbackDto dto)
    {
        try
        {
            var response = await staticService.AddNewFeedbackAsync(dto.Name, dto.Email, dto.Message);

            if (response.ResponseType == ResponseTypes.Error)
                return BadRequest(response.Errors);
            
            return Ok(response);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    /// <summary>
    /// Получение списка всех отзывов
    /// </summary>
    /// <returns></returns>
    [HttpGet("getAllReviews")]
    public async Task<IActionResult> GetAllReviews()
    {
        try
        {
            var response = await staticService.GetAllReviewsAsync();
            
            return Ok(response);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpDelete("deleteReview")]
    public async Task<IActionResult> DeleteReview([FromQuery] int id)
    {
        try
        {
            var response = await staticService.DeleteReviewByIdAsync(id);

            if (response.ResponseType == ResponseTypes.Error)
                return BadRequest(response.Errors);
            
            return Ok(response);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}