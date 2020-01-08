namespace NutritionControl.DAL.Concrete.Entities
{
    public class ProductAuthUser
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int AuthUserId { get; set; }
        public virtual AuthorizedUser AuthUser { get; set; }
    }
}