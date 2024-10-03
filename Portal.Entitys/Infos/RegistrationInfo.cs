using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.Entities.Infos
{
    public class RegistrationInfo
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string Workshop { get; set; } = default!;
        public string Date { get; set; } = default!;
        public string Situation { get; set; } = default!;

    }
}
