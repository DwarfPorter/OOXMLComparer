using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Roots;

namespace OOXMLComparer.Test.Roots
{
    public class MainDocumentPartComparerTests
    {
        [Test]
        public void MainDocumentPartComparerTest()
        {
            using (WordprocessingDocument aDoc = WordprocessingDocument.Create("test1.docx", DocumentFormat.OpenXml.WordprocessingDocumentType.Document))
            {
                using (WordprocessingDocument bDoc = WordprocessingDocument.Create("test2.docx", DocumentFormat.OpenXml.WordprocessingDocumentType.Document))
                {
                    var a = aDoc.AddMainDocumentPart();
                    var b = bDoc.AddMainDocumentPart();
                    Assert.IsTrue(new MainDocumentPartComparer(a, b).Compare());
                }
            }
        }
        [Test]
        public void MainDocumentPartComparerWrongTest()
        {
            using (WordprocessingDocument aDoc = WordprocessingDocument.Create("test1.docx", DocumentFormat.OpenXml.WordprocessingDocumentType.Document))
            {
                using (WordprocessingDocument bDoc = WordprocessingDocument.Create("test2.docx", DocumentFormat.OpenXml.WordprocessingDocumentType.Document))
                {
                    var a = aDoc.AddMainDocumentPart();
                    a.Document = new Document(new Body(new Paragraph(new Run(new Text("first")))));
                    var b = bDoc.AddMainDocumentPart();
                    b.Document = new Document(new Body(new Paragraph(new Run(new Text("second")))));
                    Assert.IsFalse(new MainDocumentPartComparer(a, b).Compare());
                }
            }
        }

        [Test]
        public void MainDocumentPartComparerHappyTest()
        {
            using (WordprocessingDocument aDoc = WordprocessingDocument.Create("test1.docx", DocumentFormat.OpenXml.WordprocessingDocumentType.Document))
            {
                using (WordprocessingDocument bDoc = WordprocessingDocument.Create("test2.docx", DocumentFormat.OpenXml.WordprocessingDocumentType.Document))
                {
                    var a = aDoc.AddMainDocumentPart();
                    a.Document = new Document(new Body(new Paragraph(new Run(new Text("first")))));
                    var b = bDoc.AddMainDocumentPart();
                    b.Document = new Document(new Body(new Paragraph(new Run(new Text("first")))));
                    Assert.IsTrue(new MainDocumentPartComparer(a, b).Compare());
                }
            }
        }
    }
}