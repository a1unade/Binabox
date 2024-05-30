using Binabox.Application.Interfaces.Repositories;
using Binabox.Domain.Entities;
using Binabox.Persistence.Contexts;
using Binabox.Persistence.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Binabox.Persistence.Extensions;

public static class ServiceCollectionExtensions
{
    public static void AddPersistenceLayer(this IServiceCollection services, IConfiguration configuration)
    {
        //services.AddMappings();
        services.AddDbContext(configuration);
        services.AddRepositories();
    }

    //private static void AddMappings(this IServiceCollection services)
    //{
    //    services.AddAutoMapper(Assembly.GetExecutingAssembly());
    //}

    private static void AddDbContext(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseNpgsql(configuration.GetConnectionString("Postgres"),
                builder => builder.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));
    }

    private static void AddRepositories(this IServiceCollection services)
    {
        services.AddIdentity<User, IdentityRole<Guid>>(options =>
            {
                options.User.RequireUniqueEmail = true;
                options.SignIn.RequireConfirmedEmail = true;
            })
            .AddDefaultTokenProviders()
            .AddEntityFrameworkStores<ApplicationDbContext>();
        
        services
            .AddTransient(typeof(IUnitOfWork), typeof(UnitOfWork))
            .AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>))
            .AddTransient<IUserRepository, UserRepository>()
            .AddTransient<IShopRepository, ShopRepository>()
            .AddTransient<IStaticRepository, StaticRepository>();
    }
}