using System.Collections.Generic;

namespace NutritionControl.DAL.Concrete.Entities
{
    public class AuthorizedUser
    {
        public AuthorizedUser()
        {
            SavedProducts = new List<ProductAuthUser>();
            SavedReceipts = new List<ReceiptAuthUser>();
        }
        public int Id { get; set; }
        public string IdentityId { get; set; }
        public User Identity { get; set; }  // navigation property
        public int? PsysiologyInfoId { get; set; }
        public virtual PhysiologyInfo PhysiologyInfo { get; set; }
        public virtual ICollection<ProductAuthUser> SavedProducts { get; set; }
        public virtual ICollection<ReceiptAuthUser> SavedReceipts { get; set; }
        public int? DiaryId { get; set; }
        public virtual Diary Diary { get; set; }
    }
}