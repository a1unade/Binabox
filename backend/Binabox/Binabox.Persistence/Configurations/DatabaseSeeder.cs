using Binabox.Domain.Entities;

namespace Binabox.Persistence.Configurations;

public abstract class DatabaseSeeder
{
    public static IReadOnlyCollection<Avatar> Avatars() =>
    [
        new Avatar { Id = 1, Name = "users-1.svg", Url = "http://localhost:5112/static/avatars/users-1.svg" },
        new Avatar { Id = 2, Name = "users-2.svg", Url = "http://localhost:5112/static/avatars/users-2.svg" },
        new Avatar { Id = 3, Name = "users-3.svg", Url = "http://localhost:5112/static/avatars/users-3.svg" },
        new Avatar { Id = 4, Name = "users-4.svg", Url = "http://localhost:5112/static/avatars/users-4.svg" },
        new Avatar { Id = 5, Name = "users-5.svg", Url = "http://localhost:5112/static/avatars/users-5.svg" },
        new Avatar { Id = 6, Name = "users-6.svg", Url = "http://localhost:5112/static/avatars/users-6.svg" },
        new Avatar { Id = 7, Name = "users-7.svg", Url = "http://localhost:5112/static/avatars/users-7.svg" },
        new Avatar { Id = 8, Name = "users-8.svg", Url = "http://localhost:5112/static/avatars/users-8.svg" },
        new Avatar { Id = 9, Name = "users-9.svg", Url = "http://localhost:5112/static/avatars/users-9.svg" }
    ];

