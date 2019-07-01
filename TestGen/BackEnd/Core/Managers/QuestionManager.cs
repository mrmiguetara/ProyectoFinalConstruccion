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
        private readonly ISectionRepository _sectionRepository;

        public QuestionManager(
            IQuestionRepository questionRepository,
            ISectionRepository sectionRepository
        )
        {
            _questionRepository = questionRepository;
            _sectionRepository = sectionRepository;
        }

        public ISet<Question> GetQuestionsForSection(int sectionId)
        {
            var section = _sectionRepository.Find(sectionId);

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
            if (_sectionRepository.Find(sectionId) == null)
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

            trackingQuestion.Answer = question.Answer;
            trackingQuestion.Title = question.Title;
            trackingQuestion.SectionId = question.SectionId;
            trackingQuestion.Options = question.Options;
            
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