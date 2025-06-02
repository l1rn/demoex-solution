using System.ComponentModel.DataAnnotations;

namespace application.models.product
{
    class Product
    {
        int id { get; set; }
        string name { get; set; } = null!;
        int quantity { get; set; }

        
    }
}
