using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Doors2Heaven.Models
{
    public class User : IdentityUser
    {
        public string Name { get; set; }
        public string Address { get; set; }  
        public string State { get; set; }
        [NotMapped]
        public string Role { get; set; }
    }
}
