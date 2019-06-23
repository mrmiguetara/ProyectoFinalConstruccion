using Core.Models;
using Core.Repository;

namespace Persistence.Repository
{
    public class ExamRepository : BaseRepository<Exam>, IExamRepository
    {
        public ExamRepository(GeneratorDbContext context) : base(context)
        {
            
        }
    }
}