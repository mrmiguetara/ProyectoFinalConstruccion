using System.Collections.Generic;

namespace Api.ViewModels
{
    public class SectionResponse
    {
        public int Id { get; set; }
        
        public string Instruction { get; set; }
        
        public virtual List<QuestionResponse> Questions { get; set; }
    }
}