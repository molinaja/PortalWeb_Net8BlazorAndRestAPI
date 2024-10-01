using Portal.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.Entities
{
    public class Registration : Base
    {
        public Student Student { get; set; } = default!;
        public int StudentId { get; set; }
        public Worksho Workshop { get; set; } = default!;
        public int WorkshopId { get; set; }
        public RegistrationSituation Situation { get; set; }

    }
}
