using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.Entities.Infos
{
    public class IntructorInfo
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string DocumentNumber { get; set; } = default!;
        public string Category { get; set; } = default!;
        public int CategoryId { get; set; }

    }
}
