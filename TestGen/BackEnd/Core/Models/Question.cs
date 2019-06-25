using System.ComponentModel.DataAnnotations;

namespace Core.Models
{
    public class Question : BaseEntity
    {
        [Required]
        public string Title { get; set; }
        
        public string Options { get; set; }
        
        [Required]
        public int QuestionTypeId { get; set; }
        
        public QuestionType QuestionType { get; set; }
        
        public string Answer { get; set; }
        
        [Required]
        public int SectionId { get; set; }
        
        public Section Section { get; set; }
    }
}