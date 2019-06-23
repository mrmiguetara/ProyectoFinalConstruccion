using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Core.Models
{
    public class QuestionType : BaseEntity
    {
        [Required]
        public string Type { get; set; }
        
        public virtual IEnumerable<Question> Questions { get; set; }
    }
}