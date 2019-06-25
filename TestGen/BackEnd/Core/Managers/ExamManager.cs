using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Core.Models;
using Core.Repository;

namespace Core.Managers
{
    public sealed class ExamManager
    {
        private readonly IExamRepository _examRepository;
        private readonly ISectionRepository _sectionRepository;
        private readonly IQuestionRepository _questionRepository;
        public ExamManager(
            IExamRepository examRepository,
            ISectionRepository sectionRepository,
            IQuestionRepository questionRepository
            )
        {
            _examRepository = examRepository;
            _sectionRepository = sectionRepository;
            _questionRepository = questionRepository;
        }

        public ISet<Exam> GetAllExams() => _examRepository.Get();


        public Exam GetExamWithSectionAndQuestions(int id)
        {
            Exam exam = _examRepository.Find(id);

            var sections = _sectionRepository.GetSectionsForExam(id)
                .Select(s =>
                {
                    s.Questions = _questionRepository.GetQuestionsForSection(s.Id).ToList();
                    return s;
                }).ToList();

            exam.Sections = sections;
            
            return exam;
        }
        
        public Exam GetExamWithSections(int id)
        {
            Exam exam = _examRepository.Find(id);

            var sections = _sectionRepository.GetSectionsForExam(id).ToList();

            exam.Sections = sections;
            
            return exam;
        }
        
        
        public Exam GetExam(int id)
        {
            Exam exam = _examRepository.Find(id);
            
            return exam;
        }

        public void AddExam(Exam exam)
        {
            _examRepository.Create(exam);
            
            _examRepository.Save();
        }
    }
}