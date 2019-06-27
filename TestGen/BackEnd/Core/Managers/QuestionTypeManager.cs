using Core.Models;
using Core.Repository;

namespace Core.Managers
{
    public class QuestionTypeManager
    {

        private readonly IQuestionTypeRepository _questionTypeRepository;

        public QuestionTypeManager(IQuestionTypeRepository questionTypeRepository)
        {
            _questionTypeRepository = questionTypeRepository;
        }

        public QuestionType GetQuestionTypeById(int id) => _questionTypeRepository.Find(id);
    }
}