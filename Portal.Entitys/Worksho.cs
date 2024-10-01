using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.Entities
{
    public class Worksho : Base
    {
        public string Name { get; set; } = default!;
        public Category Category { get; set; } = default!;
        public int CategoryId { get; set; }
        public Instructor Instructor { get; set; } = default!;
        public int InstructorId { get; set; }
        public DateOnly InitDate { get; set; }
        public TimeOnly InitHour { get; set; }
        public WorkShopSituation Situation { get; set; }
        public string? PortalUrl { get; set; }
        public string? SyllabusUrl { get; set; }
        public string? Description { get; set; }

    }


}

