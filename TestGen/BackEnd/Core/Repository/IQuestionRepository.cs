using System.Collections.Generic;
using Core.Models;

namespace Core.Repository
{
    public interface IQuestionRepository : IGenericRepository<Question>
    {
        ISet<Question> GetQuestionsForSection(int sectionId);

        void DeleteQuestionsForSection(int sectionId);

        void DeleteQuestionsForExam(int examId);
    }
}