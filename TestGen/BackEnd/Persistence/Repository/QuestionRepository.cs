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

            public Question GetQuestionByIdAndSection(int questionId, int sectionId)
            {
                return _context.Questions.FirstOrDefault(question =>
                    question.Id == questionId && question.SectionId == sectionId);
            }

            public void DeleteQuestionsForSection(int sectionId)
            {
                var questions = FindAll(question => question.SectionId == sectionId);
                
                _context.RemoveRange(questions);
            }

            public void DeleteQuestionsForExam(int examId)
            {
                var questions = _context.Sections.Where(section => section.ExamId == examId)
                    .SelectMany(section => section.Questions).ToList();
                    
                _context.RemoveRange(questions);
            }
        }
    
}