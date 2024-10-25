using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.Shared.Request
{
    public class CategoryDTORequest
    {
        [Required(ErrorMessage = Cons.RequiredField)]
        [StringLength(100, ErrorMessage = Cons.MaxLengthField)]
        public string Name { get; set; } = default!;
    }
}
