using System.Linq;
using Core.Models;
using Core.Repository;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Repository
{
    public class ExamRepository : BaseRepository<Exam>, IExamRepository
    {
        private readonly GeneratorDbContext _context;
        private readonly DbSet<Exam> _exams;
        public ExamRepository(GeneratorDbContext context) : base(context)
        {
            _context = context;
            _exams = context.Exams;
        }


        public Exam GetExamWithSections(int id)
        {
            Exam completeExam = Find(id);
            
            return completeExam;
        }
    }
}