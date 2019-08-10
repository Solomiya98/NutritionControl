using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NutritionControl.DAL.Concrete.Entities
{
    public class Article
    {
        public Article()
        {
            Products = new List<ArticleProduct>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public DateTime DateOfPublication { get; set; }
        public virtual ICollection<ArticleProduct> Products { get; set; }//MentionedProducts { get; set; }

    }
}
