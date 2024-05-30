using Binabox.Application.Common.Enums;
using Binabox.Application.Common.Responses;

namespace Binabox.Application.Interfaces.Services;

public interface IEmailService
{
    /// <summary>
    /// Отправка письма с кодом подтверждения на почту
    /// </summary>
    Task SendEmailAsync(string email, string subject, string messageBody);

    /// <summary>
    /// Создание письма с подтверждением почты
    /// </summary>
    /// <param name="link">Ссылка для подстверждения почты</param>
    /// <returns>Html-письмо для отправки</returns>
    string GenerateEmailConfirmationMessage(string link);

    string GenerateBoughtItemMessage(ItemResponse item);
}