    public static IReadOnlyCollection<ItemCategory> ItemCategories() =>
    [
        new ItemCategory { Id = 1, Name = "CLOTHING", Info = "SNAKE", ItemDetailId = 1 },
        new ItemCategory { Id = 2, Name = "EYES", Info = "MIX", ItemDetailId = 1 },
        new ItemCategory { Id = 3, Name = "FACE", Info = "GREEN", ItemDetailId = 1 },
        new ItemCategory { Id = 4, Name = "SKIN", Info = "GREEN", ItemDetailId = 1 },
        new ItemCategory { Id = 5, Name = "BACKGROUND", Info = "GREEN LIGHT", ItemDetailId = 1 },
        new ItemCategory { Id = 6, Name = "SPECIAL", Info = "CAT", ItemDetailId = 1 },

        new ItemCategory { Id = 7, Name = "CLOTHING", Info = "SNOWFLAKE", ItemDetailId = 2 },
        new ItemCategory { Id = 8, Name = "EYES", Info = "BLUE", ItemDetailId = 2 },
        new ItemCategory { Id = 9, Name = "FACE", Info = "WHITE", ItemDetailId = 2 },
        new ItemCategory { Id = 10, Name = "SKIN", Info = "PALE", ItemDetailId = 2 },
        new ItemCategory { Id = 11, Name = "BACKGROUND", Info = "SNOWY", ItemDetailId = 2 },
        new ItemCategory { Id = 12, Name = "SPECIAL", Info = "ARCTIC FOX", ItemDetailId = 2 },

        new ItemCategory { Id = 13, Name = "CLOTHING", Info = "MOUNTAINEER", ItemDetailId = 3 },
        new ItemCategory { Id = 14, Name = "EYES", Info = "BROWN", ItemDetailId = 3 },
        new ItemCategory { Id = 15, Name = "FACE", Info = "TAN", ItemDetailId = 3 },
        new ItemCategory { Id = 16, Name = "SKIN", Info = "SUNBURNED", ItemDetailId = 3 },
        new ItemCategory { Id = 17, Name = "BACKGROUND", Info = "MOUNTAINOUS", ItemDetailId = 3 },
        new ItemCategory { Id = 18, Name = "SPECIAL", Info = "EAGLE", ItemDetailId = 3 },

        new ItemCategory { Id = 19, Name = "CLOTHING", Info = "SNOW SUIT", ItemDetailId = 4 },
        new ItemCategory { Id = 20, Name = "EYES", Info = "GREEN", ItemDetailId = 4 },
        new ItemCategory { Id = 21, Name = "FACE", Info = "FROSTED", ItemDetailId = 4 },
        new ItemCategory { Id = 22, Name = "SKIN", Info = "PALE", ItemDetailId = 4 },
        new ItemCategory { Id = 23, Name = "BACKGROUND", Info = "ARCTIC", ItemDetailId = 4 },
        new ItemCategory { Id = 24, Name = "SPECIAL", Info = "POLAR BEAR", ItemDetailId = 4 },

        new ItemCategory { Id = 25, Name = "CLOTHING", Info = "GLACIER SUIT", ItemDetailId = 5 },
        new ItemCategory { Id = 26, Name = "EYES", Info = "CRYSTAL BLUE", ItemDetailId = 5 },
        new ItemCategory { Id = 27, Name = "FACE", Info = "FROSTBITTEN", ItemDetailId = 5 },
        new ItemCategory { Id = 28, Name = "SKIN", Info = "FROSTED", ItemDetailId = 5 },
        new ItemCategory { Id = 29, Name = "BACKGROUND", Info = "GLACIER", ItemDetailId = 5 },
        new ItemCategory { Id = 30, Name = "SPECIAL", Info = "YETI", ItemDetailId = 5 },

        new ItemCategory { Id = 31, Name = "CLOTHING", Info = "ICE SUIT", ItemDetailId = 6 },
        new ItemCategory { Id = 32, Name = "EYES", Info = "CRYSTAL", ItemDetailId = 6 },
        new ItemCategory { Id = 33, Name = "FACE", Info = "FROSTED", ItemDetailId = 6 },
        new ItemCategory { Id = 34, Name = "SKIN", Info = "WHITE", ItemDetailId = 6 },
        new ItemCategory { Id = 35, Name = "BACKGROUND", Info = "ICY", ItemDetailId = 6 },
        new ItemCategory { Id = 36, Name = "SPECIAL", Info = "ICE DRAGON", ItemDetailId = 6 },

        new ItemCategory { Id = 37, Name = "CLOTHING", Info = "POWDER JACKET", ItemDetailId = 7 },
        new ItemCategory { Id = 38, Name = "EYES", Info = "POWDER BLUE", ItemDetailId = 7 },
        new ItemCategory { Id = 39, Name = "FACE", Info = "FROSTBITTEN", ItemDetailId = 7 },
        new ItemCategory { Id = 40, Name = "SKIN", Info = "PALE", ItemDetailId = 7 },
        new ItemCategory { Id = 41, Name = "BACKGROUND", Info = "POWDERY", ItemDetailId = 7 },
        new ItemCategory { Id = 42, Name = "SPECIAL", Info = "POWDER PANDA", ItemDetailId = 7 },

        new ItemCategory { Id = 43, Name = "CLOTHING", Info = "AVALANCHE SUIT", ItemDetailId = 8 },
        new ItemCategory { Id = 44, Name = "EYES", Info = "SNOWFLAKE", ItemDetailId = 8 },
        new ItemCategory { Id = 45, Name = "FACE", Info = "FROSTY", ItemDetailId = 8 },
        new ItemCategory { Id = 46, Name = "SKIN", Info = "FROSTED", ItemDetailId = 8 },
        new ItemCategory { Id = 47, Name = "BACKGROUND", Info = "AVALANCHE", ItemDetailId = 8 },
        new ItemCategory { Id = 48, Name = "SPECIAL", Info = "ABOMINABLE SNOWMAN", ItemDetailId = 8 },

        new ItemCategory { Id = 49, Name = "CLOTHING", Info = "SLEDDING SUIT", ItemDetailId = 9 },
        new ItemCategory { Id = 50, Name = "EYES", Info = "WINTER BLUE", ItemDetailId = 9 },
        new ItemCategory { Id = 51, Name = "FACE", Info = "FROSTBITE", ItemDetailId = 9 },
        new ItemCategory { Id = 52, Name = "SKIN", Info = "WHITE", ItemDetailId = 9 },
        new ItemCategory { Id = 53, Name = "BACKGROUND", Info = "SNOWY", ItemDetailId = 9 },
        new ItemCategory { Id = 54, Name = "SPECIAL", Info = "SNOWY OWL", ItemDetailId = 9 },

        new ItemCategory { Id = 55, Name = "CLOTHING", Info = "BLIZZARD PARKA", ItemDetailId = 10 },
        new ItemCategory { Id = 56, Name = "EYES", Info = "FROST GAZE", ItemDetailId = 10 },
        new ItemCategory { Id = 57, Name = "FACE", Info = "CHILLED", ItemDetailId = 10 },
        new ItemCategory { Id = 58, Name = "SKIN", Info = "FROZEN", ItemDetailId = 10 },
        new ItemCategory { Id = 59, Name = "BACKGROUND", Info = "BLIZZARD", ItemDetailId = 10 },
        new ItemCategory { Id = 60, Name = "SPECIAL", Info = "BLIZZARD BEAR", ItemDetailId = 10 },

        new ItemCategory { Id = 61, Name = "CLOTHING", Info = "ICEBREAKER SUIT", ItemDetailId = 11 },
        new ItemCategory { Id = 62, Name = "EYES", Info = "FROST EYES", ItemDetailId = 11 },
        new ItemCategory { Id = 63, Name = "FACE", Info = "ICE COLD", ItemDetailId = 11 },
        new ItemCategory { Id = 64, Name = "SKIN", Info = "FROSTY", ItemDetailId = 11 },
        new ItemCategory { Id = 65, Name = "BACKGROUND", Info = "ICE CAVE", ItemDetailId = 11 },
        new ItemCategory { Id = 66, Name = "SPECIAL", Info = "ICE WOLF", ItemDetailId = 11 },

        new ItemCategory { Id = 67, Name = "CLOTHING", Info = "GLACIER SUIT", ItemDetailId = 12 },
        new ItemCategory { Id = 68, Name = "EYES", Info = "GLACIAL GAZE", ItemDetailId = 12 },
        new ItemCategory { Id = 69, Name = "FACE", Info = "GLACIAL", ItemDetailId = 12 },
        new ItemCategory { Id = 70, Name = "SKIN", Info = "FROZEN", ItemDetailId = 12 },
        new ItemCategory { Id = 71, Name = "BACKGROUND", Info = "GLACIER", ItemDetailId = 12 },
        new ItemCategory { Id = 72, Name = "SPECIAL", Info = "GLACIER FOX", ItemDetailId = 12 },

        new ItemCategory { Id = 73, Name = "CLOTHING", Info = "ARCTIC JACKET", ItemDetailId = 13 },
        new ItemCategory { Id = 74, Name = "EYES", Info = "ARCTIC GAZE", ItemDetailId = 13 },
        new ItemCategory { Id = 75, Name = "FACE", Info = "ARCTIC CHILL", ItemDetailId = 13 },
        new ItemCategory { Id = 76, Name = "SKIN", Info = "FROSTY", ItemDetailId = 13 },
        new ItemCategory { Id = 77, Name = "BACKGROUND", Info = "ARCTIC EXPEDITION", ItemDetailId = 13 },
        new ItemCategory { Id = 78, Name = "SPECIAL", Info = "ARCTIC WOLF", ItemDetailId = 13 },

        new ItemCategory { Id = 79, Name = "CLOTHING", Info = "SNOWSTORM SUIT", ItemDetailId = 14 },
        new ItemCategory { Id = 80, Name = "EYES", Info = "FROSTED GAZE", ItemDetailId = 14 },
        new ItemCategory { Id = 81, Name = "FACE", Info = "CHILLED", ItemDetailId = 14 },
        new ItemCategory { Id = 82, Name = "SKIN", Info = "FROZEN", ItemDetailId = 14 },
        new ItemCategory { Id = 83, Name = "BACKGROUND", Info = "SNOWSTORM", ItemDetailId = 14 },
        new ItemCategory { Id = 84, Name = "SPECIAL", Info = "SNOW LEOPARD", ItemDetailId = 14 },

        new ItemCategory { Id = 85, Name = "CLOTHING", Info = "MOUNTAINEER SUIT", ItemDetailId = 15 },
        new ItemCategory { Id = 86, Name = "EYES", Info = "MOUNTAIN GAZE", ItemDetailId = 15 },
        new ItemCategory { Id = 87, Name = "FACE", Info = "MOUNTAINOUS", ItemDetailId = 15 },
        new ItemCategory { Id = 88, Name = "SKIN", Info = "TANNED", ItemDetailId = 15 },
        new ItemCategory { Id = 89, Name = "BACKGROUND", Info = "MOUNTAINTOP", ItemDetailId = 15 },
        new ItemCategory { Id = 90, Name = "SPECIAL", Info = "MOUNTAIN LION", ItemDetailId = 15 },

        new ItemCategory { Id = 91, Name = "CLOTHING", Info = "SNOW SLED SUIT", ItemDetailId = 16 },
        new ItemCategory { Id = 92, Name = "EYES", Info = "WINTER GAZE", ItemDetailId = 16 },
        new ItemCategory { Id = 93, Name = "FACE", Info = "SNOWY", ItemDetailId = 16 },
        new ItemCategory { Id = 94, Name = "SKIN", Info = "PALE", ItemDetailId = 16 },
        new ItemCategory { Id = 95, Name = "BACKGROUND", Info = "FROSTED", ItemDetailId = 16 },
        new ItemCategory { Id = 96, Name = "SPECIAL", Info = "SNOW LEOPARD", ItemDetailId = 16 },

        new ItemCategory { Id = 97, Name = "CLOTHING", Info = "FROST SUIT", ItemDetailId = 17 },
        new ItemCategory { Id = 98, Name = "EYES", Info = "FROST GAZE", ItemDetailId = 17 },
        new ItemCategory { Id = 99, Name = "FACE", Info = "CHILL", ItemDetailId = 17 },
        new ItemCategory { Id = 100, Name = "SKIN", Info = "FROZEN", ItemDetailId = 17 },
        new ItemCategory { Id = 101, Name = "BACKGROUND", Info = "FROSTED", ItemDetailId = 17 },
        new ItemCategory { Id = 102, Name = "SPECIAL", Info = "FROST BEAR", ItemDetailId = 17 },

        new ItemCategory { Id = 103, Name = "CLOTHING", Info = "ICE JACKET", ItemDetailId = 18 },
        new ItemCategory { Id = 104, Name = "EYES", Info = "ARCTIC GAZE", ItemDetailId = 18 },
        new ItemCategory { Id = 105, Name = "FACE", Info = "CHILLED", ItemDetailId = 18 },
        new ItemCategory { Id = 106, Name = "SKIN", Info = "FROSTY", ItemDetailId = 18 },
        new ItemCategory { Id = 107, Name = "BACKGROUND", Info = "ICE CAVE", ItemDetailId = 18 },
        new ItemCategory { Id = 108, Name = "SPECIAL", Info = "ICE BEAR", ItemDetailId = 18 },

        new ItemCategory { Id = 109, Name = "CLOTHING", Info = "SNOW TREKKING SUIT", ItemDetailId = 19 },
        new ItemCategory { Id = 110, Name = "EYES", Info = "ICE GAZE", ItemDetailId = 19 },
        new ItemCategory { Id = 111, Name = "FACE", Info = "FROSTBITE", ItemDetailId = 19 },
        new ItemCategory { Id = 112, Name = "SKIN", Info = "FROZEN", ItemDetailId = 19 },
        new ItemCategory { Id = 113, Name = "BACKGROUND", Info = "SNOWY", ItemDetailId = 19 },
        new ItemCategory { Id = 114, Name = "SPECIAL", Info = "SNOWY OWL", ItemDetailId = 19 },

        new ItemCategory { Id = 115, Name = "CLOTHING", Info = "FROSTBITE PARKA", ItemDetailId = 20 },
        new ItemCategory { Id = 116, Name = "EYES", Info = "CHILLED GAZE", ItemDetailId = 20 },
        new ItemCategory { Id = 117, Name = "FACE", Info = "SNOWY", ItemDetailId = 20 },
        new ItemCategory { Id = 118, Name = "SKIN", Info = "PALE", ItemDetailId = 20 },
        new ItemCategory { Id = 119, Name = "BACKGROUND", Info = "FROSTED", ItemDetailId = 20 },
        new ItemCategory { Id = 120, Name = "SPECIAL", Info = "FROST WOLF", ItemDetailId = 20 },

        new ItemCategory { Id = 121, Name = "CLOTHING", Info = "ICE EXPLORER SUIT", ItemDetailId = 21 },
        new ItemCategory { Id = 122, Name = "EYES", Info = "ARCTIC GAZE", ItemDetailId = 21 },
        new ItemCategory { Id = 123, Name = "FACE", Info = "CHILLED", ItemDetailId = 21 },
        new ItemCategory { Id = 124, Name = "SKIN", Info = "FROZEN", ItemDetailId = 21 },
        new ItemCategory { Id = 125, Name = "BACKGROUND", Info = "ICE CAVE", ItemDetailId = 21 },
        new ItemCategory { Id = 126, Name = "SPECIAL", Info = "ICE BEAR", ItemDetailId = 21 },

        new ItemCategory { Id = 127, Name = "CLOTHING", Info = "BLIZZARD SUIT", ItemDetailId = 22 },
        new ItemCategory { Id = 128, Name = "EYES", Info = "FROSTED GAZE", ItemDetailId = 22 },
        new ItemCategory { Id = 129, Name = "FACE", Info = "CHILLED", ItemDetailId = 22 },
        new ItemCategory { Id = 130, Name = "SKIN", Info = "FROZEN", ItemDetailId = 22 },
        new ItemCategory { Id = 131, Name = "BACKGROUND", Info = "BLIZZARD", ItemDetailId = 22 },
        new ItemCategory { Id = 132, Name = "SPECIAL", Info = "BLIZZARD WOLF", ItemDetailId = 22 },

        new ItemCategory { Id = 133, Name = "CLOTHING", Info = "SNOW TROOPER SUIT", ItemDetailId = 23 },
        new ItemCategory { Id = 134, Name = "EYES", Info = "FROSTBITE GAZE", ItemDetailId = 23 },
        new ItemCategory { Id = 135, Name = "FACE", Info = "SNOWY", ItemDetailId = 23 },
        new ItemCategory { Id = 136, Name = "SKIN", Info = "PALE", ItemDetailId = 23 },
        new ItemCategory { Id = 137, Name = "BACKGROUND", Info = "FROSTED", ItemDetailId = 23 },
        new ItemCategory { Id = 138, Name = "SPECIAL", Info = "FROST TIGER", ItemDetailId = 23 },

        new ItemCategory { Id = 139, Name = "CLOTHING", Info = "ARCTIC WARRIOR SUIT", ItemDetailId = 24 },
        new ItemCategory { Id = 140, Name = "EYES", Info = "FROST GAZE", ItemDetailId = 24 },
        new ItemCategory { Id = 141, Name = "FACE", Info = "CHILL", ItemDetailId = 24 },
        new ItemCategory { Id = 142, Name = "SKIN", Info = "FROSTED", ItemDetailId = 24 },
        new ItemCategory { Id = 143, Name = "BACKGROUND", Info = "ARCTIC", ItemDetailId = 24 },
        new ItemCategory { Id = 144, Name = "SPECIAL", Info = "ARCTIC BEAR", ItemDetailId = 24 },

        new ItemCategory { Id = 145, Name = "CLOTHING", Info = "GLACIAL COMMANDER SUIT", ItemDetailId = 25 },
        new ItemCategory { Id = 146, Name = "EYES", Info = "FROST COMMAND", ItemDetailId = 25 },
        new ItemCategory { Id = 147, Name = "FACE", Info = "CHILLED", ItemDetailId = 25 },
        new ItemCategory { Id = 148, Name = "SKIN", Info = "FROZEN", ItemDetailId = 25 },
        new ItemCategory { Id = 149, Name = "BACKGROUND", Info = "GLACIER", ItemDetailId = 25 },
        new ItemCategory { Id = 150, Name = "SPECIAL", Info = "GLACIAL BEAR", ItemDetailId = 25 }
    ];

