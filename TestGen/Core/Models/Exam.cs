using System;
using System.ComponentModel.DataAnnotations;

namespace Core.Models
{
    /// <summary>
    /// Represents an Exam
    /// </summary>
    public class Exam
    {
        public int Id { get; set; }
        
        public string Subject { get; set; }
        
        public string Teacher { get; set; }
        
        public DateTime Created { get; set; }
        
        public DateTime Updated { get; set; }
    }
}