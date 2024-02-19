using Doors2Heaven.Data;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Doors2Heaven.Models
{
    public class DoorsContext : ApplicationDbContext
    {
        public DoorsContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Doors> Doors { get; set; }
    }
    public class Doors
    {
        public int Id { get; set; }
        public string? Types_of_Door { get; set; }
        public string? Style_of_Door { get; set; }
        public string? Features { get; set; }
        public decimal Price { get; set; }
        public string? Material { get; set; }
        public string? Ratings { get; set; }
    }
}
