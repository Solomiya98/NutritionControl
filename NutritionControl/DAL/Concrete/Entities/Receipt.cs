using System.Collections.Generic;

namespace NutritionControl.DAL.Concrete.Entities
{
    public class Receipt
    {
        public Receipt()
        {
            Products = new List<ProductReceipt>();
            AuthUsers = new List<ReceiptAuthUser>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        
        public int CaloriesValue { get; set; }
        public string Description { get; set; }
        public virtual ICollection<ProductReceipt> Products { get; set; }
        public virtual ICollection<ReceiptAuthUser> AuthUsers { get; set; }
    }
}