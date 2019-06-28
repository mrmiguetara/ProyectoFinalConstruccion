using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Core.Models
{
    [Table("Users")]
    public class ApplicationUser : IdentityUser<int>
    {
        
    }
}