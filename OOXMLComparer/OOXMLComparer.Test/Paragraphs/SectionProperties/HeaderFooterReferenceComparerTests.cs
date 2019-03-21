using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Paragraphs.SectionProperties;
using System.Linq;

namespace OOXMLComparer.Test.Paragraphs.SectionProperties
{
    [Category("OOXML")]
    public class HeaderFooterReferenceComparerTests
    {
        WordprocessingDocument word1;
        WordprocessingDocument word2;
        WordprocessingDocument word3;

        MainDocumentPart doc1;
        MainDocumentPart doc2;
        MainDocumentPart doc3;

        [SetUp]
        public void CreateWordDocs()
        {
            word1 = CreateWordDocument("doc1", new Header(new Paragraph(new Run(new Text("Header1")))), new Footer(new Paragraph(new Run(new Text("Footer1")))));
            word2 = CreateWordDocument("doc2", new Header(new Paragraph(new Run(new Text("Header1")))), new Footer(new Paragraph(new Run(new Text("Footer1")))));
            word3 = CreateWordDocument("doc3", new Header(new Paragraph(new Run(new Text("Header3")))), new Footer(new Paragraph(new Run(new Text("Footer3")))));
            doc1 = word1.MainDocumentPart;
            doc2 = word2.MainDocumentPart;
            doc3 = word3.MainDocumentPart;
        }

        [TearDown]
        public void DisposeWordDocs()
        {
            word1.Dispose();
            word2.Dispose();
            word3.Dispose();
        }

        [Test]
        public void HeaderReferenceComparerTest()
        {
            var a = new HeaderReference();
            var b = new HeaderReference();
            Assert.IsTrue(ComparerFactory.Create(a, b).Compare());
        }

        [Test]
        public void HeaderReferenceComparerWrongTest()
        {
            var a = new HeaderReference() { Type = HeaderFooterValues.Default };
            var b = new HeaderReference() { Type = HeaderFooterValues.First };
            Assert.IsFalse(new HeaderReferenceComparer(a, b).Compare());
        }

        [Test]
        public void HeaderReferenceComparerHappyTest()
        {
            var a = new HeaderReference() { Type = HeaderFooterValues.Default };
            var b = new HeaderReference() { Type = HeaderFooterValues.Default };
            Assert.IsTrue(new HeaderReferenceComparer(a, b).Compare());
        }

        [Test]
        public void HeaderReferenceComparerFromDocHappyTest()
        {
            var a = doc1.Document.Descendants<HeaderReference>().First();
            var b = doc2.Document.Descendants<HeaderReference>().First();
            Assert.IsTrue(ComparerFactory.Create(a, b).Compare());
        }

        [Test]
        public void HeaderReferenceComparerFromDocWrongTest()
        {
            var a = doc1.Document.Descendants<HeaderReference>().First();
            var b = doc3.Document.Descendants<HeaderReference>().First();
            Assert.IsFalse(ComparerFactory.Create(a, b).Compare());
        }

        [Test]
        public void FooterReferenceComparerTest()
        {
            var a = new FooterReference();
            var b = new FooterReference();
            Assert.IsTrue(ComparerFactory.Create(a, b).Compare());
        }

        [Test]
        public void FooterReferenceComparerWrongTest()
        {
            var a = new FooterReference() { Type = HeaderFooterValues.Default };
            var b = new FooterReference() { Type = HeaderFooterValues.First };
            Assert.IsFalse(new FooterReferenceComparer(a, b).Compare());
        }

        [Test]
        public void FooterReferenceComparerHappyTest()
        {
            var a = new FooterReference() { Type = HeaderFooterValues.Default };
            var b = new FooterReference() { Type = HeaderFooterValues.Default };
            Assert.IsTrue(new FooterReferenceComparer(a, b).Compare());
        }

        [Test]
        public void FooterReferenceComparerFromDocHappyTest()
        {
            var a = doc1.Document.Descendants<FooterReference>().First();
            var b = doc2.Document.Descendants<FooterReference>().First();
            Assert.IsTrue(ComparerFactory.Create(a, b).Compare());
        }

        [Test]
        public void FooterReferenceComparerFromDocWrongTest()
        {
            var a = doc1.Document.Descendants<FooterReference>().First();
            var b = doc3.Document.Descendants<FooterReference>().First();
            Assert.IsFalse(ComparerFactory.Create(a, b).Compare());
        }

        private WordprocessingDocument CreateWordDocument(string name, Header header, Footer footer)
        {
            var wordProcessing = WordprocessingDocument.Create(name, DocumentFormat.OpenXml.WordprocessingDocumentType.Document);
            var mainDoc = wordProcessing.AddMainDocumentPart();
            mainDoc.Document = new Document(new Body(new Paragraph(), new DocumentFormat.OpenXml.Wordprocessing.SectionProperties()));
            var headerPart = CreateNewHeaderPart(mainDoc);
            headerPart.Header = header;
            var footerPart = CreateNewFooterPart(mainDoc);
            footerPart.Footer = footer;
            return wordProcessing;
        }

        private HeaderPart CreateNewHeaderPart(MainDocumentPart main)
        {
            var headerPart = main.AddNewPart<HeaderPart>();
            string aHeaderPartId = main.GetIdOfPart(headerPart);
            var sectionProperties = main.Document.Body.Elements<DocumentFormat.OpenXml.Wordprocessing.SectionProperties>().First();
            sectionProperties.PrependChild<HeaderReference>(new HeaderReference { Type = HeaderFooterValues.Default, Id = aHeaderPartId });
            return headerPart;
        }

        private FooterPart CreateNewFooterPart(MainDocumentPart main)
        {
            var footerPart = main.AddNewPart<FooterPart>();
            string aFooterPartId = main.GetIdOfPart(footerPart);
            var sectionProperties = main.Document.Body.Elements<DocumentFormat.OpenXml.Wordprocessing.SectionProperties>().First();
            sectionProperties.PrependChild<FooterReference>(new FooterReference { Type = HeaderFooterValues.Default, Id = aFooterPartId });
            return footerPart;
        }
    }
}
