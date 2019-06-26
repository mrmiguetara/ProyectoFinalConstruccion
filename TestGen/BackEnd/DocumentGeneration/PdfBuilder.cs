using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Core.Models;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using Justification = DocumentFormat.OpenXml.Wordprocessing.Justification;
using JustificationValues = DocumentFormat.OpenXml.Wordprocessing.JustificationValues;
using Paragraph = DocumentFormat.OpenXml.Wordprocessing.Paragraph;
using ParagraphProperties = DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties;
using Run = DocumentFormat.OpenXml.Wordprocessing.Run;
using Text = DocumentFormat.OpenXml.Wordprocessing.Text;

namespace DocumentGeneration
{
    public class PdfBuilder
    {
        
        private List<Section> sections = new List<Section>();
        private Exam exam;

        public PdfBuilder(Exam exam)
        {
            this.sections = exam.Sections.ToList();
            this.exam = exam;
        }
        public Stream WordDocument()
        {
            string guid = Guid.NewGuid().ToString();
            string directory = Directory.GetCurrentDirectory();
            string path = Path.Join(directory, "documents", $"{guid}.docx");
            using (WordprocessingDocument package =
                WordprocessingDocument.Create(path, WordprocessingDocumentType.Document))
            {
                // Add a new main document part. 
                package.AddMainDocumentPart();
                // Create the Document DOM. 
                var body = new Body(
                    ExamTitleHeader(),
                    EmptyParagraphSpace(),
                    StudentInformationSection(),
                    EmptyParagraphSpace()
                );

                PrintExamSections(ref body);
                
                package.MainDocumentPart.Document =
                    new Document(
                        body
                        );


                MainDocumentPart mainDocumentPart = package.MainDocumentPart;

                // Save changes to the main document part. 
                package.MainDocumentPart.Document.Save();
            }


            StreamReader s = new StreamReader(path);
            return s.BaseStream;
        }

        private Paragraph ExamTitleHeader()
        {
            var paragraphWithExamTitle = new Paragraph();

            var run = new Run();
            var paragraphProperties = new ParagraphProperties();
            var justification = new Justification(){ Val = JustificationValues.Center };
            paragraphProperties.Append(justification);

            run.Append(new Text($"Exam: {exam.Subject}"));
            run.Append(new Break());
            run.Append(new Text($"Teacher: {exam.Teacher}"));

            paragraphWithExamTitle.Append(paragraphProperties);
            paragraphWithExamTitle.Append(run);

            return paragraphWithExamTitle;
        }

        private Paragraph EmptyParagraphSpace()
        {
            return new Paragraph(new Run(new Break()));
        }

        private Paragraph StudentInformationSection()
        {
            var run = new Run();
            var paragraph = new Paragraph();
            
            var studentIdText = new Text("ID:______________ ");
            var nameText = new Text("Nombre:__________________________ ");
            var dateText = new Text("Fecha:______________________");

            studentIdText.Space = SpaceProcessingModeValues.Preserve;
            nameText.Space = SpaceProcessingModeValues.Preserve;

            run.Append(studentIdText);
            run.Append(nameText);
            run.Append(dateText);

            paragraph.Append(run);
            
            return paragraph;
        }

        private void PrintExamSections(ref Body body)
        {
            int counter = 1;
            foreach (var section in sections)
            {
                var questions = section.Questions.ToList();
                var examSection = new WordExamSections(section.Instruction);
                var sectionElement = examSection.SectionTitlePart(counter);
                
                body.Append(sectionElement);
                PrintSectionQuestions(ref body, questions);
                
                counter++;
                body.Append(EmptyParagraphSpace());    
            }
        }

        private void PrintSectionQuestions(ref Body body, List<Question> questions)
        {
            if (questions.Count > 0)
            {
                var sectionQuestions = new WordExamQuestions(questions);
                Paragraph[] questionsParagraph = sectionQuestions.GetQuestionsParagraph();
                body.Append(questionsParagraph);
            }

        }
    }
}