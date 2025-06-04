using application.models.partner;
using application.models.product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application.models.sales
{
    public class SalesForPartner
    {
        public int id { get; set; }
        public string date { get; set; } = null!;
        public Product product { get; set; } = null!;
        public Partner partner { get; set; } = null!;
        public int quantity { get; set; }
    }
}
