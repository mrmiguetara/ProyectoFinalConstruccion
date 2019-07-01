using System.Collections.Generic;
using Core.Models;

namespace Api.ViewModels
{
    public class ExamResponse
    {
        public int Id { get; set; }
        
        public string Subject { get; set; }
        
        public string Teacher { get; set; }
        
        public int UserId { get; set; }

        public UserResponse User { get; set; }
        
        public virtual List<SectionResponse> Sections { get; set; }
    }
}