    public static IReadOnlyCollection<ItemDetail> ItemDetails() =>
    [
        new ItemDetail { Id = 1, Description = "Discover a collection of unique skins drawn from heroic missions and challenges. Each skin tells a story of bravery and triumph. Equip SKISIRS#4587 and embark on your own legendary journey.", Price = 15, ItemId = 1 },
        new ItemDetail { Id = 2, Description = "Embrace the frost with this cool and stylish collection. FROSTIC#4571 offers both protection and style in the harshest of conditions. Equip it and conquer the icy realms with confidence.", Price = 20, ItemId = 2 },
        new ItemDetail { Id = 3, Description = "Gear up like a brave mountaineer with MOUNTIANO#8992. Crafted for adventurers, this gear ensures comfort and durability in extreme terrains. Embark on your next expedition with confidence.", Price = 25, ItemId = 3 },
        new ItemDetail { Id = 4, Description = "Conquer the snow with style with SNOWBLIZZ#3315. This sleek and versatile gear offers both warmth and mobility, perfect for high-speed descents or leisurely treks. Elevate your winter experience today.", Price = 18, ItemId = 4 },
        new ItemDetail { Id = 5, Description = "Experience the thrill of arctic adventure with GLACIERIS#2453. Designed for explorers, this gear offers superior protection against the elements while allowing freedom of movement. Prepare for an unforgettable journey.", Price = 30, ItemId = 5 },
        new ItemDetail { Id = 6, Description = "Embark on a frozen journey with ICETREK#7793. This gear is engineered for both performance and style, ensuring you stay warm and agile in snowy landscapes. Equip it and embrace the chill.", Price = 22, ItemId = 6 },
        new ItemDetail { Id = 7, Description = "Fly through the powdery snow with POWDERFLY#6621. This sleek and aerodynamic gear enhances your speed and agility on the slopes. Dominate the snowscape with confidence.", Price = 28, ItemId = 7 },
        new ItemDetail { Id = 8, Description = "Experience an avalanche of excitement with AVALANCHEER#1076. This gear offers unmatched protection against avalanches and extreme weather conditions. Equip it and conquer the mountains with confidence.", Price = 35, ItemId = 8 },
        new ItemDetail { Id = 9, Description = "Sledding just got sleeker with SLEDDOR#5538. Crafted for speed and durability, this gear ensures thrilling descents down snowy hills. Get ready for the ultimate sledding adventure.", Price = 40, ItemId = 9 },
        new ItemDetail { Id = 10, Description = "Stay warm and stylish with BLIZZARDOR#2255. This gear offers superior insulation against cold temperatures while maintaining a sleek and modern design. Elevate your winter wardrobe today.", Price = 45, ItemId = 10 },
        new ItemDetail { Id = 11, Description = "Break the ice in style with ICEBURST#6677. Designed for both performance and aesthetics, this gear ensures you stand out on the slopes while staying warm and agile. Dominate the snowscape with confidence.", Price = 30, ItemId = 11 },
        new ItemDetail { Id = 12, Description = "Shine through the snow with SNOWSHINE#8834. Crafted for style and functionality, this gear offers superior protection against cold temperatures while exuding elegance on the slopes. Elevate your winter style today.", Price = 25, ItemId = 12 },
        new ItemDetail { Id = 13, Description = "Fly high in frosty skies with FROSTFLY#4419. This sleek and aerodynamic gear enhances your performance in snowy landscapes, allowing you to soar above the competition. Prepare for an exhilarating flight.", Price = 32, ItemId = 13 },
        new ItemDetail { Id = 14, Description = "Chill with glacier style with GLACIATOR#1182. Crafted for both performance and aesthetics, this gear ensures you stay warm and stylish on the slopes. Dominate the snowscape with confidence.", Price = 38, ItemId = 14 },
        new ItemDetail { Id = 15, Description = "Master the mountains with MOUNTAINEER#9966. This gear offers superior protection and performance in extreme terrains, ensuring you conquer any challenge with confidence. Embark on your next expedition today.", Price = 42, ItemId = 15 },
        new ItemDetail { Id = 16, Description = "Sled like a pro with SLEDGEMAN#6644. Crafted for speed and agility, this gear ensures thrilling descents down snowy hills while maintaining control and stability. Get ready for an adrenaline-packed ride.", Price = 48, ItemId = 16 },
        new ItemDetail { Id = 17, Description = "Blast through the chill with CHILLBLAST#3322. This sleek and aerodynamic gear enhances your speed and agility on the slopes, ensuring you stay ahead of the competition. Dominate the snowscape with confidence.", Price = 20, ItemId = 17 },
        new ItemDetail { Id = 18, Description = "Break the ice with power with ICEBREAKER#5544. Crafted for both strength and style, this gear ensures you stand out on the slopes while maintaining control and stability. Dominate the snowscape with confidence.", Price = 25, ItemId = 18 },
        new ItemDetail { Id = 19, Description = "Trek through snowy landscapes with SNOWTREK#4466. Designed for adventurers, this gear offers superior traction and stability on icy terrains, ensuring you explore with confidence. Embark on your next journey today.", Price = 30, ItemId = 19 },
        new ItemDetail { Id = 20, Description = "Fire up the frost with FROSTYFIRE#7788. This sleek and stylish gear offers superior insulation against cold temperatures while exuding elegance on the slopes. Elevate your winter wardrobe today.", Price = 22, ItemId = 20 },
        new ItemDetail { Id = 21, Description = "Bolt through glaciers with GLACIERBOLT#1122. Crafted for speed and agility, this gear ensures thrilling descents down snowy slopes while maintaining control and stability. Get ready for an electrifying ride.", Price = 28, ItemId = 21 },
        new ItemDetail { Id = 22, Description = "Cool cycling adventure awaits with ICYCLE#5533. This sleek and aerodynamic gear enhances your performance on icy roads, ensuring you navigate with speed and precision. Embark on your next cycling journey with confidence.", Price = 35, ItemId = 22 },
        new ItemDetail { Id = 23, Description = "Drift through snowy paths with SNOWDRIFT#2277. Crafted for both style and functionality, this gear ensures you stand out on the slopes while maintaining control and stability. Dominate the snowscape with confidence.", Price = 40, ItemId = 23 },
        new ItemDetail { Id = 24, Description = "Blaze chilly trails with CHILLYBLAZE#9966. This sleek and aerodynamic gear enhances your speed and agility on icy terrains, ensuring you stay ahead of the competition. Dominate the snowscape with confidence.", Price = 45, ItemId = 24 },
        new ItemDetail { Id = 25, Description = "Feel the frostbite with FROSTBITE#3344. Crafted for both warmth and style, this gear ensures you stay comfortable and chic on the slopes. Elevate your winter wardrobe with this sleek and versatile option.", Price = 50, ItemId = 25 }
    ];

