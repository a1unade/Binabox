using System.Net;
using Binabox.Application.Common.Enums;
using Binabox.Application.DTOs.User;
using Binabox.Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Binabox.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController(IUserService userService) : ControllerBase
{
    /// <summary>
    /// Получение пользователя по адресу электронной почты
    /// </summary>
    /// <param name="email">Электронная почта пользователя</param>
    /// <returns>Пользователь (email, subscription, type, nickname)</returns>
    [HttpGet("getUserByEmail/{email}")]
    public async Task<IActionResult> GetUserByEmail(string email)
    {
        try
        {
            var response = await userService.GetUserByEmailAsync(WebUtility.UrlDecode(email));

            return Ok(response);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    /// <summary>
    /// Получение пользователя по ID
    /// </summary>
    /// <param name="id">ID пользователя</param>
    /// <returns>Пользователь (email, subscription, type, nickname)</returns>
    [HttpGet("getUserById/{id}")]
    public async Task<IActionResult> GetUserById(string id)
    {
        try
        {
            var response = await userService.GetUserByIdAsync(id);

            return Ok(response);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    /// <summary>
    /// Смена никнейма у пользователя
    /// </summary>
    /// <param name="dto">Новый никнейм и ID пользователя</param>
    /// <returns>Результат выполнения success/error</returns>
    [HttpPost("changeNickname")]
    public async Task<IActionResult> ChangeUserNickname(ChangeNicknameDto dto)
    {
        try
        {
            var response = await userService.ChangeUserNicknameAsync(dto.Nickname, dto.UserId);

            if (response.ResponseType == ResponseTypes.Error)
                return BadRequest("Не получилось сменить никнейм!");

            return Ok(response);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    
    /// <summary>
    /// Смена аватарки у пользователя
    /// </summary>
    /// <param name="dto">Новая аватарка и ID пользователя</param>
    /// <returns>Результат выполнения success/error</returns>
    [HttpPost("changeAvatar")]
    public async Task<IActionResult> ChangeUserNickname(ChangeAvatarDto dto)
    {
        try
        {
            var response = await userService.ChangeUserAvatarAsync(dto.Avatar, dto.UserId);

            if (response.ResponseType == ResponseTypes.Error)
                return BadRequest("Не получилось сменить аватарку!");

            return Ok(response);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    /// <summary>
    /// Пополнение баланса пользователя
    /// </summary>
    /// <param name="dto">ID пользователя и сумма пополнения</param>
    /// <returns>Результат выполнения success/error</returns>
    [HttpPost("addFunds")]
    public async Task<IActionResult> AddFunds(AddFundsDto dto)
    {
        try
        {
            var response = await userService.AddFundsToBalanceAsync(dto.UserId, dto.Value);

            if (response.ResponseType == ResponseTypes.Error)
                return BadRequest("Не получилось пополнить баланс!");

            return Ok(response);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    
    /// <summary>
    /// Списание суммы с баланса пользователя
    /// </summary>
    /// <param name="dto">ID пользователя и сумма списания</param>
    /// <returns>Результат выполнения success/error</returns>
    [HttpPost("removeFunds")]
    public async Task<IActionResult> RemoveFunds(AddFundsDto dto)
    {
        try
        {
            var response = await userService.RemoveFundsFromBalanceAsync(dto.UserId, dto.Value);

            if (response.ResponseType == ResponseTypes.Error)
                return BadRequest("Не получилось списать сумму с баланса!");

            return Ok(response);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    /// <summary>
    /// Получение транзакций пользователя
    /// </summary>
    /// <param name="userId">ID пользователя</param>
    /// <returns>Список транзакций пользователя</returns>
    [HttpGet("getUserTransactions")]
    public async Task<IActionResult> GetUserTransactions([FromQuery] string userId)
    {
        try
        {
            var response = await userService.GetUserTransactionsAsync(userId);

            return Ok(response);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    
    /// <summary>
    /// Покупка подписки
    /// </summary>
    /// <param name="dto">ID пользователя, сумма списания и тип подписки</param>
    /// <returns>Результат выполнения success/error</returns>
    [HttpPost("buySubscription")]
    public async Task<IActionResult> BuySubscription(BuySubscriptionDto dto)
    {
        try
        {
            var response = await userService.BuySubscriptionAsync(dto.UserId, dto.Price, dto.SubscriptionType);

            if (response.ResponseType == ResponseTypes.Error)
                return BadRequest("Не получилось купить подписку!");

            return Ok(response);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}