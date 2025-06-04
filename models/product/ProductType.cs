using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application.models.product
{
    public class ProductType
    {
        public int id { get; set; }
        public string name { get; set; } = null!;
        public double cofficient { get; set; }
    }
}
