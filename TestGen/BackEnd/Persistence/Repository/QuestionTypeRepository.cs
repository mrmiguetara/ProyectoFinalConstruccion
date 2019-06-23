using Core.Models;
using Core.Repository;

namespace Persistence.Repository
{
    public class QuestionTypeRepository : BaseRepository<QuestionType>, IQuestionTypeRepository
    {
        public QuestionTypeRepository(GeneratorDbContext context) : base(context) {}
    }
}