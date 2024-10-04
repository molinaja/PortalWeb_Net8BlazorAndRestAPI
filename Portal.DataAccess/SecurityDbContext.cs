using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.DataAccess
{
    public class SecurityDbContext : IdentityDbContext<PortalIdentityUser>
    {
        public SecurityDbContext(DbContextOptions<SecurityDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<PortalIdentityUser>(e =>
            {
                e.ToTable("User");
                //e.Property(p => p.LockoutEnd).HasColumnName("BloqueoHasta");
                //e.Property(p => p.AccessFailedCount).HasColumnName("NroIntentos");
            });

            builder.Entity<IdentityRole>(e => e.ToTable("Role"));
            builder.Entity<IdentityUserRole<string>>(e => e.ToTable("UserRole"));
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            base.ConfigureConventions(configurationBuilder);

            configurationBuilder.Properties<string>().HaveMaxLength(150);
        }

    }
} 