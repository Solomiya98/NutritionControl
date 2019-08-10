using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NutritionControl.DAL.Concrete.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NutritionControl.DAL.Concrete.Configuration
{
    public class ReceiptAuthUserConfiguration : IEntityTypeConfiguration<ReceiptAuthUser>
    {
        public void Configure(EntityTypeBuilder<ReceiptAuthUser> builder)
        {
            builder.HasKey(x => new { x.ReceiptId, x.AuthUserId });

            builder.HasOne(x => x.Receipt)
                .WithMany(x => x.AuthUsers)
                .HasForeignKey(x => x.ReceiptId);

            builder.HasOne(x => x.AuthUser)
                .WithMany(x => x.SavedReceipts)
                .HasForeignKey(x => x.AuthUserId);
        }
    }
}
