
using System.Collections;
using System.Collections.Generic;

namespace Core.Models
{
    /// <summary>
    /// Represents an Exam
    /// </summary>
    public class Exam: BaseEntity
    {
        
        public string Subject { get; set; }
        
        public string Teacher { get; set; }
        
        public virtual IEnumerable<Section> Sections { get; set; }
        
    }
}