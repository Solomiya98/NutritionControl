using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NutritionControl.DAL.Concrete.Entities;

namespace NutritionControl.DAL.Concrete.Configuration.InitialConfig
{
    public class CategoryInitConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            int categoryId = 1;
            Category[] categories = new Category[]
            {
                new Category
                {
                    Id =categoryId++,
                    Name="Alcoholic Drinks",

                },
                new Category
                {
                    Id =categoryId++,
                    Name="Breads & cereals"
                },
                new Category
                {
                    Id =categoryId++,
                    Name="Meats & Fish"
                },
                new Category
                {
                    Id =categoryId++,
                    Name="Fruits & Vegetables "
                },
                new Category
                {
                    Id =categoryId++,
                    Name="Milk & Dairy produce"
                },
                new Category
                {
                    Id =categoryId++,
                    Name="Fats & Sugars"
                },
                new Category
                {
                    Id =categoryId++,
                    Name="Fruit"
                },
                new Category
                {
                    Id =categoryId++,
                    Name="Vegetables"
                },
                new Category
                {
                    Id =categoryId++,
                    Name="Nuts & Seeds"
                },
                new Category
                {
                    Id =categoryId++,
                    Name="Seafood"
                }
            };
            builder.HasData(categories);
        }
    }
}