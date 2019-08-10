using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NutritionControl.DAL.Concrete.Entities
{
    public class FoodIntake
    {
        public FoodIntake()
        {
            Products = new List<ProductPerIntake>();
        }
        public int Id { get; set; }
        public DateTime Time { get; set; }  //separate to date and time
        //enum kind of intake (breakfast, lunch, dinner, supper, nosh/snack (перекус)
        public string Description { get; set; }
        public string PhotoUrl { get; set; }
        public int CaloriesValue { get; set; }
        public int? DayInfoId { get; set; }
        public virtual DayInfo Day { get; set; }
        public virtual ICollection<ProductPerIntake> Products { get; set; }
    }
}