    public static IReadOnlyCollection<ShopItem> ShopItems() =>
    [
        new ShopItem { Id = 1, Image = "http://localhost:5112/static/product/product1.jpg", Title = "SKISIRS#4587" },
        new ShopItem { Id = 2, Image = "http://localhost:5112/static/product/product2.jpg", Title = "FROSTIC#4571" },
        new ShopItem { Id = 3, Image = "http://localhost:5112/static/product/product3.jpg", Title = "MOUNTIANO#8992" },
        new ShopItem { Id = 4, Image = "http://localhost:5112/static/product/product4.jpg", Title = "SNOWBLIZZ#3315" },
        new ShopItem { Id = 5, Image = "http://localhost:5112/static/product/product5.jpg", Title = "GLACIERIS#2453" },
        new ShopItem { Id = 6, Image = "http://localhost:5112/static/product/product6.jpg", Title = "ICETREK#7793" },
        new ShopItem { Id = 7, Image = "http://localhost:5112/static/product/product7.jpg", Title = "POWDERFLY#6621" },
        new ShopItem
            { Id = 8, Image = "http://localhost:5112/static/product/product8.jpg", Title = "AVALANCHEER#1076" },
        new ShopItem { Id = 9, Image = "http://localhost:5112/static/product/product9.jpg", Title = "SLEDDOR#5538" },
        new ShopItem
            { Id = 10, Image = "http://localhost:5112/static/product/product10.jpg", Title = "BLIZZARDOR#2255" },
        new ShopItem { Id = 11, Image = "http://localhost:5112/static/product/product11.jpg", Title = "ICEBURST#6677" },
        new ShopItem
            { Id = 12, Image = "http://localhost:5112/static/product/product12.jpg", Title = "SNOWSHINE#8834" },
        new ShopItem { Id = 13, Image = "http://localhost:5112/static/product/product13.jpg", Title = "FROSTFLY#4419" },
        new ShopItem
            { Id = 14, Image = "http://localhost:5112/static/product/product14.jpg", Title = "GLACIATOR#1182" },
        new ShopItem
            { Id = 15, Image = "http://localhost:5112/static/product/product15.jpg", Title = "MOUNTAINEER#9966" },
        new ShopItem
            { Id = 16, Image = "http://localhost:5112/static/product/product16.jpg", Title = "SLEDGEMAN#6644" },
        new ShopItem
            { Id = 17, Image = "http://localhost:5112/static/product/product17.jpg", Title = "CHILLBLAST#3322" },
        new ShopItem
            { Id = 18, Image = "http://localhost:5112/static/product/product18.jpg", Title = "ICEBREAKER#5544" },
        new ShopItem { Id = 19, Image = "http://localhost:5112/static/product/product19.jpg", Title = "SNOWTREK#4466" },
        new ShopItem
            { Id = 20, Image = "http://localhost:5112/static/product/product20.jpg", Title = "FROSTYFIRE#7788" },
        new ShopItem
            { Id = 21, Image = "http://localhost:5112/static/product/product21.jpg", Title = "GLACIERBOLT#1122" },
        new ShopItem { Id = 22, Image = "http://localhost:5112/static/product/product22.jpg", Title = "ICYCLE#5533" },
        new ShopItem
            { Id = 23, Image = "http://localhost:5112/static/product/product23.jpg", Title = "SNOWDRIFT#2277" },
        new ShopItem
            { Id = 24, Image = "http://localhost:5112/static/product/product24.jpg", Title = "CHILLYBLAZE#9966" },
        new ShopItem { Id = 25, Image = "http://localhost:5112/static/product/product25.jpg", Title = "FROSTBITE#3344" }
    ];

