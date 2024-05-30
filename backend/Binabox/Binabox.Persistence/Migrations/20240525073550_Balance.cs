using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Binabox.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Balance : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Language = table.Column<string>(type: "text", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Avatars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Url = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Avatars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Banners",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Language = table.Column<string>(type: "text", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Language = table.Column<string>(type: "text", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Image = table.Column<string>(type: "text", nullable: false),
                    Info = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Faqs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Language = table.Column<string>(type: "text", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    Show = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faqs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Language = table.Column<string>(type: "text", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReviewInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Language = table.Column<string>(type: "text", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReviewInfos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoadMaps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Language = table.Column<string>(type: "text", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Class = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoadMaps", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShopItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Image = table.Column<string>(type: "text", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Language = table.Column<string>(type: "text", nullable: false),
                    Image = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Position = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserFeedbacks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Message = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFeedbacks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Works",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Language = table.Column<string>(type: "text", nullable: false),
                    Image = table.Column<string>(type: "text", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Works", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AboutCounters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Language = table.Column<string>(type: "text", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Number = table.Column<int>(type: "integer", nullable: false),
                    AboutId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutCounters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AboutCounters_Abouts_AboutId",
                        column: x => x.AboutId,
                        principalTable: "Abouts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AboutStats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Language = table.Column<string>(type: "text", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    AboutId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutStats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AboutStats_Abouts_AboutId",
                        column: x => x.AboutId,
                        principalTable: "Abouts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    RoleId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Date = table.Column<DateTime>(type: "date", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transactions_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    Nickname = table.Column<string>(type: "text", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    Subscription = table.Column<int>(type: "integer", nullable: false),
                    Avatar = table.Column<string>(type: "text", nullable: false),
                    Balance = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserInfos_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Subscriptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Language = table.Column<string>(type: "text", nullable: false),
                    Image = table.Column<string>(type: "text", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    PaymentId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subscriptions_Payments_PaymentId",
                        column: x => x.PaymentId,
                        principalTable: "Payments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Text = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Avatar = table.Column<string>(type: "text", nullable: false),
                    ReviewInfoId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_ReviewInfos_ReviewInfoId",
                        column: x => x.ReviewInfoId,
                        principalTable: "ReviewInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoadMapBenefits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Text = table.Column<string>(type: "text", nullable: false),
                    RoadMapId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoadMapBenefits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoadMapBenefits_RoadMaps_RoadMapId",
                        column: x => x.RoadMapId,
                        principalTable: "RoadMaps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ItemId = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemDetails_ShopItems_ItemId",
                        column: x => x.ItemId,
                        principalTable: "ShopItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubscriptionProperties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Text = table.Column<string>(type: "text", nullable: false),
                    SubscriptionId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscriptionProperties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubscriptionProperties_Subscriptions_SubscriptionId",
                        column: x => x.SubscriptionId,
                        principalTable: "Subscriptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ItemDetailId = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Info = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemCategories_ItemDetails_ItemDetailId",
                        column: x => x.ItemDetailId,
                        principalTable: "ItemDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Abouts",
                columns: new[] { "Id", "Description", "Language", "Title" },
                values: new object[,]
                {
                    { 1, "Welcome to our NFT platform! We're passionate about digital art and blockchain technology. Explore our diverse collection of unique NFTs created by talented artists from around the world. Join our vibrant community and discover the future of digital ownership!", "EN", "ABOUT US" },
                    { 2, "Добро пожаловать на нашу платформу NFT! Мы увлечены цифровым искусством и технологией блокчейн. Исследуйте наш разнообразный ассортимент уникальных NFT, созданных талантливыми художниками со всего мира. Присоединяйтесь к нашему живому сообществу и откройте будущее цифровой собственности!", "RU", "О НАС" }
                });

            migrationBuilder.InsertData(
                table: "Avatars",
                columns: new[] { "Id", "Name", "Url" },
                values: new object[,]
                {
                    { 1, "users-1.svg", "http://localhost:5112/static/avatars/users-1.svg" },
                    { 2, "users-2.svg", "http://localhost:5112/static/avatars/users-2.svg" },
                    { 3, "users-3.svg", "http://localhost:5112/static/avatars/users-3.svg" },
                    { 4, "users-4.svg", "http://localhost:5112/static/avatars/users-4.svg" },
                    { 5, "users-5.svg", "http://localhost:5112/static/avatars/users-5.svg" },
                    { 6, "users-6.svg", "http://localhost:5112/static/avatars/users-6.svg" },
                    { 7, "users-7.svg", "http://localhost:5112/static/avatars/users-7.svg" },
                    { 8, "users-8.svg", "http://localhost:5112/static/avatars/users-8.svg" },
                    { 9, "users-9.svg", "http://localhost:5112/static/avatars/users-9.svg" }
                });

            migrationBuilder.InsertData(
                table: "Banners",
                columns: new[] { "Id", "Description", "Language", "Title" },
                values: new object[,]
                {
                    { 1, "We are the best way to check the rarity of NFT collection", "EN", "EXPLORE NFT COLLECTION" },
                    { 2, "Мы лучший способ проверить редкость коллекции NFT", "RU", "ИССЛЕДУЙТЕ КОЛЛЕКЦИЮ NFT" }
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "Image", "Info", "Language", "Title" },
                values: new object[,]
                {
                    { 1, "http://localhost:5112/static/svg/loaction.svg", "2163 Phillips Gap Rd West Jefferson", "EN", "Location" },
                    { 2, "http://localhost:5112/static/svg/email.svg", "Info.avitex@gmail.com", "EN", "Email" },
                    { 3, "http://localhost:5112/static/svg/phone.svg", "2163 Phillips Gap Rd West Jefferson", "EN", "Phone" },
                    { 4, "http://localhost:5112/static/svg/loaction.svg", "+1 666 8888", "RU", "Местоположение" },
                    { 5, "http://localhost:5112/static/svg/email.svg", "Info.avitex@gmail.com", "RU", "Электронная почта" },
                    { 6, "http://localhost:5112/static/svg/phone.svg", "+1 666 8888", "RU", "Номер телефона" }
                });

            migrationBuilder.InsertData(
                table: "Faqs",
                columns: new[] { "Id", "Language", "Show", "Text", "Title" },
                values: new object[,]
                {
                    { 1, "EN", true, "NFTs, or Non-Fungible Tokens, are unique digital assets stored on a blockchain that represent ownership of a specific item or piece of content. Unlike cryptocurrencies, each NFT is distinct and cannot be exchanged on a one-to-one basis.", "What are NFTs?" },
                    { 2, "EN", false, "Acquiring NFTs typically involves purchasing them from online marketplaces or participating in NFT auctions. You'll need a digital wallet compatible with the blockchain where the NFTs are hosted to store and manage your acquisitions.", "How do I acquire NFTs?" },
                    { 3, "EN", false, "Buying and investing in NFTs requires understanding the market dynamics and potential value of digital assets. Research different platforms and projects, evaluate the authenticity and uniqueness of NFTs, and consider long-term investment strategies.", "How can we buy and invest in NFTs?" },
                    { 4, "EN", false, "You can buy and sell NFTs on various online platforms called NFT marketplaces. These platforms facilitate transactions between buyers and sellers, providing a secure environment for trading digital assets.", "Where can we buy and sell NFTs?" },
                    { 5, "EN", false, "The team behind the project consists of experienced professionals in blockchain technology, digital art, finance, and software development. They are dedicated to building innovative solutions and fostering the growth of the NFT ecosystem.", "Who is the team behind the project?" },
                    { 6, "EN", false, "The contract address is a unique identifier assigned to the smart contract governing the creation and transfer of NFTs. It serves as a reference point for verifying the authenticity and integrity of NFT transactions on the blockchain.", "What is your contract address?" },
                    { 7, "RU", true, "NFT, или Необменяемые Токены, - это уникальные цифровые активы, хранящиеся на блокчейне и представляющие собой владение определенным предметом или контентом. В отличие от криптовалют, каждый NFT уникален и не может быть обменен в один-на-один.", "Что такое NFT?" },
                    { 8, "RU", false, "Приобретение NFT обычно включает покупку их на онлайн-рынках или участие в аукционах NFT. Вам понадобится цифровой кошелек, совместимый с блокчейном, где хранятся NFT, для хранения и управления вашими приобретениями.", "Как я могу приобрести NFT?" },
                    { 9, "RU", false, "Покупка и инвестирование в NFT требует понимания динамики рынка и потенциальной стоимости цифровых активов. Изучите различные платформы и проекты, оцените подлинность и уникальность NFT, и рассмотрите стратегии долгосрочного инвестирования.", "Как мы можем покупать и инвестировать в NFT?" },
                    { 10, "RU", false, "Вы можете покупать и продавать NFT на различных онлайн-платформах, называемых рынками NFT. Эти платформы облегчают сделки между покупателями и продавцами, обеспечивая безопасную среду для торговли цифровыми активами.", "Где мы можем покупать и продавать NFT?" },
                    { 11, "RU", false, "Команда проекта состоит из опытных специалистов в области технологии блокчейн, цифрового искусства, финансов и разработки программного обеспечения. Они посвятили себя созданию инновационных решений и развитию экосистемы NFT.", "Кто составляет команду проекта?" },
                    { 12, "RU", false, "Адрес контракта - это уникальный идентификатор, присвоенный смарт-контракту, регулирующему создание и передачу NFT. Он служит точкой ссылки для проверки подлинности и целостности транзакций NFT на блокчейне.", "Каков ваш адрес контракта?" }
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "Id", "Description", "Language", "Title" },
                values: new object[,]
                {
                    { 1, "Explore our diverse range of subscription plans tailored to meet your needs. Whether you're a beginner or an advanced user, we have a subscription that's perfect for you. Take the next step in your journey with us!", "EN", "SUBSCRIPTIONS" },
                    { 2, "Исследуйте наш разнообразный выбор подписок, созданных, чтобы удовлетворить ваши потребности. Независимо от того, являетесь ли вы новичком или опытным пользователем, у нас есть подписка, идеально подходящая для вас. Сделайте следующий шаг в своем путешествии вместе с нами!", "RU", "Подписки" }
                });

            migrationBuilder.InsertData(
                table: "ReviewInfos",
                columns: new[] { "Id", "Description", "Language", "Title" },
                values: new object[,]
                {
                    { 1, "Testimonials from our clients about our work. We take pride in the high praise our work receives.", "EN", "WHAT PEOPLE SAY" },
                    { 2, "Отзывы наших клиентов о нашей работе. Мы гордимся тем, что наша работа оценена так высоко.", "RU", "ЧТО ГОВОРЯТ ЛЮДИ" }
                });

            migrationBuilder.InsertData(
                table: "RoadMaps",
                columns: new[] { "Id", "Class", "Language", "Title" },
                values: new object[,]
                {
                    { 1, "left", "EN", "PHASE 1" },
                    { 2, "right", "EN", "PHASE 2" },
                    { 3, "left", "EN", "PHASE 3" },
                    { 4, "right", "EN", "PHASE 4" },
                    { 5, "left", "EN", "PHASE 5" },
                    { 6, "right", "EN", "PHASE 6" },
                    { 7, "left", "RU", "ФАЗА 1" },
                    { 8, "right", "RU", "ФАЗА 2" },
                    { 9, "left", "RU", "ФАЗА 3" },
                    { 10, "right", "RU", "ФАЗА 4" },
                    { 11, "left", "RU", "ФАЗА 5" },
                    { 12, "right", "RU", "ФАЗА 6" }
                });

            migrationBuilder.InsertData(
                table: "ShopItems",
                columns: new[] { "Id", "Image", "Title" },
                values: new object[,]
                {
                    { 1, "http://localhost:5112/static/product/product1.jpg", "SKISIRS#4587" },
                    { 2, "http://localhost:5112/static/product/product2.jpg", "FROSTIC#4571" },
                    { 3, "http://localhost:5112/static/product/product3.jpg", "MOUNTIANO#8992" },
                    { 4, "http://localhost:5112/static/product/product4.jpg", "SNOWBLIZZ#3315" },
                    { 5, "http://localhost:5112/static/product/product5.jpg", "GLACIERIS#2453" },
                    { 6, "http://localhost:5112/static/product/product6.jpg", "ICETREK#7793" },
                    { 7, "http://localhost:5112/static/product/product7.jpg", "POWDERFLY#6621" },
                    { 8, "http://localhost:5112/static/product/product8.jpg", "AVALANCHEER#1076" },
                    { 9, "http://localhost:5112/static/product/product9.jpg", "SLEDDOR#5538" },
                    { 10, "http://localhost:5112/static/product/product10.jpg", "BLIZZARDOR#2255" },
                    { 11, "http://localhost:5112/static/product/product11.jpg", "ICEBURST#6677" },
                    { 12, "http://localhost:5112/static/product/product12.jpg", "SNOWSHINE#8834" },
                    { 13, "http://localhost:5112/static/product/product13.jpg", "FROSTFLY#4419" },
                    { 14, "http://localhost:5112/static/product/product14.jpg", "GLACIATOR#1182" },
                    { 15, "http://localhost:5112/static/product/product15.jpg", "MOUNTAINEER#9966" },
                    { 16, "http://localhost:5112/static/product/product16.jpg", "SLEDGEMAN#6644" },
                    { 17, "http://localhost:5112/static/product/product17.jpg", "CHILLBLAST#3322" },
                    { 18, "http://localhost:5112/static/product/product18.jpg", "ICEBREAKER#5544" },
                    { 19, "http://localhost:5112/static/product/product19.jpg", "SNOWTREK#4466" },
                    { 20, "http://localhost:5112/static/product/product20.jpg", "FROSTYFIRE#7788" },
                    { 21, "http://localhost:5112/static/product/product21.jpg", "GLACIERBOLT#1122" },
                    { 22, "http://localhost:5112/static/product/product22.jpg", "ICYCLE#5533" },
                    { 23, "http://localhost:5112/static/product/product23.jpg", "SNOWDRIFT#2277" },
                    { 24, "http://localhost:5112/static/product/product24.jpg", "CHILLYBLAZE#9966" },
                    { 25, "http://localhost:5112/static/product/product25.jpg", "FROSTBITE#3344" }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "Image", "Language", "Name", "Position" },
                values: new object[,]
                {
                    { 1, "http://localhost:5112/static/team/team-1.jpg", "EN", "Ralph Edwards", "Founder" },
                    { 2, "http://localhost:5112/static/team/team-2.jpg", "EN", "Jason Smith", "Co - Founder" },
                    { 3, "http://localhost:5112/static/team/team-3.jpg", "EN", "Tony Wings", "Web Designer" },
                    { 4, "http://localhost:5112/static/team/team-4.jpg", "EN", "Esther Howard", "Project Manager" },
                    { 5, "http://localhost:5112/static/team/team-5.jpg", "EN", "Jenny Wilson", "Artist" },
                    { 6, "http://localhost:5112/static/team/team-6.jpg", "EN", "Robert Fox", "UI/UX Designer" },
                    { 7, "http://localhost:5112/static/team/team-7.jpg", "EN", "Devon Lane", "UX Architect" },
                    { 8, "http://localhost:5112/static/team/team-1.jpg", "RU", "Ральф Эдвардс", "Основатель" },
                    { 9, "http://localhost:5112/static/team/team-2.jpg", "RU", "Джейсон Смит", "Сооснователь" },
                    { 10, "http://localhost:5112/static/team/team-3.jpg", "RU", "Тони Уингс", "Веб-дизайнер" },
                    { 11, "http://localhost:5112/static/team/team-4.jpg", "RU", "Эстер Ховард", "Менеджер проекта" },
                    { 12, "http://localhost:5112/static/team/team-5.jpg", "RU", "Дженни Уилсон", "Художник" },
                    { 13, "http://localhost:5112/static/team/team-6.jpg", "RU", "Роберт Фокс", "Дизайнер интерфейса / пользовательских интерфейсов" },
                    { 14, "http://localhost:5112/static/team/team-7.jpg", "RU", "Девон Лейн", "Архитектор пользовательских интерфейсов" }
                });

            migrationBuilder.InsertData(
                table: "Works",
                columns: new[] { "Id", "Image", "Language", "Text", "Title" },
                values: new object[,]
                {
                    { 1, "http://localhost:5112/static/svg/work-1.svg", "EN", "Connect your wallet to start working with our platform.", "CONNECT THE WALLET" },
                    { 2, "http://localhost:5112/static/svg/work-2.svg", "EN", "Choose the quality and type of NFT you want to create or purchase.", "SELECT THE QUALITY" },
                    { 3, "http://localhost:5112/static/svg/work-3.svg", "EN", "Confirm the transaction in your wallet to complete the process.", "CONFIRM TRANSACTION" },
                    { 4, "http://localhost:5112/static/svg/work-4.svg", "EN", "Receive your NFTs and enjoy them in your digital collection space.", "RECEIVE YOUR NFTS" },
                    { 5, "http://localhost:5112/static/svg/work-1.svg", "RU", "Подключите свой кошелек, чтобы начать работать с нашей платформой.", "ПОДКЛЮЧИТЕ КОШЕЛЕК" },
                    { 6, "http://localhost:5112/static/svg/work-2.svg", "RU", "Выберите качество и тип NFT, который вы хотите создать или приобрести.", "ВЫБЕРИТЕ КАЧЕСТВО" },
                    { 7, "http://localhost:5112/static/svg/work-3.svg", "RU", "Подтвердите транзакцию в вашем кошельке для завершения процесса.", "ПОДТВЕРДИТЕ ТРАНЗАКЦИЮ" },
                    { 8, "http://localhost:5112/static/svg/work-4.svg", "RU", "Получите ваши NFT и наслаждайтесь ими в вашем цифровом коллекционном пространстве.", "ПОЛУЧИТЕ ВАШИ NFT" }
                });

            migrationBuilder.InsertData(
                table: "AboutCounters",
                columns: new[] { "Id", "AboutId", "Language", "Number", "Title" },
                values: new object[,]
                {
                    { 1, 1, "EN", 25, "Total Items" },
                    { 2, 1, "EN", 1000, "Profiles Whitelisted" },
                    { 3, 2, "RU", 25, "Количество предметов" },
                    { 4, 2, "RU", 1000, "Пользователей зарегистрировано" }
                });

            migrationBuilder.InsertData(
                table: "AboutStats",
                columns: new[] { "Id", "AboutId", "Language", "Text", "Title" },
                values: new object[,]
                {
                    { 1, 1, "EN", "The products or services offered are crafted using advanced technologies and undergo rigorous quality control.", "HIGH QUALITY" },
                    { 2, 1, "EN", "We offer a wide range of products or services to meet the needs of even the most discerning customers.", "LARGE COLLECTION" },
                    { 3, 1, "EN", "We provide access to cutting-edge resources to help you achieve success and prosperity in your business or project.", "TOP RESOURCES" },
                    { 4, 1, "EN", "Join our extensive community where you'll find support, advice, and opportunities for growth and knowledge exchange.", "BIG COMMUNITY" },
                    { 5, 2, "RU", "Предлагаемые продукты или услуги изготавливаются с использованием передовых технологий и проходят строгий контроль качества.", "ВЫСОКОЕ КАЧЕСТВО" },
                    { 6, 2, "RU", "Мы предлагаем широкий выбор продуктов или услуг, чтобы удовлетворить потребности самых требовательных клиентов.", "БОЛЬШАЯ КОЛЛЕКЦИЯ" },
                    { 7, 2, "RU", "Мы предоставляем доступ к передовым ресурсам, которые помогут вам достичь успеха и процветания в вашем бизнесе или проекте.", "ТОПОВЫЕ РЕСУРСЫ" },
                    { 8, 2, "RU", "Присоединяйтесь к нашему обширному сообществу, где вы найдете поддержку, советы и возможности для роста и обмена опытом.", "БОЛЬШОЕ СООБЩЕСТВО" }
                });

            migrationBuilder.InsertData(
                table: "ItemDetails",
                columns: new[] { "Id", "Description", "ItemId", "Price" },
                values: new object[,]
                {
                    { 1, "Discover a collection of unique skins drawn from heroic missions and challenges. Each skin tells a story of bravery and triumph. Equip SKISIRS#4587 and embark on your own legendary journey.", 1, 15m },
                    { 2, "Embrace the frost with this cool and stylish collection. FROSTIC#4571 offers both protection and style in the harshest of conditions. Equip it and conquer the icy realms with confidence.", 2, 20m },
                    { 3, "Gear up like a brave mountaineer with MOUNTIANO#8992. Crafted for adventurers, this gear ensures comfort and durability in extreme terrains. Embark on your next expedition with confidence.", 3, 25m },
                    { 4, "Conquer the snow with style with SNOWBLIZZ#3315. This sleek and versatile gear offers both warmth and mobility, perfect for high-speed descents or leisurely treks. Elevate your winter experience today.", 4, 18m },
                    { 5, "Experience the thrill of arctic adventure with GLACIERIS#2453. Designed for explorers, this gear offers superior protection against the elements while allowing freedom of movement. Prepare for an unforgettable journey.", 5, 30m },
                    { 6, "Embark on a frozen journey with ICETREK#7793. This gear is engineered for both performance and style, ensuring you stay warm and agile in snowy landscapes. Equip it and embrace the chill.", 6, 22m },
                    { 7, "Fly through the powdery snow with POWDERFLY#6621. This sleek and aerodynamic gear enhances your speed and agility on the slopes. Dominate the snowscape with confidence.", 7, 28m },
                    { 8, "Experience an avalanche of excitement with AVALANCHEER#1076. This gear offers unmatched protection against avalanches and extreme weather conditions. Equip it and conquer the mountains with confidence.", 8, 35m },
                    { 9, "Sledding just got sleeker with SLEDDOR#5538. Crafted for speed and durability, this gear ensures thrilling descents down snowy hills. Get ready for the ultimate sledding adventure.", 9, 40m },
                    { 10, "Stay warm and stylish with BLIZZARDOR#2255. This gear offers superior insulation against cold temperatures while maintaining a sleek and modern design. Elevate your winter wardrobe today.", 10, 45m },
                    { 11, "Break the ice in style with ICEBURST#6677. Designed for both performance and aesthetics, this gear ensures you stand out on the slopes while staying warm and agile. Dominate the snowscape with confidence.", 11, 30m },
                    { 12, "Shine through the snow with SNOWSHINE#8834. Crafted for style and functionality, this gear offers superior protection against cold temperatures while exuding elegance on the slopes. Elevate your winter style today.", 12, 25m },
                    { 13, "Fly high in frosty skies with FROSTFLY#4419. This sleek and aerodynamic gear enhances your performance in snowy landscapes, allowing you to soar above the competition. Prepare for an exhilarating flight.", 13, 32m },
                    { 14, "Chill with glacier style with GLACIATOR#1182. Crafted for both performance and aesthetics, this gear ensures you stay warm and stylish on the slopes. Dominate the snowscape with confidence.", 14, 38m },
                    { 15, "Master the mountains with MOUNTAINEER#9966. This gear offers superior protection and performance in extreme terrains, ensuring you conquer any challenge with confidence. Embark on your next expedition today.", 15, 42m },
                    { 16, "Sled like a pro with SLEDGEMAN#6644. Crafted for speed and agility, this gear ensures thrilling descents down snowy hills while maintaining control and stability. Get ready for an adrenaline-packed ride.", 16, 48m },
                    { 17, "Blast through the chill with CHILLBLAST#3322. This sleek and aerodynamic gear enhances your speed and agility on the slopes, ensuring you stay ahead of the competition. Dominate the snowscape with confidence.", 17, 20m },
                    { 18, "Break the ice with power with ICEBREAKER#5544. Crafted for both strength and style, this gear ensures you stand out on the slopes while maintaining control and stability. Dominate the snowscape with confidence.", 18, 25m },
                    { 19, "Trek through snowy landscapes with SNOWTREK#4466. Designed for adventurers, this gear offers superior traction and stability on icy terrains, ensuring you explore with confidence. Embark on your next journey today.", 19, 30m },
                    { 20, "Fire up the frost with FROSTYFIRE#7788. This sleek and stylish gear offers superior insulation against cold temperatures while exuding elegance on the slopes. Elevate your winter wardrobe today.", 20, 22m },
                    { 21, "Bolt through glaciers with GLACIERBOLT#1122. Crafted for speed and agility, this gear ensures thrilling descents down snowy slopes while maintaining control and stability. Get ready for an electrifying ride.", 21, 28m },
                    { 22, "Cool cycling adventure awaits with ICYCLE#5533. This sleek and aerodynamic gear enhances your performance on icy roads, ensuring you navigate with speed and precision. Embark on your next cycling journey with confidence.", 22, 35m },
                    { 23, "Drift through snowy paths with SNOWDRIFT#2277. Crafted for both style and functionality, this gear ensures you stand out on the slopes while maintaining control and stability. Dominate the snowscape with confidence.", 23, 40m },
                    { 24, "Blaze chilly trails with CHILLYBLAZE#9966. This sleek and aerodynamic gear enhances your speed and agility on icy terrains, ensuring you stay ahead of the competition. Dominate the snowscape with confidence.", 24, 45m },
                    { 25, "Feel the frostbite with FROSTBITE#3344. Crafted for both warmth and style, this gear ensures you stay comfortable and chic on the slopes. Elevate your winter wardrobe with this sleek and versatile option.", 25, 50m }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Avatar", "Name", "ReviewInfoId", "Text" },
                values: new object[,]
                {
                    { 1, "http://localhost:5112/static/author/avt1.jpg", "John Smith", 1, "Great experience working with this team. Professional and efficient!" },
                    { 2, "http://localhost:5112/static/author/avt2.jpg", "Emily Johnson", 1, "Excellent service! I'm impressed with the attention to detail and quick turnaround." },
                    { 3, "http://localhost:5112/static/author/avt3.jpg", "Michael Brown", 1, "Highly recommend! The team went above and beyond to meet our needs." },
                    { 4, "http://localhost:5112/static/author/avt4.jpg", "Sarah Williams", 1, "Outstanding work! Very pleased with the results and level of professionalism." },
                    { 5, "http://localhost:5112/static/author/avt5.jpg", "Jessica Miller", 1, "Thank you for the exceptional service! Will definitely work with you again in the future." },
                    { 6, "http://localhost:5112/static/author/avt6.jpg", "David Wilson", 1, "Amazing team! They delivered exactly what we needed on time and within budget." },
                    { 7, "http://localhost:5112/static/author/avt1.jpg", "Алексей Петров", 2, "Быстрое и профессиональное обслуживание. Очень доволен результатом!" },
                    { 8, "http://localhost:5112/static/author/avt2.jpg", "Марина Иванова", 2, "Отличный опыт работы с этой компанией. Профессиональный подход и высокое качество услуг." },
                    { 9, "http://localhost:5112/static/author/avt3.jpg", "Дмитрий Смирнов", 2, "Получил большое удовольствие от сотрудничества. Все было сделано быстро и качественно." },
                    { 10, "http://localhost:5112/static/author/avt4.jpg", "Елена Козлова", 2, "Очень рекомендую эту компанию. Профессиональный персонал и оперативное выполнение заказов." },
                    { 11, "http://localhost:5112/static/author/avt5.jpg", "Иван Федоров", 2, "Благодарю за отличный сервис! Результат превзошел мои ожидания." },
                    { 12, "http://localhost:5112/static/author/avt6.jpg", "Ольга Соколова", 2, "Это лучшая компания, с которой я когда-либо работал. Профессиональный и дружелюбный персонал." }
                });

            migrationBuilder.InsertData(
                table: "RoadMapBenefits",
                columns: new[] { "Id", "RoadMapId", "Text" },
                values: new object[,]
                {
                    { 1, 1, "Befriending & Chat Functions" },
                    { 2, 1, "Challenging Feature" },
                    { 3, 1, "Corsair Wheel" },
                    { 4, 1, "Mobile Version Launch" },
                    { 5, 2, "Befriending & Chat Functions" },
                    { 6, 2, "Challenging Feature" },
                    { 7, 2, "Corsair Wheel" },
                    { 8, 2, "Mobile Version Launch" },
                    { 9, 3, "Befriending & Chat Functions" },
                    { 10, 3, "Challenging Feature" },
                    { 11, 3, "Corsair Wheel" },
                    { 12, 3, "Mobile Version Launch" },
                    { 13, 4, "Befriending & Chat Functions" },
                    { 14, 4, "Challenging Feature" },
                    { 15, 4, "Corsair Wheel" },
                    { 16, 4, "Mobile Version Launch" },
                    { 17, 5, "Befriending & Chat Functions" },
                    { 18, 5, "Challenging Feature" },
                    { 19, 5, "Corsair Wheel" },
                    { 20, 5, "Mobile Version Launch" },
                    { 21, 6, "Befriending & Chat Functions" },
                    { 22, 6, "Challenging Feature" },
                    { 23, 6, "Corsair Wheel" },
                    { 24, 6, "Mobile Version Launch" },
                    { 25, 7, "Функции Дружбы и Чата" },
                    { 26, 7, "Интересная Особенность" },
                    { 27, 7, "Колесо Корсара" },
                    { 28, 7, "Запуск Мобильной Версии" },
                    { 29, 8, "Функции Дружбы и Чата" },
                    { 30, 8, "Интересная Особенность" },
                    { 31, 8, "Колесо Корсара" },
                    { 32, 8, "Запуск Мобильной Версии" },
                    { 33, 9, "Функции Дружбы и Чата" },
                    { 34, 9, "Интересная Особенность" },
                    { 35, 9, "Колесо Корсара" },
                    { 36, 9, "Запуск Мобильной Версии" },
                    { 37, 10, "Функции Дружбы и Чата" },
                    { 38, 10, "Интересная Особенность" },
                    { 39, 10, "Колесо Корсара" },
                    { 40, 10, "Запуск Мобильной Версии" },
                    { 41, 11, "Функции Дружбы и Чата" },
                    { 42, 11, "Интересная Особенность" },
                    { 43, 11, "Колесо Корсара" },
                    { 44, 11, "Запуск Мобильной Версии" },
                    { 45, 12, "Функции Дружбы и Чата" },
                    { 46, 12, "Интересная Особенность" },
                    { 47, 12, "Колесо Корсара" },
                    { 48, 12, "Запуск Мобильной Версии" }
                });

            migrationBuilder.InsertData(
                table: "Subscriptions",
                columns: new[] { "Id", "Image", "Language", "PaymentId", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "http://localhost:5112/static/icon/subscribtions/free.png", "EN", 1, 0m, "FREE" },
                    { 2, "http://localhost:5112/static/icon/subscribtions/vip.png", "EN", 1, 10m, "VIP" },
                    { 3, "http://localhost:5112/static/icon/subscribtions/premium.png", "EN", 1, 20m, "PREMIUM" },
                    { 4, "http://localhost:5112/static/icon/subscribtions/free.png", "RU", 2, 0m, "FREE" },
                    { 5, "http://localhost:5112/static/icon/subscribtions/vip.png", "RU", 2, 10m, "VIP" },
                    { 6, "http://localhost:5112/static/icon/subscribtions/premium.png", "RU", 2, 20m, "PREMIUM" }
                });

            migrationBuilder.InsertData(
                table: "ItemCategories",
                columns: new[] { "Id", "Info", "ItemDetailId", "Name" },
                values: new object[,]
                {
                    { 1, "SNAKE", 1, "CLOTHING" },
                    { 2, "MIX", 1, "EYES" },
                    { 3, "GREEN", 1, "FACE" },
                    { 4, "GREEN", 1, "SKIN" },
                    { 5, "GREEN LIGHT", 1, "BACKGROUND" },
                    { 6, "CAT", 1, "SPECIAL" },
                    { 7, "SNOWFLAKE", 2, "CLOTHING" },
                    { 8, "BLUE", 2, "EYES" },
                    { 9, "WHITE", 2, "FACE" },
                    { 10, "PALE", 2, "SKIN" },
                    { 11, "SNOWY", 2, "BACKGROUND" },
                    { 12, "ARCTIC FOX", 2, "SPECIAL" },
                    { 13, "MOUNTAINEER", 3, "CLOTHING" },
                    { 14, "BROWN", 3, "EYES" },
                    { 15, "TAN", 3, "FACE" },
                    { 16, "SUNBURNED", 3, "SKIN" },
                    { 17, "MOUNTAINOUS", 3, "BACKGROUND" },
                    { 18, "EAGLE", 3, "SPECIAL" },
                    { 19, "SNOW SUIT", 4, "CLOTHING" },
                    { 20, "GREEN", 4, "EYES" },
                    { 21, "FROSTED", 4, "FACE" },
                    { 22, "PALE", 4, "SKIN" },
                    { 23, "ARCTIC", 4, "BACKGROUND" },
                    { 24, "POLAR BEAR", 4, "SPECIAL" },
                    { 25, "GLACIER SUIT", 5, "CLOTHING" },
                    { 26, "CRYSTAL BLUE", 5, "EYES" },
                    { 27, "FROSTBITTEN", 5, "FACE" },
                    { 28, "FROSTED", 5, "SKIN" },
                    { 29, "GLACIER", 5, "BACKGROUND" },
                    { 30, "YETI", 5, "SPECIAL" },
                    { 31, "ICE SUIT", 6, "CLOTHING" },
                    { 32, "CRYSTAL", 6, "EYES" },
                    { 33, "FROSTED", 6, "FACE" },
                    { 34, "WHITE", 6, "SKIN" },
                    { 35, "ICY", 6, "BACKGROUND" },
                    { 36, "ICE DRAGON", 6, "SPECIAL" },
                    { 37, "POWDER JACKET", 7, "CLOTHING" },
                    { 38, "POWDER BLUE", 7, "EYES" },
                    { 39, "FROSTBITTEN", 7, "FACE" },
                    { 40, "PALE", 7, "SKIN" },
                    { 41, "POWDERY", 7, "BACKGROUND" },
                    { 42, "POWDER PANDA", 7, "SPECIAL" },
                    { 43, "AVALANCHE SUIT", 8, "CLOTHING" },
                    { 44, "SNOWFLAKE", 8, "EYES" },
                    { 45, "FROSTY", 8, "FACE" },
                    { 46, "FROSTED", 8, "SKIN" },
                    { 47, "AVALANCHE", 8, "BACKGROUND" },
                    { 48, "ABOMINABLE SNOWMAN", 8, "SPECIAL" },
                    { 49, "SLEDDING SUIT", 9, "CLOTHING" },
                    { 50, "WINTER BLUE", 9, "EYES" },
                    { 51, "FROSTBITE", 9, "FACE" },
                    { 52, "WHITE", 9, "SKIN" },
                    { 53, "SNOWY", 9, "BACKGROUND" },
                    { 54, "SNOWY OWL", 9, "SPECIAL" },
                    { 55, "BLIZZARD PARKA", 10, "CLOTHING" },
                    { 56, "FROST GAZE", 10, "EYES" },
                    { 57, "CHILLED", 10, "FACE" },
                    { 58, "FROZEN", 10, "SKIN" },
                    { 59, "BLIZZARD", 10, "BACKGROUND" },
                    { 60, "BLIZZARD BEAR", 10, "SPECIAL" },
                    { 61, "ICEBREAKER SUIT", 11, "CLOTHING" },
                    { 62, "FROST EYES", 11, "EYES" },
                    { 63, "ICE COLD", 11, "FACE" },
                    { 64, "FROSTY", 11, "SKIN" },
                    { 65, "ICE CAVE", 11, "BACKGROUND" },
                    { 66, "ICE WOLF", 11, "SPECIAL" },
                    { 67, "GLACIER SUIT", 12, "CLOTHING" },
                    { 68, "GLACIAL GAZE", 12, "EYES" },
                    { 69, "GLACIAL", 12, "FACE" },
                    { 70, "FROZEN", 12, "SKIN" },
                    { 71, "GLACIER", 12, "BACKGROUND" },
                    { 72, "GLACIER FOX", 12, "SPECIAL" },
                    { 73, "ARCTIC JACKET", 13, "CLOTHING" },
                    { 74, "ARCTIC GAZE", 13, "EYES" },
                    { 75, "ARCTIC CHILL", 13, "FACE" },
                    { 76, "FROSTY", 13, "SKIN" },
                    { 77, "ARCTIC EXPEDITION", 13, "BACKGROUND" },
                    { 78, "ARCTIC WOLF", 13, "SPECIAL" },
                    { 79, "SNOWSTORM SUIT", 14, "CLOTHING" },
                    { 80, "FROSTED GAZE", 14, "EYES" },
                    { 81, "CHILLED", 14, "FACE" },
                    { 82, "FROZEN", 14, "SKIN" },
                    { 83, "SNOWSTORM", 14, "BACKGROUND" },
                    { 84, "SNOW LEOPARD", 14, "SPECIAL" },
                    { 85, "MOUNTAINEER SUIT", 15, "CLOTHING" },
                    { 86, "MOUNTAIN GAZE", 15, "EYES" },
                    { 87, "MOUNTAINOUS", 15, "FACE" },
                    { 88, "TANNED", 15, "SKIN" },
                    { 89, "MOUNTAINTOP", 15, "BACKGROUND" },
                    { 90, "MOUNTAIN LION", 15, "SPECIAL" },
                    { 91, "SNOW SLED SUIT", 16, "CLOTHING" },
                    { 92, "WINTER GAZE", 16, "EYES" },
                    { 93, "SNOWY", 16, "FACE" },
                    { 94, "PALE", 16, "SKIN" },
                    { 95, "FROSTED", 16, "BACKGROUND" },
                    { 96, "SNOW LEOPARD", 16, "SPECIAL" },
                    { 97, "FROST SUIT", 17, "CLOTHING" },
                    { 98, "FROST GAZE", 17, "EYES" },
                    { 99, "CHILL", 17, "FACE" },
                    { 100, "FROZEN", 17, "SKIN" },
                    { 101, "FROSTED", 17, "BACKGROUND" },
                    { 102, "FROST BEAR", 17, "SPECIAL" },
                    { 103, "ICE JACKET", 18, "CLOTHING" },
                    { 104, "ARCTIC GAZE", 18, "EYES" },
                    { 105, "CHILLED", 18, "FACE" },
                    { 106, "FROSTY", 18, "SKIN" },
                    { 107, "ICE CAVE", 18, "BACKGROUND" },
                    { 108, "ICE BEAR", 18, "SPECIAL" },
                    { 109, "SNOW TREKKING SUIT", 19, "CLOTHING" },
                    { 110, "ICE GAZE", 19, "EYES" },
                    { 111, "FROSTBITE", 19, "FACE" },
                    { 112, "FROZEN", 19, "SKIN" },
                    { 113, "SNOWY", 19, "BACKGROUND" },
                    { 114, "SNOWY OWL", 19, "SPECIAL" },
                    { 115, "FROSTBITE PARKA", 20, "CLOTHING" },
                    { 116, "CHILLED GAZE", 20, "EYES" },
                    { 117, "SNOWY", 20, "FACE" },
                    { 118, "PALE", 20, "SKIN" },
                    { 119, "FROSTED", 20, "BACKGROUND" },
                    { 120, "FROST WOLF", 20, "SPECIAL" },
                    { 121, "ICE EXPLORER SUIT", 21, "CLOTHING" },
                    { 122, "ARCTIC GAZE", 21, "EYES" },
                    { 123, "CHILLED", 21, "FACE" },
                    { 124, "FROZEN", 21, "SKIN" },
                    { 125, "ICE CAVE", 21, "BACKGROUND" },
                    { 126, "ICE BEAR", 21, "SPECIAL" },
                    { 127, "BLIZZARD SUIT", 22, "CLOTHING" },
                    { 128, "FROSTED GAZE", 22, "EYES" },
                    { 129, "CHILLED", 22, "FACE" },
                    { 130, "FROZEN", 22, "SKIN" },
                    { 131, "BLIZZARD", 22, "BACKGROUND" },
                    { 132, "BLIZZARD WOLF", 22, "SPECIAL" },
                    { 133, "SNOW TROOPER SUIT", 23, "CLOTHING" },
                    { 134, "FROSTBITE GAZE", 23, "EYES" },
                    { 135, "SNOWY", 23, "FACE" },
                    { 136, "PALE", 23, "SKIN" },
                    { 137, "FROSTED", 23, "BACKGROUND" },
                    { 138, "FROST TIGER", 23, "SPECIAL" },
                    { 139, "ARCTIC WARRIOR SUIT", 24, "CLOTHING" },
                    { 140, "FROST GAZE", 24, "EYES" },
                    { 141, "CHILL", 24, "FACE" },
                    { 142, "FROSTED", 24, "SKIN" },
                    { 143, "ARCTIC", 24, "BACKGROUND" },
                    { 144, "ARCTIC BEAR", 24, "SPECIAL" },
                    { 145, "GLACIAL COMMANDER SUIT", 25, "CLOTHING" },
                    { 146, "FROST COMMAND", 25, "EYES" },
                    { 147, "CHILLED", 25, "FACE" },
                    { 148, "FROZEN", 25, "SKIN" },
                    { 149, "GLACIER", 25, "BACKGROUND" },
                    { 150, "GLACIAL BEAR", 25, "SPECIAL" }
                });

            migrationBuilder.InsertData(
                table: "SubscriptionProperties",
                columns: new[] { "Id", "SubscriptionId", "Text" },
                values: new object[,]
                {
                    { 1, 1, "Ability to leave comments on posts" },
                    { 2, 1, "Ability to leave reviews on the website" },
                    { 3, 1, "Ability to purchase items" },
                    { 4, 2, "Ability to leave comments on posts" },
                    { 5, 2, "Ability to leave reviews on the website" },
                    { 6, 2, "Ability to purchase items" },
                    { 7, 2, "Ability to sell items (up to 5 items at a time)" },
                    { 8, 2, "Commission for selling each item - 30%" },
                    { 9, 3, "Ability to leave comments on posts" },
                    { 10, 3, "Ability to leave reviews on the website" },
                    { 11, 3, "Ability to purchase items" },
                    { 12, 3, "Ability to sell items (up to 10 items at a time)" },
                    { 13, 3, "Commission for selling each item - 15%" },
                    { 14, 4, "Возможность оставлять комментарии к постам" },
                    { 15, 4, "Возможность оставлять отзывы на сайте" },
                    { 16, 4, "Возможность покупки предметов" },
                    { 17, 5, "Возможность оставлять комментарии к постам" },
                    { 18, 5, "Возможность оставлять отзывы на сайте" },
                    { 19, 5, "Возможность покупки предметов" },
                    { 20, 5, "Возможность продажи предметов (не более 5шт. за раз)" },
                    { 21, 5, "Комиссия за продажу каждого предмета - 30%" },
                    { 22, 6, "Возможность оставлять комментарии к постам" },
                    { 23, 6, "Возможность оставлять отзывы на сайте" },
                    { 24, 6, "Возможность покупки предметов" },
                    { 25, 6, "Возможность продажи предметов (не более 10шт. за раз)" },
                    { 26, 6, "Комиссия за продажу каждого предмета - 15%" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AboutCounters_AboutId",
                table: "AboutCounters",
                column: "AboutId");

            migrationBuilder.CreateIndex(
                name: "IX_AboutStats_AboutId",
                table: "AboutStats",
                column: "AboutId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ItemCategories_ItemDetailId",
                table: "ItemCategories",
                column: "ItemDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemDetails_ItemId",
                table: "ItemDetails",
                column: "ItemId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ReviewInfoId",
                table: "Reviews",
                column: "ReviewInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_RoadMapBenefits_RoadMapId",
                table: "RoadMapBenefits",
                column: "RoadMapId");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionProperties_SubscriptionId",
                table: "SubscriptionProperties",
                column: "SubscriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptions_PaymentId",
                table: "Subscriptions",
                column: "PaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_UserId",
                table: "Transactions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserInfos_UserId",
                table: "UserInfos",
                column: "UserId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutCounters");

            migrationBuilder.DropTable(
                name: "AboutStats");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Avatars");

            migrationBuilder.DropTable(
                name: "Banners");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Faqs");

            migrationBuilder.DropTable(
                name: "ItemCategories");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "RoadMapBenefits");

            migrationBuilder.DropTable(
                name: "SubscriptionProperties");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "UserFeedbacks");

            migrationBuilder.DropTable(
                name: "UserInfos");

            migrationBuilder.DropTable(
                name: "Works");

            migrationBuilder.DropTable(
                name: "Abouts");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "ItemDetails");

            migrationBuilder.DropTable(
                name: "ReviewInfos");

            migrationBuilder.DropTable(
                name: "RoadMaps");

            migrationBuilder.DropTable(
                name: "Subscriptions");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "ShopItems");

            migrationBuilder.DropTable(
                name: "Payments");
        }
    }
}
