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
            return _context.Sections.ToHashSet();    
        }
        
    }
}