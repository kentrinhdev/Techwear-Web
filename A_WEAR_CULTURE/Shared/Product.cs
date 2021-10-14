using System;
namespace A_WEAR_CULTURE.Shared
{
    public class Product
    {
        public int          ProductID { get; set; }
        public int          CategoryID { get; set; }
        public Category     ProductCategory { get; set; }
        public string       ProductImage { get; set; } = "https://mobilebytes.com/wp-content/uploads/2017/10/ef3-placeholder-image.jpg";
        public string       ProductName { get; set; }
        public string       CodeName { get; set; }
        public string       ProductDesigner { get; set; }
        public string       ProductDescription { get; set; }
        public string       ProductDescriptionFull { get; set; }
        public string       ProductColor { get; set; }
        public decimal      ProductPrice { get; set; }
        public string       PromotionDescription { get; set; }
        public decimal      PromotionRate { get; set; }
        public decimal      PromotionPrice { get; set; }
        public string       ProductURL { get; set; }
        public bool         IsInStock { get; set; }
        public bool         IsDeleted { get; set; }
        public DateTime     DateReleased { get; set; } = DateTime.Now;
        public DateTime     DateRefreshed { get; set; }
        public DateTime     DateDeleted { get; set; }
    }
}
