using System.Collections.Generic;
using System.Linq;
using Api.ViewModels;
using AutoMapper;
using Core.Managers;
using Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamsController : Controller
    {
        private readonly ExamManager _examManager;
        private readonly SectionManager _sectionManager;
        private readonly IMapper mapper;

        public ExamsController(
            ExamManager examManager,
            SectionManager sectionManager,
            IMapper mapper
            )
        {
            _examManager = examManager;
            _sectionManager = sectionManager;
            this.mapper = mapper;
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

            ExamResponse response = Mapper.Map<ExamResponse>(exam);
            
            return Json(response);
        }
        
        
    }
}