using Core.Models;
using Core.Repository;

namespace Persistence.Repository
{
        public class QuestionRepository : BaseRepository<Question>, IQuestionRepository
        {
            public QuestionRepository(GeneratorDbContext context) : base(context)
            {
            
            }
        }
    
}