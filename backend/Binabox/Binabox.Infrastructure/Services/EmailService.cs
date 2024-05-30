using Binabox.Application.Common.Responses;
using MimeKit;
using MailKit.Net.Smtp;
using Binabox.Application.Interfaces.Services;

namespace Binabox.Infrastructure.Services;

public class EmailService: IEmailService
{
    private const string Host = "smtp.yandex.com";
    private const int Port = 465;
    
    public async Task SendEmailAsync(string email, string subject, string messageBody)
    {
        try
        {
            using var smtpClient = new SmtpClient();

            await smtpClient.ConnectAsync(Host, Port, true);
            await smtpClient.AuthenticateAsync("jinx.httpserver@yandex.ru", "kfgxrkizhidqhnyd");
            await smtpClient.SendAsync(GenerateMessage(email, subject, messageBody));
            await smtpClient.DisconnectAsync(true);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Failed to send mail message: {ex.Message}");
        }
    }

    private MimeMessage GenerateMessage(string email, string subject, string messageBody)
    {
        return new MimeMessage
        {
            From = {new MailboxAddress("Binabox", "jinx.httpserver@yandex.ru")},
            To = {new MailboxAddress("", email)},
            Subject = subject,
            Body = new BodyBuilder { HtmlBody = messageBody }.ToMessageBody(),
        };
    }

    public string GenerateEmailConfirmationMessage(string link) =>
        @"
            <!DOCTYPE html>
            <html>
            <head>
                <style>
                    body {
                        font-family: Arial, sans-serif;
                    }
                    .container {
                        width: 100%;
                        max-width: 600px;
                        margin: auto;
                        border: 1px solid #cccccc;
                        padding: 20px;
                    }
                    .header {
                        background-color: #21E786;
                        color: white;
                        text-align: center;
                        padding: 10px 0;
                    }
                    .content {
                        margin: 20px 0;
                    }
                    .footer {
                        text-align: center;
                        color: #777777;
                        font-size: 12px;
                        margin-top: 20px;
                    }
                </style>
            </head>
            <body>
                <div class='container'>
                    <div class='header'>
                        <h1>Welcome to Our Service</h1>
                    </div>
                    <div class='content'>
                        <p>Dear Customer,</p>
                        <p>Thank you for joining our service. We are excited to have you with us.</p>" +
                        $"<a href=\"{link}\">Confirm email</a>" +
                        @"</div>
                        <div class='footer'>
                            <p>&copy; 2024 Binabox. All rights reserved.</p>
                        </div>
                    </div>
            </body>
            </html>";

    public string GenerateBoughtItemMessage(ItemResponse item) => 
        @"
            <!DOCTYPE html>
            <html>
            <head>
                <style>
                    body {
                        font-family: Arial, sans-serif;
                    }
                    .container {
                        width: 100%;
                        max-width: 600px;
                        margin: auto;
                        border: 1px solid #cccccc;
                        padding: 20px;
                    }
                    .header {
                        background-color: #21E786;
                        color: white;
                        text-align: center;
                        padding: 10px 0;
                    }
                    .content {
                        margin: 20px 0;
                    }
                    .footer {
                        text-align: center;
                        color: #777777;
                        font-size: 12px;
                        margin-top: 20px;
                    }
                </style>
            </head>
            <body>
                <div class='container'>
                    <div class='header'>
                        <h1>Welcome to Our Service</h1>
                    </div>
                    <div class='content'>
                        <p>Dear Customer,</p>
                        <p>Your item successfully delivered</p>" +
                        $"<p>Title: {item.Title}</p>" +
                        $"<img src=\"{item.Image}\" alt=\"{item.Title}\" />" +
                        $"<p>Description: {item.Description}</p>" +
                        $"<p>Price: {item.Price}</p>" +
                        @"</div>
                        <div class='footer'>
                            <p>&copy; 2024 Binabox. All rights reserved.</p>
                        </div>
                    </div>
            </body>
            </html>";
}