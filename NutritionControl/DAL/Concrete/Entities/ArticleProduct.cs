namespace NutritionControl.DAL.Concrete.Entities
{
    public class ArticleProduct
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int ArticleId { get; set; }
        public virtual Article Article { get; set; }
    }
}
