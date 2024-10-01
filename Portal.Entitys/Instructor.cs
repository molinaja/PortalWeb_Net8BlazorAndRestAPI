using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.Entities
{
    public class Instructor : Base
    {
        public int Name { get; set; }
        public int DocumentNumber { get; set; }
        public Category Category { get; set; }     
        public int CategoryId { get; set; }


    }
}
