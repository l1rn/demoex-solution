using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application.models.partner
{
    public class PartnerType
    {
        public int id { get; set; }
        public string? name { get; set; }

        public List<Partner> Partners { get; set; } = new();
    }
}
