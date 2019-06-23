using Core.Models;
using Core.Repository;

namespace Core.Managers
{
    public sealed class ExamManager
    {
        private readonly IExamRepository _examRepository;
        public ExamManager(IExamRepository examRepository)
        {
            _examRepository = examRepository;
        }


        public void AddExam(Exam exam)
        {
            _examRepository.Create(exam);
            
            _examRepository.Save();
        }
    }
}