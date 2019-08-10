using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NutritionControl.DAL.Concrete.Entities
{
    public class User : IdentityUser
    {
        // Extended Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long? FacebookId { get; set; }
        public string PictureUrl { get; set; }
    }
}