    public static IReadOnlyCollection<Banner> Banners() =>
    [
        new Banner
        {
            Id = 1, Language = "EN", Title = "EXPLORE NFT COLLECTION",
            Description = "We are the best way to check the rarity of NFT collection"
        },
        new Banner
        {
            Id = 2, Language = "RU", Title = "ИССЛЕДУЙТЕ КОЛЛЕКЦИЮ NFT",
            Description = "Мы лучший способ проверить редкость коллекции NFT"
        }
    ];

    public static IReadOnlyCollection<Work> Works() =>
    [
        new Work
        {
            Id = 1, Language = "EN", Title = "CONNECT THE WALLET",
            Image = "http://localhost:5112/static/svg/work-1.svg",
            Text = "Connect your wallet to start working with our platform."
        },
        new Work
        {
            Id = 2, Language = "EN", Title = "SELECT THE QUALITY",
            Image = "http://localhost:5112/static/svg/work-2.svg",
            Text = "Choose the quality and type of NFT you want to create or purchase."
        },
        new Work
        {
            Id = 3, Language = "EN", Title = "CONFIRM TRANSACTION",
            Image = "http://localhost:5112/static/svg/work-3.svg",
            Text = "Confirm the transaction in your wallet to complete the process."
        },
        new Work
        {
            Id = 4, Language = "EN", Title = "RECEIVE YOUR NFTS", Image = "http://localhost:5112/static/svg/work-4.svg",
            Text = "Receive your NFTs and enjoy them in your digital collection space."
        },
        new Work
        {
            Id = 5, Language = "RU", Title = "ПОДКЛЮЧИТЕ КОШЕЛЕК",
            Image = "http://localhost:5112/static/svg/work-1.svg",
            Text = "Подключите свой кошелек, чтобы начать работать с нашей платформой."
        },
        new Work
        {
            Id = 6, Language = "RU", Title = "ВЫБЕРИТЕ КАЧЕСТВО", Image = "http://localhost:5112/static/svg/work-2.svg",
            Text = "Выберите качество и тип NFT, который вы хотите создать или приобрести."
        },
        new Work
        {
            Id = 7, Language = "RU", Title = "ПОДТВЕРДИТЕ ТРАНЗАКЦИЮ",
            Image = "http://localhost:5112/static/svg/work-3.svg",
            Text = "Подтвердите транзакцию в вашем кошельке для завершения процесса."
        },
        new Work
        {
            Id = 8, Language = "RU", Title = "ПОЛУЧИТЕ ВАШИ NFT", Image = "http://localhost:5112/static/svg/work-4.svg",
            Text = "Получите ваши NFT и наслаждайтесь ими в вашем цифровом коллекционном пространстве."
        }
    ];

    public static IReadOnlyCollection<AboutCounter> AboutCounters() =>
    [
        new AboutCounter { Id = 1, Language = "EN", Title = "Total Items", Number = ShopItems().Count, AboutId = 1 },
        new AboutCounter { Id = 2, Language = "EN", Title = "Profiles Whitelisted", Number = 1000, AboutId = 1 },

        new AboutCounter
            { Id = 3, Language = "RU", Title = "Количество предметов", Number = ShopItems().Count, AboutId = 2 },
        new AboutCounter
            { Id = 4, Language = "RU", Title = "Пользователей зарегистрировано", Number = 1000, AboutId = 2 },
    ];

    public static IReadOnlyCollection<AboutStat> AboutStats() =>
    [
        new AboutStat
        {
            Id = 1, Language = "EN", Title = "HIGH QUALITY",
            Text =
                "The products or services offered are crafted using advanced technologies and undergo rigorous quality control.",
            AboutId = 1
        },
        new AboutStat
        {
            Id = 2, Language = "EN", Title = "LARGE COLLECTION",
            Text =
                "We offer a wide range of products or services to meet the needs of even the most discerning customers.",
            AboutId = 1
        },
        new AboutStat
        {
            Id = 3, Language = "EN", Title = "TOP RESOURCES",
            Text =
                "We provide access to cutting-edge resources to help you achieve success and prosperity in your business or project.",
            AboutId = 1
        },
        new AboutStat
        {
            Id = 4, Language = "EN", Title = "BIG COMMUNITY",
            Text =
                "Join our extensive community where you'll find support, advice, and opportunities for growth and knowledge exchange.",
            AboutId = 1
        },

        new AboutStat
        {
            Id = 5, Language = "RU", Title = "ВЫСОКОЕ КАЧЕСТВО",
            Text =
                "Предлагаемые продукты или услуги изготавливаются с использованием передовых технологий и проходят строгий контроль качества.",
            AboutId = 2
        },
        new AboutStat
        {
            Id = 6, Language = "RU", Title = "БОЛЬШАЯ КОЛЛЕКЦИЯ",
            Text =
                "Мы предлагаем широкий выбор продуктов или услуг, чтобы удовлетворить потребности самых требовательных клиентов.",
            AboutId = 2
        },
        new AboutStat
        {
            Id = 7, Language = "RU", Title = "ТОПОВЫЕ РЕСУРСЫ",
            Text =
                "Мы предоставляем доступ к передовым ресурсам, которые помогут вам достичь успеха и процветания в вашем бизнесе или проекте.",
            AboutId = 2
        },
        new AboutStat
        {
            Id = 8, Language = "RU", Title = "БОЛЬШОЕ СООБЩЕСТВО",
            Text =
                "Присоединяйтесь к нашему обширному сообществу, где вы найдете поддержку, советы и возможности для роста и обмена опытом.",
            AboutId = 2
        }
    ];

    public static IReadOnlyCollection<About> Abouts() =>
    [
        new About
        {
            Id = 1, Language = "EN", Title = "ABOUT US",
            Description =
                "Welcome to our NFT platform! We're passionate about digital art and blockchain technology. Explore our diverse collection of unique NFTs created by talented artists from around the world. Join our vibrant community and discover the future of digital ownership!"
        },
        new About
        {
            Id = 2, Language = "RU", Title = "О НАС",
            Description =
                "Добро пожаловать на нашу платформу NFT! Мы увлечены цифровым искусством и технологией блокчейн. Исследуйте наш разнообразный ассортимент уникальных NFT, созданных талантливыми художниками со всего мира. Присоединяйтесь к нашему живому сообществу и откройте будущее цифровой собственности!"
        }
    ];

