namespace Api.ViewModels
{
    public class DocumentResponse
    {
        public byte[] BinaryFile { get; set; }
        
        public string FileName { get; set; }
        
        public string ApplicationFormat { get; set; }
    }
}