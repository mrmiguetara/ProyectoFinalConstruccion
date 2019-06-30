using System.Collections.Generic;
using System.IO;
using System.Linq;
using Api.ViewModels;
using AutoMapper;
using Core.Managers;
using Core.Models;
using DocumentGeneration;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/exams")]
    [ApiController]
    [Authorize]
    public class ExamsController : Controller
    {
        private readonly ExamManager _examManager;
        private readonly SectionManager _sectionManager;
        public ExamsController(
            ExamManager examManager,
            SectionManager sectionManager
            )
        {
            _examManager = examManager;
            _sectionManager = sectionManager;
        }

        [HttpGet("user/{id}")]
        public IActionResult GetAll(int id)
        {
            ISet<Exam> exams = _examManager.GetAllExamsForUserId(id);

            return Json(exams);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Exam exam = _examManager.GetExam(id);

            if (exam == null)
            {
                return NotFound();
            }
            
            ExamResponse response = Mapper.Map<ExamResponse>(exam);
            
            return Json(response);
        }

        [HttpPost]
        public IActionResult Create(ExamRequest examRequest)
        {
            Exam exam = Mapper.Map<Exam>(examRequest);

            Exam examResult = _examManager.AddExam(exam);

            if (examResult == null)
            {
                return BadRequest();
            }

            ExamResponse response = Mapper.Map<ExamResponse>(examResult);

            return Ok(response);

        } 

        [HttpPut]
        public IActionResult Update([FromBody] ExamRequest examRequest)
        {
            Exam exam = Mapper.Map<Exam>(examRequest);
            
            Exam updated =_examManager.UpdateExam(exam);

            ExamResponse response = Mapper.Map<Exam, ExamResponse>(updated);
            
            return Ok(response);

        }
        
            
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Exam deletedExam = _examManager.DeleteExam(id);

            if (deletedExam == null)
            {
                return NotFound();
            }

            ExamResponse response = Mapper.Map<Exam, ExamResponse>(deletedExam);

            return Ok(response);
        }
    }
}