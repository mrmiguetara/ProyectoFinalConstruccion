using System.ComponentModel.DataAnnotations;
using Core.Models;

namespace Api.ViewModels
{
    public class QuestionRequest
    {
        public int Id { get; set; }
        
        public string Title { get; set; }
        
        public string Options { get; set; }
        
        public int QuestionTypeId { get; set; }
        
        public string Answer { get; set; }
        
        public int SectionId { get; set; }
        
    }
}