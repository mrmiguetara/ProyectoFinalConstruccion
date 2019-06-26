using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.InkML;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace DocumentGeneration
{
    public class PdfBuilder
    {
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
                package.MainDocumentPart.Document =
                    new Document(
                        new Body(
                            new Paragraph(
                                new Run(
                                    new Text("Nombre: __________________"),
                                    new Text("ID:_____________________________")))));


                MainDocumentPart mainDocumentPart = package.MainDocumentPart;
                
                mainDocumentPart.DeleteParts(mainDocumentPart.HeaderParts);

                HeaderPart headerPart = mainDocumentPart.AddNewPart<HeaderPart>();
                string headerPartId = mainDocumentPart.GetIdOfPart(headerPart);
                
                GenerateHeaderPart(headerPart);


                IEnumerable<SectionProperties> sections = mainDocumentPart.Document.Body.Elements<SectionProperties>();

                foreach (var section in sections)
                {
                    // Delete existing references to headers and footers
                    section.RemoveAllChildren<HeaderReference>();

                    // Create the new header and footer reference node
                    section.PrependChild<HeaderReference>(new HeaderReference() { Id = headerPartId });
                }

                // Save changes to the main document part. 
                package.MainDocumentPart.Document.Save();
            }


            StreamReader s = new StreamReader(path);
            return s.BaseStream;
        }

        private void GenerateHeaderPart(HeaderPart part)
        {
            Header header1 = new Header() { MCAttributes = new MarkupCompatibilityAttributes() { Ignorable = "w14 wp14" } };
            header1.AddNamespaceDeclaration("wpc", "http://schemas.microsoft.com/office/word/2010/wordprocessingCanvas");
            header1.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            header1.AddNamespaceDeclaration("o", "urn:schemas-microsoft-com:office:office");
            header1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            header1.AddNamespaceDeclaration("m", "http://schemas.openxmlformats.org/officeDocument/2006/math");
            header1.AddNamespaceDeclaration("v", "urn:schemas-microsoft-com:vml");
            header1.AddNamespaceDeclaration("wp14", "http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing");
            header1.AddNamespaceDeclaration("wp", "http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing");
            header1.AddNamespaceDeclaration("w10", "urn:schemas-microsoft-com:office:word");
            header1.AddNamespaceDeclaration("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main");
            header1.AddNamespaceDeclaration("w14", "http://schemas.microsoft.com/office/word/2010/wordml");
            header1.AddNamespaceDeclaration("wpg", "http://schemas.microsoft.com/office/word/2010/wordprocessingGroup");
            header1.AddNamespaceDeclaration("wpi", "http://schemas.microsoft.com/office/word/2010/wordprocessingInk");
            header1.AddNamespaceDeclaration("wne", "http://schemas.microsoft.com/office/word/2006/wordml");
            header1.AddNamespaceDeclaration("wps", "http://schemas.microsoft.com/office/word/2010/wordprocessingShape");

            Paragraph paragraph1 = new Paragraph() { RsidParagraphAddition = "00164C17", RsidRunAdditionDefault = "00164C17" };

            ParagraphProperties paragraphProperties1 = new ParagraphProperties();
            ParagraphStyleId paragraphStyleId1 = new ParagraphStyleId() { Val = "Header" };

            paragraphProperties1.Append(paragraphStyleId1);

            Run run1 = new Run();
            Text text1 = new Text();
            text1.Text = "Header for more an more times to come";

            run1.Append(text1);

            paragraph1.Append(paragraphProperties1);
            paragraph1.Append(run1);

            header1.Append(paragraph1);

            part.Header = header1;
        }
    }
}