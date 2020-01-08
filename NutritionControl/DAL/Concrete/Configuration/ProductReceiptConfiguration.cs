using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NutritionControl.DAL.Concrete.Entities;

namespace NutritionControl.DAL.Concrete.Configuration
{
    public class ProductReceiptConfiguration : IEntityTypeConfiguration<ProductReceipt>
    {
        public void Configure(EntityTypeBuilder<ProductReceipt> builder)
        {
            builder.HasKey(x => new { x.ProductId, x.ReceiptId });

            builder.HasOne(x => x.Product)
                .WithMany(x => x.Receipts)
                .HasForeignKey(x => x.ProductId);

            builder.HasOne(x => x.Receipt)
                .WithMany(x => x.Products)
                .HasForeignKey(x => x.ReceiptId);
        }
    }
}
