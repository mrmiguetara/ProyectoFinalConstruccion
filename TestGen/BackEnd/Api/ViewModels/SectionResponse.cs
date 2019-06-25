using System.Collections.Generic;

namespace Api.ViewModels
{
    public class SectionResponse
    {
        public string Instruction { get; set; }
        
        public virtual List<QuestionResponse> Questions { get; set; }
    }
}