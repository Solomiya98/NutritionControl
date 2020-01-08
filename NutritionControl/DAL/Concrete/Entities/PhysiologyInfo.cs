namespace NutritionControl.DAL.Concrete.Entities
{
    public class PhysiologyInfo
    {
        public int Id { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }
        public double BMI { get; set; }
        public double GoalWeight { get; set; }
        public string Gender { get; set; }
        public int? AuthorizedUserId { get; set; }
        public virtual AuthorizedUser AuthorizedUser { get; set; }
    }
}