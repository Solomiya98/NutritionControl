using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NutritionControl.DAL.Concrete.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NutritionControl.DAL.Concrete.Configuration.InitialConfig
{
    public class ProductInitConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            int productId = 1;
            Product[] products = new Product[]
            {
                #region alcohol
                new Product
                {
                    Id =productId++,
                    CategoryId = 1,

                    Name = "Brandy 40%",
                    CaloriesValue = 225,
                    Protein = 0.0,
                    Fats = 0.0,
                    Carbohydrates = 0.5
                },
                new Product
                {
                    Id =productId++,
                    CategoryId = 1,
                    Name = "Vermouth 13%",
                    CaloriesValue = 158,
                    Protein = 0.0,
                    Fats = 0.0,
                    Carbohydrates = 15.9
                },
                new Product
                {
                    Id =productId++,
                    CategoryId = 1,
                    Name = "Semi-sweet white wine",
                    CaloriesValue = 92,
                    Protein = 0.0,
                    Fats = 0.0,
                    Carbohydrates = 4.4
                },
                new Product
                {
                    Id =productId++,
                    CategoryId = 1,
                    Name = "Semi-dry white wine",
                    CaloriesValue = 78,
                    Protein = 0.0,
                    Fats = 0.0,
                    Carbohydrates = 3.7
                },
                new Product
                {
                    Id =productId++,
                    CategoryId = 1,
                    Name = "Dry white wine",
                    CaloriesValue = 73,
                    Protein = 0.0,
                    Fats = 0.0,
                    Carbohydrates = 2.4
                },
                new Product
                {
                    Id =productId++,
                    CategoryId = 1,
                    Name = "Semi-sweet red wine",
                    CaloriesValue = 96,
                    Protein = 0.0,
                    Fats = 0.0,
                    Carbohydrates = 5.5
                },
                new Product
                {
                    Id =productId++,
                    CategoryId = 1,
                    Name = "Sweet red wine",
                    CaloriesValue = 106,
                    Protein = 0.0,
                    Fats = 0.0,
                    Carbohydrates = 8.2
                },
                new Product
                {
                    Id =productId++,
                    CategoryId = 1,
                    Name = "Dry red wine",
                    CaloriesValue = 75,
                    Protein = 0.0,
                    Fats = 0.0,
                    Carbohydrates = 3.0
                },
                new Product
                {
                    Id =productId++,
                    CategoryId = 1,
                    Name = "Whiskey 40%",
                    CaloriesValue = 220,
                    Protein = 0.0,
                    Fats = 0.0,
                    Carbohydrates = 0.0
                },
                new Product
                {
                    Id =productId++,
                    CategoryId = 1,
                    Name = "Vodka 40%",
                    CaloriesValue = 235,
                    Protein = 0.0,
                    Fats = 0.0,
                    Carbohydrates = 0.1
                },
                new Product
                {
                    Id =productId++,
                    CategoryId = 1,
                    Name = "Gin 40%",
                    CaloriesValue = 220,
                    Protein = 0.0,
                    Fats = 0.0,
                    Carbohydrates = 0.0
                },
                new Product
                {
                    Id =productId++,
                    CategoryId = 1,
                    Name = "Cognac 40%",
                    CaloriesValue = 239,
                    Protein = 0.0,
                    Fats = 0.0,
                    Carbohydrates = 0.1
                },
                new Product
                {
                    Id =productId++,
                    CategoryId = 1,
                    Name = "Advocaat",
                    CaloriesValue = 280,
                    Protein = 4.4,
                    Fats = 6.0,
                    Carbohydrates = 28.4
                },
                new Product
                {
                    Id =productId++,
                    CategoryId = 1,
                    Name = "Liqueur 24%",
                    CaloriesValue = 345,
                    Protein = 0.0,
                    Fats = 0.0,
                    Carbohydrates = 53.0
                },
                new Product
                {
                    Id =productId++,
                    CategoryId = 1,
                    Name = "Madera 18%",
                    CaloriesValue = 139,
                    Protein = 0.0,
                    Fats = 0.0,
                    Carbohydrates = 10.0
                },
                new Product
                {
                    Id =productId++,
                    CategoryId = 1,
                    Name = "Non-alcoholic beer",
                    CaloriesValue = 27,
                    Protein = 0.2,
                    Fats = 0.0,
                    Carbohydrates = 5.2
                },
                new Product
                {
                    Id =productId++,
                    CategoryId = 1,
                    Name = "Dark beer",
                    CaloriesValue = 48,
                    Protein = 0.3,
                    Fats = 0.0,
                    Carbohydrates = 5.7
                },
                new Product
                {
                    Id =productId++,
                    CategoryId = 1,
                    Name = "Light beer",
                    CaloriesValue = 42,
                    Protein = 0.3,
                    Fats = 0.0,
                    Carbohydrates = 4.6
                },
                new Product
                {
                    Id =productId++,
                    CategoryId = 1,
                    Name = "Port 20%",
                    CaloriesValue = 167,
                    Protein = 0.0,
                    Fats = 0.0,
                    Carbohydrates = 13.7
                },
                new Product
                {
                    Id =productId++,
                    CategoryId = 1,
                    Name = "Rum 40%",
                    CaloriesValue = 220,
                    Protein = 0.0,
                    Fats = 0.0,
                    Carbohydrates = 0.0
                },
                new Product
                {
                    Id =productId++,
                    CategoryId = 1,
                    Name = "Champagne semi-sweet",
                    CaloriesValue = 97,
                    Protein = 0.2,
                    Fats = 0.0,
                    Carbohydrates = 7.0
                },
                new Product
                {
                    Id =productId++,
                    CategoryId = 1,
                    Name = "Champagne semi-dry",
                    CaloriesValue = 83,
                    Protein = 0.1,
                    Fats = 0.0,
                    Carbohydrates = 3.4
                },
                new Product
                {
                    Id =productId++,
                    CategoryId = 1,
                    Name = "Champagne sweet",
                    CaloriesValue = 117,
                    Protein = 0.2,
                    Fats = 0.0,
                    Carbohydrates = 12.0
                },
                #endregion

                #region Breads & cereals
                new Product
                {
                    Id =productId++,
                    CategoryId = 2,
                    Name = "",
                }
                #endregion
            };
            builder.HasData(products);
        }
    }
}
