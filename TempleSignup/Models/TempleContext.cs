using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TempleSignup.Models
{
    public class TempleContext : DbContext
    {
        public TempleContext (DbContextOptions<TempleContext> options) : base(options)
        {

        }

        public DbSet<TempleModel> responses { get; set; }
    }
}
