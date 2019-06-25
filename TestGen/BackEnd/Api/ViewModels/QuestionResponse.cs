namespace Api.ViewModels
{
    public class QuestionResponse
    {
        
        public string Title { get; set; }
        
        public string Options { get; set; }

        public int QuestionTypeId { get; set; }
        
        public string Answer { get; set; }
        
        public int SectionId { get; set; }
        
    }
}