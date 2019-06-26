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


                var headerPart = package.AddNewPart<HeaderPart>();
                headerPart.Header = new Header(new Run(new Text("Este es el examen que estamos generando")));

                // Save changes to the main document part. 
                package.MainDocumentPart.Document.Save();
            }


            StreamReader s = new StreamReader(path);
            return s.BaseStream;
        }
    }
}