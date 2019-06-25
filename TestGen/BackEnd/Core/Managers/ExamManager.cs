using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Core.Helpers;
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

        public Exam AddExam(Exam exam)
        {
            try
            {
                _examRepository.Create(exam);

                _examRepository.Save();

                return exam;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public Exam UpdateExam(Exam exam)
        {
            Exam trackedExam = _examRepository.Find(exam.Id);
            
            PropertyCopier<Exam, Exam>.Copy(exam, trackedExam);
            
            _examRepository.Update(trackedExam);
            
            _examRepository.Save();

            return trackedExam;
        }


        public Exam DeleteExam(int examId)
        {
            Exam foundExam = _examRepository.Find(examId);

            if (foundExam != null)
            {
                _questionRepository.DeleteQuestionsForExam(examId);
                
                _sectionRepository.DeleteSectionsForExam(examId);
                
                _examRepository.Delete(examId);

                _examRepository.Save();
            }

            return foundExam;
        }
    }
}