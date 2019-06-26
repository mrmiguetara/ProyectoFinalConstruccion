using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.ExtendedProperties;
using DocumentFormat.OpenXml.InkML;
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
        
        private List<string> sections = new List<string>();

        public PdfBuilder(List<string> sections)
        {
            this.sections = sections;
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

        private OpenXmlElement ExamTitleHeader()
        {
            var paragraphWithExamTitle = new Paragraph();

            var run = new Run();
            var paragraphProperties = new ParagraphProperties();
            var justification = new Justification(){ Val = JustificationValues.Center };
            paragraphProperties.Append(justification);

            run.Append(new Text("Exam Title"));
            run.Append(new Break());
            run.Append(new Text("Trimestre 2019 - III"));
            run.Append(new Break());
            run.Append(new Text("Teachers name"));

            paragraphWithExamTitle.Append(paragraphProperties);
            paragraphWithExamTitle.Append(run);

            return paragraphWithExamTitle;
        }

        private OpenXmlElement EmptyParagraphSpace()
        {
            return new Paragraph(new Run(new Break()));
        }

        private OpenXmlElement StudentInformationSection()
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
                var examSection = new WordExamSections(section);
                var sectionElement = examSection.SectionTitlePart(counter);
                body.Append(sectionElement);
                counter++;
            }
        }
    }
}