using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Roots;

namespace OOXMLComparer.Test.Roots
{
    public class FooterPartComparerTests
    {
        [Test]
        public void FooterPartComparerTest()
        {
            using (WordprocessingDocument aDoc = WordprocessingDocument.Create("test1.docx", DocumentFormat.OpenXml.WordprocessingDocumentType.Document))
            {
                using (WordprocessingDocument bDoc = WordprocessingDocument.Create("test2.docx", DocumentFormat.OpenXml.WordprocessingDocumentType.Document))
                {
                    var aMainDocPart = aDoc.AddMainDocumentPart();
                    var a = CreateNewFooterPart(aMainDocPart);
                    a.Footer = new Footer(new Paragraph(new Run(new Text("111"))));

                    var bMainDocPart = bDoc.AddMainDocumentPart();
                    var b = CreateNewFooterPart(bMainDocPart);
                    b.Footer = new Footer(new Paragraph(new Run(new Text("111"))));
                    Assert.IsTrue(new FooterPartComparer(a, b).Compare());
                }
            }
        }

        [Test]
        public void FooterPartComparerWrongTest()
        {
            using (WordprocessingDocument aDoc = WordprocessingDocument.Create("test1.docx", DocumentFormat.OpenXml.WordprocessingDocumentType.Document))
            {
                using (WordprocessingDocument bDoc = WordprocessingDocument.Create("test2.docx", DocumentFormat.OpenXml.WordprocessingDocumentType.Document))
                {
                    var aMainDocPart = aDoc.AddMainDocumentPart();
                    var a = CreateNewFooterPart(aMainDocPart);
                    a.Footer = new Footer(new Paragraph(new Run(new Text("111"))));

                    var bMainDocPart = bDoc.AddMainDocumentPart();
                    var b = CreateNewFooterPart(bMainDocPart);
                    b.Footer = new Footer(new Paragraph(new Run(new Text("222"))));
                    Assert.IsFalse(new FooterPartComparer(a, b).Compare());
                }
            }
        }

        private FooterPart CreateNewFooterPart(MainDocumentPart main)
        {
            var footerPart = main.AddNewPart<FooterPart>();
            string aFooterPartId = main.GetIdOfPart(footerPart);
            main.Document = new Document(new Body(new Paragraph(), new SectionProperties(new HeaderReference { Id = aFooterPartId })));
            return footerPart;
        }
    }
}