    public static IReadOnlyCollection<Team> Teams() =>
    [
        new Team
        {
            Id = 1, Language = "EN", Image = "http://localhost:5112/static/team/team-1.jpg", Name = "Ralph Edwards",
            Position = "Founder"
        },
        new Team
        {
            Id = 2, Language = "EN", Image = "http://localhost:5112/static/team/team-2.jpg", Name = "Jason Smith",
            Position = "Co - Founder"
        },
        new Team
        {
            Id = 3, Language = "EN", Image = "http://localhost:5112/static/team/team-3.jpg", Name = "Tony Wings",
            Position = "Web Designer"
        },
        new Team
        {
            Id = 4, Language = "EN", Image = "http://localhost:5112/static/team/team-4.jpg", Name = "Esther Howard",
            Position = "Project Manager"
        },
        new Team
        {
            Id = 5, Language = "EN", Image = "http://localhost:5112/static/team/team-5.jpg", Name = "Jenny Wilson",
            Position = "Artist"
        },
        new Team
        {
            Id = 6, Language = "EN", Image = "http://localhost:5112/static/team/team-6.jpg", Name = "Robert Fox",
            Position = "UI/UX Designer"
        },
        new Team
        {
            Id = 7, Language = "EN", Image = "http://localhost:5112/static/team/team-7.jpg", Name = "Devon Lane",
            Position = "UX Architect"
        },

        new Team
        {
            Id = 8, Language = "RU", Image = "http://localhost:5112/static/team/team-1.jpg", Name = "Ральф Эдвардс",
            Position = "Основатель"
        },
        new Team
        {
            Id = 9, Language = "RU", Image = "http://localhost:5112/static/team/team-2.jpg", Name = "Джейсон Смит",
            Position = "Сооснователь"
        },
        new Team
        {
            Id = 10, Language = "RU", Image = "http://localhost:5112/static/team/team-3.jpg", Name = "Тони Уингс",
            Position = "Веб-дизайнер"
        },
        new Team
        {
            Id = 11, Language = "RU", Image = "http://localhost:5112/static/team/team-4.jpg", Name = "Эстер Ховард",
            Position = "Менеджер проекта"
        },
        new Team
        {
            Id = 12, Language = "RU", Image = "http://localhost:5112/static/team/team-5.jpg", Name = "Дженни Уилсон",
            Position = "Художник"
        },
        new Team
        {
            Id = 13, Language = "RU", Image = "http://localhost:5112/static/team/team-6.jpg", Name = "Роберт Фокс",
            Position = "Дизайнер интерфейса / пользовательских интерфейсов"
        },
        new Team
        {
            Id = 14, Language = "RU", Image = "http://localhost:5112/static/team/team-7.jpg", Name = "Девон Лейн",
            Position = "Архитектор пользовательских интерфейсов"
        }
    ];

    public static IReadOnlyCollection<Contact> Contacts() =>
    [
        new Contact
        {
            Id = 1, Language = "EN", Title = "Location", Info = "2163 Phillips Gap Rd West Jefferson",
            Image = "http://localhost:5112/static/svg/loaction.svg"
        },
        new Contact
        {
            Id = 2, Language = "EN", Title = "Email", Info = "Info.avitex@gmail.com",
            Image = "http://localhost:5112/static/svg/email.svg"
        },
        new Contact
        {
            Id = 3, Language = "EN", Title = "Phone", Info = "2163 Phillips Gap Rd West Jefferson",
            Image = "http://localhost:5112/static/svg/phone.svg"
        },

        new Contact
        {
            Id = 4, Language = "RU", Title = "Местоположение", Info = "+1 666 8888",
            Image = "http://localhost:5112/static/svg/loaction.svg"
        },
        new Contact
        {
            Id = 5, Language = "RU", Title = "Электронная почта", Info = "Info.avitex@gmail.com",
            Image = "http://localhost:5112/static/svg/email.svg"
        },
        new Contact
        {
            Id = 6, Language = "RU", Title = "Номер телефона", Info = "+1 666 8888",
            Image = "http://localhost:5112/static/svg/phone.svg"
        }
    ];

    public static IReadOnlyCollection<ReviewInfo> ReviewInfos() =>
    [
        new ReviewInfo
        {
            Id = 1, Language = "EN", Title = "WHAT PEOPLE SAY",
            Description =
                "Testimonials from our clients about our work. We take pride in the high praise our work receives."
        },
        new ReviewInfo
        {
            Id = 2, Language = "RU", Title = "ЧТО ГОВОРЯТ ЛЮДИ",
            Description = "Отзывы наших клиентов о нашей работе. Мы гордимся тем, что наша работа оценена так высоко."
        },
    ];

    public static IReadOnlyCollection<Review> Reviews() =>
    [
        new Review
        {
            Id = 1, Name = "John Smith", Text = "Great experience working with this team. Professional and efficient!",
            Avatar = "http://localhost:5112/static/author/avt1.jpg", ReviewInfoId = 1
        },
        new Review
        {
            Id = 2, Name = "Emily Johnson",
            Text = "Excellent service! I'm impressed with the attention to detail and quick turnaround.",
            Avatar = "http://localhost:5112/static/author/avt2.jpg", ReviewInfoId = 1
        },
        new Review
        {
            Id = 3, Name = "Michael Brown",
            Text = "Highly recommend! The team went above and beyond to meet our needs.",
            Avatar = "http://localhost:5112/static/author/avt3.jpg", ReviewInfoId = 1
        },
        new Review
        {
            Id = 4, Name = "Sarah Williams",
            Text = "Outstanding work! Very pleased with the results and level of professionalism.",
            Avatar = "http://localhost:5112/static/author/avt4.jpg", ReviewInfoId = 1
        },
        new Review
        {
            Id = 5, Name = "Jessica Miller",
            Text = "Thank you for the exceptional service! Will definitely work with you again in the future.",
            Avatar = "http://localhost:5112/static/author/avt5.jpg", ReviewInfoId = 1
        },
        new Review
        {
            Id = 6, Name = "David Wilson",
            Text = "Amazing team! They delivered exactly what we needed on time and within budget.",
            Avatar = "http://localhost:5112/static/author/avt6.jpg", ReviewInfoId = 1
        },

        new Review
        {
            Id = 7, Name = "Алексей Петров",
            Text = "Быстрое и профессиональное обслуживание. Очень доволен результатом!",
            Avatar = "http://localhost:5112/static/author/avt1.jpg", ReviewInfoId = 2
        },
        new Review
        {
            Id = 8, Name = "Марина Иванова",
            Text = "Отличный опыт работы с этой компанией. Профессиональный подход и высокое качество услуг.",
            Avatar = "http://localhost:5112/static/author/avt2.jpg", ReviewInfoId = 2
        },
        new Review
        {
            Id = 9, Name = "Дмитрий Смирнов",
            Text = "Получил большое удовольствие от сотрудничества. Все было сделано быстро и качественно.",
            Avatar = "http://localhost:5112/static/author/avt3.jpg", ReviewInfoId = 2
        },
        new Review
        {
            Id = 10, Name = "Елена Козлова",
            Text = "Очень рекомендую эту компанию. Профессиональный персонал и оперативное выполнение заказов.",
            Avatar = "http://localhost:5112/static/author/avt4.jpg", ReviewInfoId = 2
        },
        new Review
        {
            Id = 11, Name = "Иван Федоров", Text = "Благодарю за отличный сервис! Результат превзошел мои ожидания.",
            Avatar = "http://localhost:5112/static/author/avt5.jpg", ReviewInfoId = 2
        },
        new Review
        {
            Id = 12, Name = "Ольга Соколова",
            Text = "Это лучшая компания, с которой я когда-либо работал. Профессиональный и дружелюбный персонал.",
            Avatar = "http://localhost:5112/static/author/avt6.jpg", ReviewInfoId = 2
        }
    ];

