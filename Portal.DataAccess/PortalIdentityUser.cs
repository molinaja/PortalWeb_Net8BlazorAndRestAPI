using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.DataAccess
{
    public class PortalIdentityUser : IdentityUser
    {
        public string FullName { get; set; } = default!;
    }
}
