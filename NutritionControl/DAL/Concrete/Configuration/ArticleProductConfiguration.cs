using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NutritionControl.DAL.Concrete.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NutritionControl.DAL.Concrete.Configuration
{
    public class ArticleProductConfiguration : IEntityTypeConfiguration<ArticleProduct>
    {
        public void Configure(EntityTypeBuilder<ArticleProduct> builder)
        {
            builder.HasKey(x => new { x.ProductId, x.ArticleId });

            builder.HasOne(x => x.Article)
                .WithMany(x => x.Products)
                .HasForeignKey(x => x.ArticleId);

            builder.HasOne(x => x.Product)
                .WithMany(x => x.Articles)
                .HasForeignKey(x => x.ProductId);
        }
    }
}
