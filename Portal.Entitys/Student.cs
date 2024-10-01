using Portal.Entities;

namespace Portal.Entitys
{
    public class Student : Base
    {
        public string DocumentoNumber { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Province { get; set; }
        public string District { get; set; }
        public string Canton { get; set; }
        public DateTime ExpireDate { get; set; }


    }
}
