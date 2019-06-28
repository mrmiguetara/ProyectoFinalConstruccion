using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Core.Models
{
    [Table("Users")]
    public class ApplicationUser : IdentityUser<int>
    {
        public virtual IEnumerable<Exam> Exams { get; set; }
    }
}