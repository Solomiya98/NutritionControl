using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NutritionControl.DAL.Concrete.Entities
{
    public class ReceiptAuthUser
    {
        public int Id { get; set; }
        public int ReceiptId { get; set; }
        public virtual Receipt Receipt { get; set; }
        public int AuthUserId { get; set; }
        public virtual AuthorizedUser AuthUser { get; set; }
    }
}
