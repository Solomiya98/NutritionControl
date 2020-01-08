namespace NutritionControl.DAL.Concrete.Entities
{
    public class ProductPerIntake
    {
        public int Id { get; set; }
        public double WeightOfProduct { get; set; }
        public int TotalCalories { get; set; }
        public int? ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}