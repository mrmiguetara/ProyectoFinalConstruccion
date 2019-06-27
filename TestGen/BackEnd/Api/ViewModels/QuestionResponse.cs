namespace Api.ViewModels
{
    public class QuestionResponse
    {
        
        public int Id { get; set; }
        
        public string Title { get; set; }
        
        public string Options { get; set; }

        public int QuestionTypeId { get; set; }
        
        public string Answer { get; set; }
        
        public int SectionId { get; set; }
        
    }
}