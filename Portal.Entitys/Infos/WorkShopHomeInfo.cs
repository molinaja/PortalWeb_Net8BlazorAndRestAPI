using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.Entities.Infos
{
    public class WorkShopHomeInfo
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public DateOnly InitDate { get; set; }
        public TimeOnly InitHour { get; set; }
        public string? PortalUrl { get; set; }
        public string? SyllabusUrl { get; set; }
        public string? Description { get; set; }
        public string Instructor { get; set; } = default!;

    }
}
