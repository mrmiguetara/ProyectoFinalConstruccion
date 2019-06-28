
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Models
{
    /// <summary>
    /// Represents an Exam
    /// </summary>
    public class Exam: BaseEntity
    {
        
        public string Subject { get; set; }
        
        public string Teacher { get; set; }
        
        public int UserId { get; set; }
        
        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }
        
        public virtual IEnumerable<Section> Sections { get; set; }
        
    }
}