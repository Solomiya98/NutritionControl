using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NutritionControl.DAL.Concrete.Entities
{
    public class DayInfo
    {
        public DayInfo()
        {
            Intakes = new List<FoodIntake>();
        }
        public int Id { get; set; }
        public double? CurrentWeight { get; set; }
        public double WaterValue { get; set; }
        public DateTime Date { get; set; }
        public virtual ICollection<FoodIntake> Intakes { get; set; }
    }
}
