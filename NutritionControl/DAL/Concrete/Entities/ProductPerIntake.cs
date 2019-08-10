using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
