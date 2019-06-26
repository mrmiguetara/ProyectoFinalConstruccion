using System;
using Api.ViewModels;
using AutoMapper;
using Core.Managers;
using Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    public class QuestionController : Controller
    {

        private readonly QuestionManager _questionManager;
        private readonly SectionManager _sectionManager;

        public QuestionController(
            QuestionManager questionManager,
            SectionManager sectionManager
        )
        {
            _questionManager = questionManager;
            _sectionManager = sectionManager;
        }

        [HttpGet("section/{sectionId}")]
        public IActionResult GetQuestionsForSection(int sectionId)
        {
            var questions = _questionManager.GetQuestionsForSection(sectionId);
            
            if (questions == null)
            {
                return NotFound();
            }

            if (questions.Count == 0)
            {
                return NoContent();
            }

            return Ok(questions);
        }

        [HttpGet("{id}")]
        public IActionResult GetQuestion(int id)
        {
            var question = _questionManager.GetSingleQuestion(id);

            if (question == null)
            {
                return NotFound();
            }

            return Ok(question);
        }


        [HttpPost]
        public IActionResult Create([FromBody] QuestionRequest request)
        {
            var question = Mapper.Map<Question>(request);

            var result = _questionManager.AddNewQuestion(question, request.SectionId);

            var sectionExists = _sectionManager.GetSingleSection(request.SectionId) != null; 

            if (result == null)
            {
                return BadRequest("Something went wrong while inserting the question");
            }

            if (!sectionExists)
            {
                return BadRequest("The given section doesn't exist");
            }

            var response = Mapper.Map<QuestionResponse>(result);

            return Ok(response);
        }

        [HttpPut]
        public IActionResult Update([FromBody] QuestionRequest request)
        {
            var question = Mapper.Map<Question>(request);

            var result = _questionManager.UpdateQuestion(question);

            if (result == null)
            {
                return BadRequest();
            }

            return Ok(result);
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var question = _questionManager.DeleteQuestion(id);

            if (question == null)
            {
                return NotFound();
            }

            var response = Mapper.Map<QuestionResponse>(question);

            return Ok(response);
        }

        [HttpDelete("section/{sectionId}")]
        public IActionResult DeleteQuestionsInSection(int sectionId)
        {
            try
            {
                _questionManager.DeleteQuestionsInSection(sectionId);

                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        
        [HttpDelete("exam/{examId}")]
        public IActionResult DeleteQuestionInExam(int examId)
        {
            try
            {
                _questionManager.DeleteQuestionsInSection(examId);

                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        
    }
}