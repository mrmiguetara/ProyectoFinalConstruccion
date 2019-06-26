using System;
using System.Collections.Generic;
using Core.Helpers;
using Core.Models;
using Core.Repository;

namespace Core.Managers
{
    public class QuestionManager
    {
        private readonly IQuestionRepository _questionRepository;
        private readonly SectionManager _sectionManager;

        public QuestionManager(
            IQuestionRepository questionRepository,
            SectionManager sectionManager
        )
        {
            _questionRepository = questionRepository;
            _sectionManager = sectionManager;
        }

        public ISet<Question> GetQuestionsForSection(int sectionId)
        {
            var section = _sectionManager.GetSingleSection(sectionId);

            if (section == null)
            {
                return null;
            }

            var questions = _questionRepository.GetQuestionsForSection(sectionId);

            return questions;
        }

        public Question GetSingleQuestion(int questionId) => _questionRepository.Find(questionId);

        public Question GetSingleQuestion(int questionId, int sectionId) =>
            _questionRepository.GetQuestionByIdAndSection(questionId, sectionId);
        
        public Question AddNewQuestion(Question question, int sectionId)
        {
            if (_sectionManager.GetSingleSection(sectionId) == null)
            {
                return null;
            }
            
            question.SectionId = sectionId;
            
            _questionRepository.Create(question);
            
            _questionRepository.Save();

            return question;
        }

        public Question UpdateQuestion(Question question)
        {
            var trackingQuestion = _questionRepository.Find(question.Id);
            
            PropertyCopier<Question, Question>.Copy(question, 
                trackingQuestion, true, 
                "QuestionType", "Section");
            
            trackingQuestion.Updated = DateTime.Now;

            _questionRepository.Update(trackingQuestion);
            
            _questionRepository.Save();

            return trackingQuestion;
        }
        

        public Question DeleteQuestion(int id)
        {
            var question = _questionRepository.Find(id);

            if (question != null)
            {
                _questionRepository.Delete(id);
                
                _questionRepository.Save();
            }

            return question;
        }

        public void DeleteQuestionsInSection(int sectionId)
        { 
            _questionRepository.DeleteQuestionsForSection(sectionId);
            
            _questionRepository.Save();
        }

        public void DeleteQuestiosnForExam(int examId)
        {
            _questionRepository.DeleteQuestionsForExam(examId);
            
            _questionRepository.Save();
        }

    }
}