    public static IReadOnlyCollection<Faq> Faqs() =>
    [
        new Faq
        {
            Id = 1, Language = "EN", Title = "What are NFTs?",
            Text =
                "NFTs, or Non-Fungible Tokens, are unique digital assets stored on a blockchain that represent ownership of a specific item or piece of content. Unlike cryptocurrencies, each NFT is distinct and cannot be exchanged on a one-to-one basis.",
            Show = true
        },
        new Faq
        {
            Id = 2, Language = "EN", Title = "How do I acquire NFTs?",
            Text =
                "Acquiring NFTs typically involves purchasing them from online marketplaces or participating in NFT auctions. You'll need a digital wallet compatible with the blockchain where the NFTs are hosted to store and manage your acquisitions.",
            Show = false
        },
        new Faq
        {
            Id = 3, Language = "EN", Title = "How can we buy and invest in NFTs?",
            Text =
                "Buying and investing in NFTs requires understanding the market dynamics and potential value of digital assets. Research different platforms and projects, evaluate the authenticity and uniqueness of NFTs, and consider long-term investment strategies.",
            Show = false
        },
        new Faq
        {
            Id = 4, Language = "EN", Title = "Where can we buy and sell NFTs?",
            Text =
                "You can buy and sell NFTs on various online platforms called NFT marketplaces. These platforms facilitate transactions between buyers and sellers, providing a secure environment for trading digital assets.",
            Show = false
        },
        new Faq
        {
            Id = 5, Language = "EN", Title = "Who is the team behind the project?",
            Text =
                "The team behind the project consists of experienced professionals in blockchain technology, digital art, finance, and software development. They are dedicated to building innovative solutions and fostering the growth of the NFT ecosystem.",
            Show = false
        },
        new Faq
        {
            Id = 6, Language = "EN", Title = "What is your contract address?",
            Text =
                "The contract address is a unique identifier assigned to the smart contract governing the creation and transfer of NFTs. It serves as a reference point for verifying the authenticity and integrity of NFT transactions on the blockchain.",
            Show = false
        },

        new Faq
        {
            Id = 7, Language = "RU", Title = "Что такое NFT?",
            Text =
                "NFT, или Необменяемые Токены, - это уникальные цифровые активы, хранящиеся на блокчейне и представляющие собой владение определенным предметом или контентом. В отличие от криптовалют, каждый NFT уникален и не может быть обменен в один-на-один.",
            Show = true
        },
        new Faq
        {
            Id = 8, Language = "RU", Title = "Как я могу приобрести NFT?",
            Text =
                "Приобретение NFT обычно включает покупку их на онлайн-рынках или участие в аукционах NFT. Вам понадобится цифровой кошелек, совместимый с блокчейном, где хранятся NFT, для хранения и управления вашими приобретениями.",
            Show = false
        },
        new Faq
        {
            Id = 9, Language = "RU", Title = "Как мы можем покупать и инвестировать в NFT?",
            Text =
                "Покупка и инвестирование в NFT требует понимания динамики рынка и потенциальной стоимости цифровых активов. Изучите различные платформы и проекты, оцените подлинность и уникальность NFT, и рассмотрите стратегии долгосрочного инвестирования.",
            Show = false
        },
        new Faq
        {
            Id = 10, Language = "RU", Title = "Где мы можем покупать и продавать NFT?",
            Text =
                "Вы можете покупать и продавать NFT на различных онлайн-платформах, называемых рынками NFT. Эти платформы облегчают сделки между покупателями и продавцами, обеспечивая безопасную среду для торговли цифровыми активами.",
            Show = false
        },
        new Faq
        {
            Id = 11, Language = "RU", Title = "Кто составляет команду проекта?",
            Text =
                "Команда проекта состоит из опытных специалистов в области технологии блокчейн, цифрового искусства, финансов и разработки программного обеспечения. Они посвятили себя созданию инновационных решений и развитию экосистемы NFT.",
            Show = false
        },
        new Faq
        {
            Id = 12, Language = "RU", Title = "Каков ваш адрес контракта?",
            Text =
                "Адрес контракта - это уникальный идентификатор, присвоенный смарт-контракту, регулирующему создание и передачу NFT. Он служит точкой ссылки для проверки подлинности и целостности транзакций NFT на блокчейне.",
            Show = false
        }
    ];

    public static IReadOnlyCollection<RoadMap> RoadMaps() =>
    [
        new RoadMap { Id = 1, Language = "EN", Title = "PHASE 1", Class = "left" },
        new RoadMap { Id = 2, Language = "EN", Title = "PHASE 2", Class = "right" },
        new RoadMap { Id = 3, Language = "EN", Title = "PHASE 3", Class = "left" },
        new RoadMap { Id = 4, Language = "EN", Title = "PHASE 4", Class = "right" },
        new RoadMap { Id = 5, Language = "EN", Title = "PHASE 5", Class = "left" },
        new RoadMap { Id = 6, Language = "EN", Title = "PHASE 6", Class = "right" },

        new RoadMap { Id = 7, Language = "RU", Title = "ФАЗА 1", Class = "left" },
        new RoadMap { Id = 8, Language = "RU", Title = "ФАЗА 2", Class = "right" },
        new RoadMap { Id = 9, Language = "RU", Title = "ФАЗА 3", Class = "left" },
        new RoadMap { Id = 10, Language = "RU", Title = "ФАЗА 4", Class = "right" },
        new RoadMap { Id = 11, Language = "RU", Title = "ФАЗА 5", Class = "left" },
        new RoadMap { Id = 12, Language = "RU", Title = "ФАЗА 6", Class = "right" }
    ];

    public static IReadOnlyCollection<RoadMapBenefit> RoadMapBenefits() =>
    [
        new RoadMapBenefit { Id = 1, Text = "Befriending & Chat Functions", RoadMapId = 1 },
        new RoadMapBenefit { Id = 2, Text = "Challenging Feature", RoadMapId = 1 },
        new RoadMapBenefit { Id = 3, Text = "Corsair Wheel", RoadMapId = 1 },
        new RoadMapBenefit { Id = 4, Text = "Mobile Version Launch", RoadMapId = 1 },

        new RoadMapBenefit { Id = 5, Text = "Befriending & Chat Functions", RoadMapId = 2 },
        new RoadMapBenefit { Id = 6, Text = "Challenging Feature", RoadMapId = 2 },
        new RoadMapBenefit { Id = 7, Text = "Corsair Wheel", RoadMapId = 2 },
        new RoadMapBenefit { Id = 8, Text = "Mobile Version Launch", RoadMapId = 2 },

        new RoadMapBenefit { Id = 9, Text = "Befriending & Chat Functions", RoadMapId = 3 },
        new RoadMapBenefit { Id = 10, Text = "Challenging Feature", RoadMapId = 3 },
        new RoadMapBenefit { Id = 11, Text = "Corsair Wheel", RoadMapId = 3 },
        new RoadMapBenefit { Id = 12, Text = "Mobile Version Launch", RoadMapId = 3 },

        new RoadMapBenefit { Id = 13, Text = "Befriending & Chat Functions", RoadMapId = 4 },
        new RoadMapBenefit { Id = 14, Text = "Challenging Feature", RoadMapId = 4 },
        new RoadMapBenefit { Id = 15, Text = "Corsair Wheel", RoadMapId = 4 },
        new RoadMapBenefit { Id = 16, Text = "Mobile Version Launch", RoadMapId = 4 },

        new RoadMapBenefit { Id = 17, Text = "Befriending & Chat Functions", RoadMapId = 5 },
        new RoadMapBenefit { Id = 18, Text = "Challenging Feature", RoadMapId = 5 },
        new RoadMapBenefit { Id = 19, Text = "Corsair Wheel", RoadMapId = 5 },
        new RoadMapBenefit { Id = 20, Text = "Mobile Version Launch", RoadMapId = 5 },

        new RoadMapBenefit { Id = 21, Text = "Befriending & Chat Functions", RoadMapId = 6 },
        new RoadMapBenefit { Id = 22, Text = "Challenging Feature", RoadMapId = 6 },
        new RoadMapBenefit { Id = 23, Text = "Corsair Wheel", RoadMapId = 6 },
        new RoadMapBenefit { Id = 24, Text = "Mobile Version Launch", RoadMapId = 6 },

        new RoadMapBenefit { Id = 25, Text = "Функции Дружбы и Чата", RoadMapId = 7 },
        new RoadMapBenefit { Id = 26, Text = "Интересная Особенность", RoadMapId = 7 },
        new RoadMapBenefit { Id = 27, Text = "Колесо Корсара", RoadMapId = 7 },
        new RoadMapBenefit { Id = 28, Text = "Запуск Мобильной Версии", RoadMapId = 7 },

        new RoadMapBenefit { Id = 29, Text = "Функции Дружбы и Чата", RoadMapId = 8 },
        new RoadMapBenefit { Id = 30, Text = "Интересная Особенность", RoadMapId = 8 },
        new RoadMapBenefit { Id = 31, Text = "Колесо Корсара", RoadMapId = 8 },
        new RoadMapBenefit { Id = 32, Text = "Запуск Мобильной Версии", RoadMapId = 8 },

        new RoadMapBenefit { Id = 33, Text = "Функции Дружбы и Чата", RoadMapId = 9 },
        new RoadMapBenefit { Id = 34, Text = "Интересная Особенность", RoadMapId = 9 },
        new RoadMapBenefit { Id = 35, Text = "Колесо Корсара", RoadMapId = 9 },
        new RoadMapBenefit { Id = 36, Text = "Запуск Мобильной Версии", RoadMapId = 9 },

        new RoadMapBenefit { Id = 37, Text = "Функции Дружбы и Чата", RoadMapId = 10 },
        new RoadMapBenefit { Id = 38, Text = "Интересная Особенность", RoadMapId = 10 },
        new RoadMapBenefit { Id = 39, Text = "Колесо Корсара", RoadMapId = 10 },
        new RoadMapBenefit { Id = 40, Text = "Запуск Мобильной Версии", RoadMapId = 10 },

        new RoadMapBenefit { Id = 41, Text = "Функции Дружбы и Чата", RoadMapId = 11 },
        new RoadMapBenefit { Id = 42, Text = "Интересная Особенность", RoadMapId = 11 },
        new RoadMapBenefit { Id = 43, Text = "Колесо Корсара", RoadMapId = 11 },
        new RoadMapBenefit { Id = 44, Text = "Запуск Мобильной Версии", RoadMapId = 11 },

        new RoadMapBenefit { Id = 45, Text = "Функции Дружбы и Чата", RoadMapId = 12 },
        new RoadMapBenefit { Id = 46, Text = "Интересная Особенность", RoadMapId = 12 },
        new RoadMapBenefit { Id = 47, Text = "Колесо Корсара", RoadMapId = 12 },
        new RoadMapBenefit { Id = 48, Text = "Запуск Мобильной Версии", RoadMapId = 12 }
    ];

