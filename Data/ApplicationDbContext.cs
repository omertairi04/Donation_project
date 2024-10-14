using D_Project.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace D_Project.Data;

public class ApplicationDbContext : IdentityDbContext<AppUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        // ROLES
        var admin = new IdentityRole("Admin");
        admin.NormalizedName = "ADMIN";

        var client = new IdentityRole("Client");
        client.NormalizedName = "CLIENT";

        var donator = new IdentityRole("Donator");
        donator.NormalizedName = "DONATOR";

        builder.Entity<IdentityRole>().HasData(admin, client, donator);

        // Configure many-to-many relationship
        builder.Entity<ProductSubCategory>()
            .HasKey(ps => new { ps.ProductId, ps.SubCategoryId });

        builder.Entity<ProductSubCategory>()
            .HasOne(ps => ps.Product)
            .WithMany(p => p.ProductSubCategories)
            .HasForeignKey(ps => ps.ProductId);

        builder.Entity<ProductSubCategory>()
            .HasOne(ps => ps.SubCategory)
            .WithMany()
            .HasForeignKey(ps => ps.SubCategoryId);

        /*
         * CREATING CATEGORIES
         */
        var clothing = new MainCategory
        {
            Id = Guid.NewGuid(),
            Name = "Clothing",
            Description = "Apparel and accessories",
            Icon = "wwwroot/images/mainCategories/category.jpg"
        };

        var houseHoldItems = new MainCategory
        {
            Id = Guid.NewGuid(),
            Name = "Household Items",
            Description = "Every day house hold items",
            Icon = "wwwroot/images/mainCategories/category.jpg"
        };

        var electronics = new MainCategory
        {
            Id = Guid.NewGuid(),
            Name = "Electronics",
            Description = "Electronics",
            Icon = "wwwroot/images/mainCategories/category.jpg"
        };
        var booksAndMedia = new MainCategory
        {
            Id = Guid.NewGuid(),
            Name = "Books and Media",
            Description = "Donate your books or medias.",
            Icon = "wwwroot/images/mainCategories/category.jpg"
        };
        var ToysAndGames = new MainCategory
        {
            Id = Guid.NewGuid(),
            Name = "Toys and Games",
            Description = "Donate your Toys and Games.",
            Icon = "wwwroot/images/mainCategories/category.jpg"
        };
        var SportOrFitnessEquipment = new MainCategory
        {
            Id = Guid.NewGuid(),
            Name = "Sports of Fitness Equipment",
            Description = "Donate your sport or fitness equipment.",
            Icon = "wwwroot/images/mainCategories/category.jpg"
        };
        var FoodAndGroceries = new MainCategory
        {
            Id = Guid.NewGuid(),
            Name = "Food and Groceries",
            Description = "Donate your food and groceries.",
            Icon = "wwwroot/images/mainCategories/category.jpg"
        };
        builder.Entity<MainCategory>().HasData(
            clothing,
            houseHoldItems,
            electronics,
            booksAndMedia,
            ToysAndGames,
            SportOrFitnessEquipment,
            FoodAndGroceries
        );
        
        // Subcategories
        var mensClothing = new SubCategory
        {
            Id = Guid.NewGuid(),
            Name = "Men's Clothing",
            Description = "Apparel for men",
            Icon = "wwwroot/images/mainCategories/category.jpg",
            MainCategoryId = clothing.Id
        };

        var womensClothing = new SubCategory
        {
            Id = Guid.NewGuid(),
            Name = "Women's Clothing",
            Description = "Apparel for women",
            Icon = "wwwroot/images/mainCategories/category.jpg",
            MainCategoryId = clothing.Id
        };

        var childrensClothing = new SubCategory
        {
            Id = Guid.NewGuid(),
            Name = "Children's Clothing",
            Description = "Apparel for children",
            Icon = "wwwroot/images/mainCategories/category.jpg",
            MainCategoryId = clothing.Id
        };

        var shoesFootwear = new SubCategory
        {
            Id = Guid.NewGuid(),
            Name = "Shoes & Footwear",
            Description = "Footwear for all",
            Icon = "wwwroot/images/mainCategories/category.jpg",
            MainCategoryId = clothing.Id
        };

        var accessories = new SubCategory
        {
            Id = Guid.NewGuid(),
            Name = "Accessories",
            Description = "Hats, scarves, belts, etc.",
            Icon = "wwwroot/images/mainCategories/category.jpg",
            MainCategoryId = clothing.Id
        };

        var furniture = new SubCategory
        {
            Id = Guid.NewGuid(),
            Name = "Furniture",
            Description = "Household furniture",
            Icon = "wwwroot/images/mainCategories/category.jpg",
            MainCategoryId = houseHoldItems.Id
        };

        var kitchenware = new SubCategory
        {
            Id = Guid.NewGuid(),
            Name = "Kitchenware",
            Description = "Utensils and appliances for the kitchen",
            Icon = "wwwroot/images/mainCategories/category.jpg",
            MainCategoryId = houseHoldItems.Id
        };

        var beddingLinens = new SubCategory
        {
            Id = Guid.NewGuid(),
            Name = "Bedding & Linens",
            Description = "Bedding essentials",
            Icon = "wwwroot/images/mainCategories/category.jpg",
            MainCategoryId = houseHoldItems.Id
        };

        var cleaningSupplies = new SubCategory
        {
            Id = Guid.NewGuid(),
            Name = "Cleaning Supplies",
            Description = "Cleaning essentials",
            Icon = "wwwroot/images/mainCategories/category.jpg",
            MainCategoryId = houseHoldItems.Id
        };

        var homeDecor = new SubCategory
        {
            Id = Guid.NewGuid(),
            Name = "Home Décor",
            Description = "Decorative items for the home",
            Icon = "wwwroot/images/mainCategories/category.jpg",
            MainCategoryId = houseHoldItems.Id
        };

        var computersLaptops = new SubCategory
        {
            Id = Guid.NewGuid(),
            Name = "Computers & Laptops",
            Description = "Computers and laptops",
            Icon = "wwwroot/images/mainCategories/category.jpg",
            MainCategoryId = electronics.Id
        };

        var mobilePhonesTablets = new SubCategory
        {
            Id = Guid.NewGuid(),
            Name = "Mobile Phones & Tablets",
            Description = "Smartphones and tablets",
            Icon = "wwwroot/images/mainCategories/category.jpg",
            MainCategoryId = electronics.Id
        };

        var homeAppliances = new SubCategory
        {
            Id = Guid.NewGuid(),
            Name = "Home Appliances",
            Description = "Appliances for home use",
            Icon = "wwwroot/images/mainCategories/category.jpg",
            MainCategoryId = electronics.Id
        };

        var tvsAudioSystems = new SubCategory
        {
            Id = Guid.NewGuid(),
            Name = "TVs & Audio Systems",
            Description = "Televisions and audio equipment",
            Icon = "wwwroot/images/mainCategories/category.jpg",
            MainCategoryId = electronics.Id
        };

        var books = new SubCategory
        {
            Id = Guid.NewGuid(),
            Name = "Books",
            Description = "Fiction, non-fiction, educational",
            Icon = "wwwroot/images/mainCategories/category.jpg",
            MainCategoryId = booksAndMedia.Id
        };

        var magazines = new SubCategory
        {
            Id = Guid.NewGuid(),
            Name = "Magazines",
            Description = "Various magazines",
            Icon = "wwwroot/images/mainCategories/category.jpg",
            MainCategoryId = booksAndMedia.Id
        };

        var cdsDvdsBlurays = new SubCategory
        {
            Id = Guid.NewGuid(),
            Name = "CDs, DVDs, Blu-rays",
            Description = "Media collection",
            Icon = "wwwroot/images/mainCategories/category.jpg",
            MainCategoryId = booksAndMedia.Id
        };

        var boardGamesPuzzles = new SubCategory
        {
            Id = Guid.NewGuid(),
            Name = "Board Games & Puzzles",
            Description = "Games for fun and challenges",
            Icon = "wwwroot/images/mainCategories/category.jpg",
            MainCategoryId = ToysAndGames.Id
        };

        var babyToddlerToys = new SubCategory
        {
            Id = Guid.NewGuid(),
            Name = "Baby & Toddler Toys",
            Description = "Toys for young children",
            Icon = "wwwroot/images/mainCategories/category.jpg",
            MainCategoryId = ToysAndGames.Id
        };

        var educationalToys = new SubCategory
        {
            Id = Guid.NewGuid(),
            Name = "Educational Toys",
            Description = "Toys that promote learning",
            Icon = "wwwroot/images/mainCategories/category.jpg",
            MainCategoryId = ToysAndGames.Id
        };

        var videoGamesConsoles = new SubCategory
        {
            Id = Guid.NewGuid(),
            Name = "Video Games & Consoles",
            Description = "Gaming systems and games",
            Icon = "wwwroot/images/mainCategories/category.jpg",
            MainCategoryId = ToysAndGames.Id
        };

        var gymEquipment = new SubCategory
        {
            Id = Guid.NewGuid(),
            Name = "Gym Equipment",
            Description = "Equipment for gym workouts",
            Icon = "wwwroot/images/mainCategories/category.jpg",
            MainCategoryId = SportOrFitnessEquipment.Id
        };

        var sportsGear = new SubCategory
        {
            Id = Guid.NewGuid(),
            Name = "Sports Gear",
            Description = "Gear for various sports",
            Icon = "wwwroot/images/mainCategories/category.jpg",
            MainCategoryId = SportOrFitnessEquipment.Id
        };

        var bicyclesScooters = new SubCategory
        {
            Id = Guid.NewGuid(),
            Name = "Bicycles & Scooters",
            Description = "Bicycles and scooters for all ages",
            Icon = "wwwroot/images/mainCategories/category.jpg",
            MainCategoryId = SportOrFitnessEquipment.Id
        };

        var campingOutdoorGear = new SubCategory
        {
            Id = Guid.NewGuid(),
            Name = "Camping & Outdoor Gear",
            Description = "Equipment for outdoor activities",
            Icon = "wwwroot/images/mainCategories/category.jpg",
            MainCategoryId = SportOrFitnessEquipment.Id
        };
        var cannedGoods = new SubCategory
        {
            Id = Guid.NewGuid(),
            Name = "Canned Goods",
            Description = "Canned food items",
            Icon = "wwwroot/images/mainCategories/category.jpg",
            MainCategoryId = FoodAndGroceries.Id
        };

        var nonPerishableItems = new SubCategory
        {
            Id = Guid.NewGuid(),
            Name = "Non-Perishable Items",
            Description = "Non-perishable food products",
            Icon = "wwwroot/images/mainCategories/category.jpg",
            MainCategoryId = FoodAndGroceries.Id
        };

        var babyFoodFormula = new SubCategory
        {
            Id = Guid.NewGuid(),
            Name = "Baby Food & Formula",
            Description = "Food and formula for infants",
            Icon = "wwwroot/images/mainCategories/category.jpg",
            MainCategoryId = FoodAndGroceries.Id
        };

        // Add to the model builder
        builder.Entity<SubCategory>().HasData(
            mensClothing,
            womensClothing,
            childrensClothing,
            shoesFootwear,
            accessories,
            furniture,
            kitchenware,
            beddingLinens,
            cleaningSupplies,
            homeDecor,
            computersLaptops,
            mobilePhonesTablets,
            homeAppliances,
            tvsAudioSystems,
            books,
            magazines,
            cdsDvdsBlurays,
            boardGamesPuzzles,
            babyToddlerToys,
            educationalToys,
            videoGamesConsoles,
            gymEquipment,
            sportsGear,
            bicyclesScooters,
            campingOutdoorGear,
            cannedGoods,
            nonPerishableItems,
            babyFoodFormula
        );
    }
}