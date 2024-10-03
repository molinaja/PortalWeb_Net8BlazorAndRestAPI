using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace Portal.DataAccess
{
    public class PortalDbContext : DbContext
    {

        public PortalDbContext(DbContextOptions<PortalDbContext> options) : base(options)
        {

        }
    }
}
