using System.Collections.Generic;
using System.Linq;
using Core.Helpers;
using Core.Models;
using Core.Repository;

namespace Persistence.Repository
{
    public class SectionRepository : BaseRepository<Section>, ISectionRepository
    {
        private readonly GeneratorDbContext _context;

        public SectionRepository(GeneratorDbContext context) : base(context)
        {
            _context = context;
        }

        public ISet<Section> GetSectionsForExam(int examId)
        {
            return FindAll(section => section.ExamId == examId);
        }

        public void DeleteSectionsForExam(int examId)
        {
            var sections = _context.Sections.Where(section => section.ExamId == examId);
            
            _context.RemoveRange(sections);
            
        }
    }
}