using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.Entities.Infos
{
    public class RegisteredPerWorkshop
    {
        public int Id { get; set; }
        public string Workshop { get; set; } = default!;
        public string Category { get; set; } = default!;
        public string Instructor { get; set; } = default!;
        public string Date { get; set; } = default!;
        public string Situation { get; set; } = default!;
        public int NumberStudents { get; set; }

    }
}
