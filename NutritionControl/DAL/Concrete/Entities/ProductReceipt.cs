namespace NutritionControl.DAL.Concrete.Entities
{
    public class ProductReceipt
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int ReceiptId { get; set; }
        public virtual Receipt Receipt { get; set; }
    }
}