using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.Entities.Infos
{
    public class WorkShopInfo
    {
        public int ID { get; set; }
        public string Name { get; set; } = default!;
        public string Category { get; set; } = default!;
        public int Instructor { get; set; }
        public DateOnly Date { get; set; }
        public string Situation { get; set; } = default!;

    }
}
