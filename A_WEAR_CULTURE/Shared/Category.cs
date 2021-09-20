using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_WEAR_CULTURE.Shared
{
    public class Category
    {
        public int              CategoryID { get; set; }
        public string           CategoryIcon { get; set; }
        public string           CategoryName { get; set; }
        public string           CategoryDescription { get; set; }
        public string           CategoryURL { get; set; }
        public List<Product>    CategoryProducts { get; set; }
    }
}
