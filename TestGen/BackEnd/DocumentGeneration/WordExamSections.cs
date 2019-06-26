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
    public class WordExamSections
    {
        public string Section { get; private set; }

        public WordExamSections(string sectionInstruction)
        {
            Section = sectionInstruction;
        }

        public OpenXmlElement SectionTitlePart(int sectionNumber)
        {
            var paragraph = new Paragraph();

            var run = new Run();
            
            var runProperties = new RunProperties();
            var bold = new Bold();
            bold.Val = OnOffValue.FromBoolean(true);
            runProperties.Append(bold);
            
            run.Append(runProperties);

            var text = new Text($"( {sectionNumber} ) {Section}");
            
            run.Append(text);
            
            paragraph.Append(run);

            return paragraph;
        }
    }
}