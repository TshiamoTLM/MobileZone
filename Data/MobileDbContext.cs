using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MobileZone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileZone.Data
{
    public class MobileDbContext : IdentityDbContext<IdentityUser>
    {
        public MobileDbContext(DbContextOptions<MobileDbContext> options) : base(options)
        {
        }
        public DbSet<Mobile> Mobiles { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
