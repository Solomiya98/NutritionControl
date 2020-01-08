using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using NutritionControl.DAL.Concrete.Configuration;
using NutritionControl.DAL.Concrete.Configuration.InitialConfig;
using NutritionControl.DAL.Concrete.Entities;

namespace NutritionControl.DAL
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions options)
              : base(options) { }
        public DbSet<AuthorizedUser> AuthorizedUsers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Receipt> Receipts { get; set; }
        public DbSet<PhysiologyInfo> PhysiologyInfos { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<DayInfo> DayInfos { get; set; }
        public DbSet<Diary> Diaries { get; set; }
        public DbSet<FoodIntake> FoodIntakes { get; set; }
        public DbSet<ProductPerIntake> ProductsPerIntake { get; set; }
        public DbSet<ArticleProduct> ArticleProducts { get; set; }
        public DbSet<ProductReceipt> ProductReceipts { get; set; }
        public DbSet<ProductAuthUser> ProductAuthUsers { get; set; }
        public DbSet<ReceiptAuthUser> ReceiptAuthUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ArticleProductConfiguration());
            builder.ApplyConfiguration(new ProductReceiptConfiguration());
            builder.ApplyConfiguration(new ProductAuthUserConfiguration());
            builder.ApplyConfiguration(new ReceiptAuthUserConfiguration());

            //Initial Data Configurations

            builder.ApplyConfiguration(new CategoryInitConfig());
            builder.ApplyConfiguration(new ProductInitConfig());

            base.OnModelCreating(builder);
        }
    }
}