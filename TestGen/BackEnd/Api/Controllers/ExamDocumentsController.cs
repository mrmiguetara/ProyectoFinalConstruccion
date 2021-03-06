using System;
using System.IO;
using System.Linq;
using Api.ViewModels;
using Core.Managers;
using DocumentGeneration;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/documents")]
    [ApiController]
    [Authorize]
    public class ExamDocumentsController : Controller
    {

        private readonly ExamManager _examManager;
        private readonly SectionManager _sectionManager;

        public ExamDocumentsController(
            ExamManager examManager,
            SectionManager sectionManager
        )
        {
            _examManager = examManager;
            _sectionManager = sectionManager;
        }

        [HttpGet("{id}")]
        public IActionResult CreateDocumentFile(int id)
        {

            var exam = _examManager.GetExamWithSectionAndQuestions(id);

            var pdfBuilder = new PdfBuilder(exam);

            var stream = pdfBuilder.WordDocument();

            MemoryStream memoryStream = new MemoryStream();
            stream.CopyTo(memoryStream);

            var byteArray = memoryStream.ToArray();

            var docResponse = new DocumentResponse
            {
                Base64 = Convert.ToBase64String(byteArray),
                FileName = $"{exam.Subject}_{exam.Teacher}_{DateTime.Now.ToShortTimeString()}.docx",
                ApplicationFormat = "application/ms-word"
            };

            return Ok(docResponse);
        }
    }
}