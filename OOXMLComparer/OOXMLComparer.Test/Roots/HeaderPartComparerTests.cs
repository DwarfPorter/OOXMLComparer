﻿using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Roots;

namespace OOXMLComparer.Test.Roots
{
    [Category("OOXML")]
    public class HeaderPartComparerTests
    {
        [Test]
        public void HeaderPartComparerTest()
        {
            using (WordprocessingDocument aDoc = WordprocessingDocument.Create("test1.docx", DocumentFormat.OpenXml.WordprocessingDocumentType.Document))
            {
                using (WordprocessingDocument bDoc = WordprocessingDocument.Create("test2.docx", DocumentFormat.OpenXml.WordprocessingDocumentType.Document))
                {
                    var aMainDocPart = aDoc.AddMainDocumentPart();
                    var a = CreateNewHeaderPart(aMainDocPart);
                    a.Header = new Header(new Paragraph(new Run(new Text("111"))));

                    var bMainDocPart = bDoc.AddMainDocumentPart();
                    var b = CreateNewHeaderPart(bMainDocPart);
                    b.Header = new Header(new Paragraph(new Run(new Text("111"))));
                    Assert.IsTrue(new HeaderPartComparer(a, b).Compare());
                }
            }
        }

        [Test]
        public void HeaderPartComparerWrongTest()
        {
            using (WordprocessingDocument aDoc = WordprocessingDocument.Create("test1.docx", DocumentFormat.OpenXml.WordprocessingDocumentType.Document))
            {
                using (WordprocessingDocument bDoc = WordprocessingDocument.Create("test2.docx", DocumentFormat.OpenXml.WordprocessingDocumentType.Document))
                {
                    var aMainDocPart = aDoc.AddMainDocumentPart();
                    var a = CreateNewHeaderPart(aMainDocPart);
                    a.Header = new Header(new Paragraph(new Run(new Text("111"))));

                    var bMainDocPart = bDoc.AddMainDocumentPart();
                    var b = CreateNewHeaderPart(bMainDocPart);
                    b.Header = new Header(new Paragraph(new Run(new Text("222"))));
                    Assert.IsFalse(new HeaderPartComparer(a, b).Compare());
                }
            }
        }

        private HeaderPart CreateNewHeaderPart(MainDocumentPart main)
        {
            var headerPart = main.AddNewPart<HeaderPart>();
            string aHeaderPartId = main.GetIdOfPart(headerPart);
            main.Document = new Document(new Body(new Paragraph(), new SectionProperties(new HeaderReference { Id = aHeaderPartId })));
            return headerPart;
        }
    }
}