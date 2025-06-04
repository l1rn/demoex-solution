using System.ComponentModel.DataAnnotations;

namespace application.models.product
{
    public class Product
    {
        public int id { get; set; }
        public string name { get; set; } = null!;
        public int needMaterial { get; set; }

        public Material material { get; set; } = null!;
        public ProductType productType { get; set; } = null!;
    }
}