    public static IReadOnlyCollection<Payment> Payments() =>
    [
        new Payment
        {
            Id = 1, Language = "EN", Title = "SUBSCRIPTIONS",
            Description =
                "Explore our diverse range of subscription plans tailored to meet your needs. Whether you're a beginner or an advanced user, we have a subscription that's perfect for you. Take the next step in your journey with us!"
        },

        new Payment
        {
            Id = 2, Language = "RU", Title = "Подписки",
            Description =
                "Исследуйте наш разнообразный выбор подписок, созданных, чтобы удовлетворить ваши потребности. Независимо от того, являетесь ли вы новичком или опытным пользователем, у нас есть подписка, идеально подходящая для вас. Сделайте следующий шаг в своем путешествии вместе с нами!"
        }
    ];

    public static IReadOnlyCollection<Subscription> Subscriptions() =>
    [
        new Subscription { Id = 1, Language = "EN", Title = "FREE", Price = 0, Image = "http://localhost:5112/static/icon/subscribtions/free.png", PaymentId = 1 },
        new Subscription { Id = 2, Language = "EN", Title = "VIP", Price = 10, Image = "http://localhost:5112/static/icon/subscribtions/vip.png", PaymentId = 1 },
        new Subscription { Id = 3, Language = "EN", Title = "PREMIUM", Price = 20, Image = "http://localhost:5112/static/icon/subscribtions/premium.png", PaymentId = 1 },
        
        new Subscription { Id = 4, Language = "RU", Title = "FREE", Price = 0, Image = "http://localhost:5112/static/icon/subscribtions/free.png", PaymentId = 2 },
        new Subscription { Id = 5, Language = "RU", Title = "VIP", Price = 10, Image = "http://localhost:5112/static/icon/subscribtions/vip.png", PaymentId = 2 },
        new Subscription { Id = 6, Language = "RU", Title = "PREMIUM", Price = 20, Image = "http://localhost:5112/static/icon/subscribtions/premium.png", PaymentId = 2 }
    ];

    public static IReadOnlyCollection<SubscriptionProperty> SubscriptionProperties() =>
    [
        new SubscriptionProperty { Id = 1, Text = "Ability to leave comments on posts", SubscriptionId = 1 },
        new SubscriptionProperty { Id = 2, Text = "Ability to leave reviews on the website", SubscriptionId = 1 },
        new SubscriptionProperty { Id = 3, Text = "Ability to purchase items", SubscriptionId = 1 },

        new SubscriptionProperty { Id = 4, Text = "Ability to leave comments on posts", SubscriptionId = 2 },
        new SubscriptionProperty { Id = 5, Text = "Ability to leave reviews on the website", SubscriptionId = 2 },
        new SubscriptionProperty { Id = 6, Text = "Ability to purchase items", SubscriptionId = 2 },
        new SubscriptionProperty
            { Id = 7, Text = "Ability to sell items (up to 5 items at a time)", SubscriptionId = 2 },
        new SubscriptionProperty { Id = 8, Text = "Commission for selling each item - 30%", SubscriptionId = 2 },

        new SubscriptionProperty { Id = 9, Text = "Ability to leave comments on posts", SubscriptionId = 3 },
        new SubscriptionProperty { Id = 10, Text = "Ability to leave reviews on the website", SubscriptionId = 3 },
        new SubscriptionProperty { Id = 11, Text = "Ability to purchase items", SubscriptionId = 3 },
        new SubscriptionProperty
            { Id = 12, Text = "Ability to sell items (up to 10 items at a time)", SubscriptionId = 3 },
        new SubscriptionProperty { Id = 13, Text = "Commission for selling each item - 15%", SubscriptionId = 3 },

        new SubscriptionProperty { Id = 14, Text = "Возможность оставлять комментарии к постам", SubscriptionId = 4 },
        new SubscriptionProperty { Id = 15, Text = "Возможность оставлять отзывы на сайте", SubscriptionId = 4 },
        new SubscriptionProperty { Id = 16, Text = "Возможность покупки предметов", SubscriptionId = 4 },

        new SubscriptionProperty { Id = 17, Text = "Возможность оставлять комментарии к постам", SubscriptionId = 5 },
        new SubscriptionProperty { Id = 18, Text = "Возможность оставлять отзывы на сайте", SubscriptionId = 5 },
        new SubscriptionProperty { Id = 19, Text = "Возможность покупки предметов", SubscriptionId = 5 },
        new SubscriptionProperty
            { Id = 20, Text = "Возможность продажи предметов (не более 5шт. за раз)", SubscriptionId = 5 },
        new SubscriptionProperty { Id = 21, Text = "Комиссия за продажу каждого предмета - 30%", SubscriptionId = 5 },

        new SubscriptionProperty { Id = 22, Text = "Возможность оставлять комментарии к постам", SubscriptionId = 6 },
        new SubscriptionProperty { Id = 23, Text = "Возможность оставлять отзывы на сайте", SubscriptionId = 6 },
        new SubscriptionProperty { Id = 24, Text = "Возможность покупки предметов", SubscriptionId = 6 },
        new SubscriptionProperty
            { Id = 25, Text = "Возможность продажи предметов (не более 10шт. за раз)", SubscriptionId = 6 },
        new SubscriptionProperty { Id = 26, Text = "Комиссия за продажу каждого предмета - 15%", SubscriptionId = 6 },
    ];
}