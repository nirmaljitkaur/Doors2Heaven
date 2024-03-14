using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Doors2Heaven.Models;

namespace Doors2Heaven.Data
{
    public class Doors2HeavenContext : DbContext
    {
        public Doors2HeavenContext (DbContextOptions<Doors2HeavenContext> options)
            : base(options)
        {
        }

        public DbSet<Doors2Heaven.Models.Doors> Doors { get; set; } = default!;
        public DbSet<Doors2Heaven.Models.User> Users { get; set; }
    }
}
