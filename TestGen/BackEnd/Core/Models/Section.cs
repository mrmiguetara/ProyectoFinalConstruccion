using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Core.Models
{
    public class Section: BaseEntity
    {
        [Required]
        public string Instruction { get; set; }
        
        public int ExamId { get; set; }
        
        public Exam Exam { get; set; }
        
        public virtual IEnumerable<Question> Questions { get; set; }
    }
}