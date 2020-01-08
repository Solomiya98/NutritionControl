using System.Collections.Generic;

namespace NutritionControl.DAL.Concrete.Entities
{
    public class Product
    { 
        public Product()
        {
            Articles = new List<ArticleProduct>();
            Receipts = new List<ProductReceipt>();
            Intakes = new List<ProductPerIntake>();
            AuthUsers = new List<ProductAuthUser>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhotoUrl { get; set; }
        public int CaloriesValue { get; set; }
        public double Protein { get; set; }
        public double Fats { get; set; }
        public double Carbohydrates { get; set; }
        public int? CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<ArticleProduct> Articles { get; set; }
        public virtual ICollection<ProductReceipt> Receipts { get; set; }
        public virtual ICollection<ProductPerIntake> Intakes { get; set; }
        public virtual ICollection<ProductAuthUser> AuthUsers { get; set; }
    }
}