using System.Collections.Generic;

namespace NutritionControl.DAL.Concrete.Entities
{
    public class Diary
    {
        public Diary()
        {
            DaysInfo = new List<DayInfo>();
        }
        public int Id { get; set; }
        public int? AuthorizedUserId { get; set; }
        public virtual AuthorizedUser AuthorizedUser { get; set; }
        public virtual ICollection<DayInfo> DaysInfo { get; set; }
    }
}