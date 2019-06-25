using System.Collections.Generic;
using System.Linq;
using Core.Models;
using Core.Repository;

namespace Persistence.Repository
{
        public class QuestionRepository : BaseRepository<Question>, IQuestionRepository
        {
            private readonly GeneratorDbContext _context;
            public QuestionRepository(GeneratorDbContext context) : base(context)
            {
                _context = context;
            }

            public ISet<Question> GetQuestionsForSection(int sectionId)
            {
                return _context.Questions.Where(question => question.SectionId == sectionId).ToHashSet();
            }
        }
    
}