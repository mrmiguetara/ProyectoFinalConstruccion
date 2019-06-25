using System.Collections.Generic;
using Core.Models;

namespace Api.ViewModels
{
    public class ExamResponse
    {
        public string Subject { get; set; }
        
        public string Teacher { get; set; }
        
        public virtual List<SectionResponse> Sections { get; set; }
    }
}