using System.Collections.Generic;
using System.IO;
using System.Linq;
using Api.ViewModels;
using AutoMapper;
using Core.Managers;
using Core.Models;
using DocumentGeneration;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamsController : Controller
    {
        private readonly ExamManager _examManager;
        public ExamsController(
            ExamManager examManager
            )
        {
            _examManager = examManager;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            ISet<Exam> exams = _examManager.GetAllExams();

            return Json(exams);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Exam exam = _examManager.GetExamWithSectionAndQuestions(id);

            if (exam == null)
            {
                return NotFound();
            }
            
            ExamResponse response = Mapper.Map<ExamResponse>(exam);
            
            return Json(response);
        }
        
        [HttpGet("document/{id}")]
        public IActionResult GetDocument(int id)
        {
            PdfBuilder pdfBuilder = new PdfBuilder();

            Stream file = pdfBuilder.WordDocument();
            
            FileStreamResult fileStreamResult = new FileStreamResult(file, "application/ms-word");

            fileStreamResult.FileDownloadName = $"Test {id}.docx";

            return fileStreamResult;
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
        
        
        [HttpDelete]
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