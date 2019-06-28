using System.Collections.Generic;
using Api.ViewModels;
using AutoMapper;
using Core.Managers;
using Core.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/sections")]
    [ApiController]
    [Authorize]
    public class SectionController : Controller
    {
        private readonly SectionManager _sectionManager;
        private readonly ExamManager _examManager;

        public SectionController(
            SectionManager sectionManager,
            ExamManager examManager
            )
        {
            _sectionManager = sectionManager;
            _examManager = examManager;
        }

        [HttpGet("exam/{examId}")]
        public IActionResult GetSectionsForExam(int examId)
        {
            var sections = _sectionManager.GetSectionsForExam(examId);

            if (sections.Count == 0)
            {
                return NoContent();
            }
            
            var result = Mapper.Map<List<SectionResponse>>(sections);

            return Json(result);
        }


        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var section = _sectionManager.GetSingleSection(id);

            if (section == null)
            {
                return NotFound();
            }
            
            var result = Mapper.Map<SectionResponse>(section);

            return Ok(result);
        }

        [HttpPost]
        public IActionResult Create([FromBody] SectionRequest sectionRequest)
        {
            var section = Mapper.Map<Section>(sectionRequest);

            if (!_examManager.Exists(sectionRequest.ExamId))
            {
                return BadRequest("The exam id is not real");
            }
            
            _sectionManager.AddSection(section);

            return Ok();
        }

        [HttpPut]
        public IActionResult Update([FromBody] SectionRequest request)
        {
            var search = _sectionManager.GetSingleSection(request.Id);
            var section = Mapper.Map<Section>(request);
            
            if (search == null)
            {
                return BadRequest();
            }

            section.ExamId = search.ExamId;
            var resultSection = _sectionManager.UpdateSection(section);

            return Ok(resultSection);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (_sectionManager.HasQuestions(id))
            {
                return BadRequest("You must delete all questions to continue");
            }

            var section = _sectionManager.DeleteSection(id);

            return Ok(section);
        }

        [HttpDelete("exam/{examId}")]        
        public IActionResult DeleteForExam(int examId)
        {
            var sections = _sectionManager.DeleteAllSectionsForExam(examId);

            if (sections == null)
            {
                return BadRequest();
            }

            return Ok(sections);
        }
    }
}