using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NutritionControl.DAL.Concrete.Entities;

namespace NutritionControl.DAL.Concrete.Configuration
{
    public class ProductAuthUserConfiguration : IEntityTypeConfiguration<ProductAuthUser>
    {
        public void Configure(EntityTypeBuilder<ProductAuthUser> builder)
        {
            builder.HasKey(x => new { x.ProductId, x.AuthUserId });

            builder.HasOne(x => x.Product)
                .WithMany(x => x.AuthUsers)
                .HasForeignKey(x => x.ProductId);

            builder.HasOne(x => x.AuthUser)
                .WithMany(x => x.SavedProducts)
                .HasForeignKey(x => x.AuthUserId);
        }
    }
}