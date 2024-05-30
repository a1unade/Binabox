using Binabox.Application.Interfaces;
using Binabox.Domain.Entities;
using Binabox.Persistence.Configurations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Binabox.Persistence.Contexts;

public sealed class ApplicationDbContext : IdentityDbContext<User, IdentityRole<Guid>, Guid>, IApplicationDbContext
{
    public new DbSet<User> Users { get; set; }
    public DbSet<UserInfo> UserInfos { get; set; }
    public DbSet<ShopItem> ShopItems { get; set; }
    public DbSet<ItemDetail> ItemDetails { get; set; }
    public DbSet<ItemCategory> ItemCategories { get; set; }
    public DbSet<Avatar> Avatars { get; set; }
    public DbSet<Banner> Banners { get; set; }
    public DbSet<Work> Works { get; set; }
    public DbSet<About> Abouts { get; set; }
    public DbSet<AboutCounter> AboutCounters { get; set; }
    public DbSet<AboutStat> AboutStats { get; set; }
    public DbSet<Team> Teams { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<ReviewInfo> ReviewInfos { get; set; }
    public DbSet<Faq> Faqs { get; set; }
    public DbSet<RoadMap> RoadMaps { get; set; }
    public DbSet<RoadMapBenefit> RoadMapBenefits { get; set; }
    public DbSet<Subscription> Subscriptions { get; set; }
    public DbSet<SubscriptionProperty> SubscriptionProperties { get; set; }
    public DbSet<Payment> Payments { get; set; }
    public DbSet<Transaction> Transactions { get; set; }
    public DbSet<UserFeedback> UserFeedbacks { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
        : base(options)
    {
    }

    public ApplicationDbContext()
    {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=9329;Username=postgres;Password=binabox;Database=postgres;");
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.ApplyConfiguration(new UserConfiguration());
        modelBuilder.ApplyConfiguration(new ItemCategoryConfiguration());
        modelBuilder.ApplyConfiguration(new ItemDetailsConfiguration());
        modelBuilder.ApplyConfiguration(new ShopItemConfiguration());
        modelBuilder.ApplyConfiguration(new AboutConfiguration());
        modelBuilder.ApplyConfiguration(new ReviewInfoConfiguration());
        modelBuilder.ApplyConfiguration(new RoadMapConfiguration());
        modelBuilder.ApplyConfiguration(new SubscriptionConfiguration());
        modelBuilder.ApplyConfiguration(new TransactiontConfiguration());
        
        modelBuilder.Entity<ShopItem>().HasData(DatabaseSeeder.ShopItems());
        modelBuilder.Entity<ItemDetail>().HasData(DatabaseSeeder.ItemDetails());
        modelBuilder.Entity<ItemCategory>().HasData(DatabaseSeeder.ItemCategories());
        modelBuilder.Entity<Avatar>().HasData(DatabaseSeeder.Avatars());
        modelBuilder.Entity<Banner>().HasData(DatabaseSeeder.Banners());
        modelBuilder.Entity<Work>().HasData(DatabaseSeeder.Works());
        modelBuilder.Entity<About>().HasData(DatabaseSeeder.Abouts());
        modelBuilder.Entity<AboutCounter>().HasData(DatabaseSeeder.AboutCounters());
        modelBuilder.Entity<AboutStat>().HasData(DatabaseSeeder.AboutStats());
        modelBuilder.Entity<Team>().HasData(DatabaseSeeder.Teams());
        modelBuilder.Entity<Contact>().HasData(DatabaseSeeder.Contacts());
        modelBuilder.Entity<ReviewInfo>().HasData(DatabaseSeeder.ReviewInfos());
        modelBuilder.Entity<Review>().HasData(DatabaseSeeder.Reviews());
        modelBuilder.Entity<Faq>().HasData(DatabaseSeeder.Faqs());
        modelBuilder.Entity<RoadMap>().HasData(DatabaseSeeder.RoadMaps());
        modelBuilder.Entity<RoadMapBenefit>().HasData(DatabaseSeeder.RoadMapBenefits());
        modelBuilder.Entity<Payment>().HasData(DatabaseSeeder.Payments());
        modelBuilder.Entity<Subscription>().HasData(DatabaseSeeder.Subscriptions());
        modelBuilder.Entity<SubscriptionProperty>().HasData(DatabaseSeeder.SubscriptionProperties());
    }
}

