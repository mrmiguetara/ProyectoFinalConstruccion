using Core.Models;

namespace Core.Repository
{
    public interface IExamRepository : IGenericRepository<Exam>
    {
        Exam GetExamWithSections(int id);
    }
}