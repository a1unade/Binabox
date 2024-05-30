using Binabox.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Binabox.Application.Interfaces;

public interface IApplicationDbContext
{
    /// <summary>
    /// Пользователи
    /// </summary>
    public DbSet<User> Users { get; set; }

    /// <summary>
    /// Информация о пользователе
    /// </summary>
    public DbSet<UserInfo> UserInfos { get; set; }
    
    /// <summary>
    /// Товары в магазине
    /// </summary>
    public DbSet<ShopItem> ShopItems { get; set; }
    
    /// <summary>
    /// Детальная информация о товарах
    /// </summary>
    public DbSet<ItemDetail> ItemDetails { get; set; }
    
    /// <summary>
    /// Категории для фильтрации товаров
    /// </summary>
    public DbSet<ItemCategory> ItemCategories { get; set; }
    
    /// <summary>
    /// Аватарки пользователей
    /// </summary>
    public DbSet<Avatar> Avatars { get; set; }
    
    /// <summary>
    /// Баннер на главной странице
    /// </summary>
    public DbSet<Banner> Banners { get; set; }
    
    /// <summary>
    /// Блок с работой сайта
    /// </summary>
    public DbSet<Work> Works { get; set; }
    
    /// <summary>
    /// Информация из блока "о нас"
    /// </summary>
    public DbSet<About> Abouts { get; set; }
    
    /// <summary>
    /// Счетчик статистики сайта
    /// </summary>
    public DbSet<AboutCounter> AboutCounters { get; set; }
    
    /// <summary>
    /// Статы сайта
    /// </summary>
    public DbSet<AboutStat> AboutStats { get; set; }
    
    /// <summary>
    /// Команда разработчиков сайта
    /// </summary>
    public DbSet<Team> Teams { get; set; }
    
    /// <summary>
    /// Контактная информация
    /// </summary>
    public DbSet<Contact> Contacts { get; set; }
    
    /// <summary>
    /// Отзывы пользователей
    /// </summary>
    public DbSet<Review> Reviews { get; set; }
    
    /// <summary>
    /// Страница с отзывами пользователей
    /// </summary>
    public DbSet<ReviewInfo> ReviewInfos { get; set; }
    
    /// <summary>
    /// Часто задаваемые вопросы
    /// </summary>
    public DbSet<Faq> Faqs { get; set; }
    
    /// <summary>
    /// Дорожная карта сайта
    /// </summary>
    public DbSet<RoadMap> RoadMaps { get; set; }
    
    /// <summary>
    /// Улучшения из дорожной карты
    /// </summary>
    public DbSet<RoadMapBenefit> RoadMapBenefits { get; set; }
    
    /// <summary>
    /// Платежи
    /// </summary>
    public DbSet<Payment> Payments { get; set; }
    
    /// <summary>
    /// Подписки
    /// </summary>
    public DbSet<Subscription> Subscriptions { get; set; }
    
    /// <summary>
    /// Привилегии подписок
    /// </summary>
    public DbSet<SubscriptionProperty> SubscriptionProperties { get; set; }
    
    /// <summary>
    /// Транзакции пользователей
    /// </summary>
    public DbSet<Transaction> Transactions { get; set; }
    
    /// <summary>
    /// Фидбек пользователей
    /// </summary>
    public DbSet<UserFeedback> UserFeedbacks { get; set; }
}