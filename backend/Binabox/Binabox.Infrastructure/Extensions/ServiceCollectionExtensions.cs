using Binabox.Application.Interfaces.Services;
using Binabox.Infrastructure.Services;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Binabox.Infrastructure.Extensions;

public static class ServiceCollectionExtensions
{
    public static void AddInfrastructureLayer(this IServiceCollection services) => services.AddServices();

    private static void AddServices(this IServiceCollection services)
    {
        services.AddSignalR();
        
        services
            .AddScoped<IMediator, Mediator>()
            .AddScoped<IAuthService, AuthService>()
            .AddScoped<IEmailService, EmailService>()
            .AddScoped<IUserService, UserService>()
            .AddScoped<IShopService, ShopService>()
            .AddScoped<IStaticService, StaticService>();
    }
}