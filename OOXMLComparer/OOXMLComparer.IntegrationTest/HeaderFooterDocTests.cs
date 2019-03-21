using DocumentFormat.OpenXml.Packaging;
using NUnit.Framework;
using OOXMLComparer.Roots;
using System;
using System.IO;
using System.Linq;

namespace Tests
{
    [Category("OOXML")]
    public class HeaderFooterDocTests
    {
        [TestCase("HeaderDoc1.docx", "HeaderDoc2.docx")]
        public void HeaderCompareTest(string fileA, string fileB)
        {
            var currentPath = AppDomain.CurrentDomain.BaseDirectory;
            var dataPath = Path.Combine(currentPath, "TestData");

            var filePathA = Path.Combine(dataPath, fileA);
            var filePathB = Path.Combine(dataPath, fileB);

            using (WordprocessingDocument aDoc = WordprocessingDocument.Open(filePathA, false))
            {
                using (WordprocessingDocument bDoc = WordprocessingDocument.Open(filePathB, false))
                {
                    var wordComparer = new HeaderComparer(aDoc.MainDocumentPart.HeaderParts.First().Header, bDoc.MainDocumentPart.HeaderParts.First().Header);
                    Assert.IsTrue(wordComparer.Compare());
                }
            }
        }

        [TestCase("HeaderDoc1.docx", "HeaderDoc3.docx")]
        public void HeaderCompareWrongTest(string fileA, string fileB)
        {
            var currentPath = AppDomain.CurrentDomain.BaseDirectory;
            var dataPath = Path.Combine(currentPath, "TestData");

            var filePathA = Path.Combine(dataPath, fileA);
            var filePathB = Path.Combine(dataPath, fileB);

            using (WordprocessingDocument aDoc = WordprocessingDocument.Open(filePathA, false))
            {
                using (WordprocessingDocument bDoc = WordprocessingDocument.Open(filePathB, false))
                {
                    var wordComparer = new HeaderPartComparer(aDoc.MainDocumentPart.HeaderParts.First(), bDoc.MainDocumentPart.HeaderParts.First());
                    Assert.IsFalse(wordComparer.Compare());
                }
            }
        }

        [TestCase("HeaderDoc1.docx", "HeaderDoc2.docx")]
        public void FooterCompareTest(string fileA, string fileB)
        {
            var currentPath = AppDomain.CurrentDomain.BaseDirectory;
            var dataPath = Path.Combine(currentPath, "TestData");

            var filePathA = Path.Combine(dataPath, fileA);
            var filePathB = Path.Combine(dataPath, fileB);

            using (WordprocessingDocument aDoc = WordprocessingDocument.Open(filePathA, false))
            {
                using (WordprocessingDocument bDoc = WordprocessingDocument.Open(filePathB, false))
                {
                    var wordComparer = new FooterComparer(aDoc.MainDocumentPart.FooterParts.First().Footer, bDoc.MainDocumentPart.FooterParts.First().Footer);
                    Assert.IsTrue(wordComparer.Compare());
                }
            }
        }

        [TestCase("HeaderDoc1.docx", "HeaderDoc3.docx")]
        public void FooterCompareWrongTest(string fileA, string fileB)
        {
            var currentPath = AppDomain.CurrentDomain.BaseDirectory;
            var dataPath = Path.Combine(currentPath, "TestData");

            var filePathA = Path.Combine(dataPath, fileA);
            var filePathB = Path.Combine(dataPath, fileB);

            using (WordprocessingDocument aDoc = WordprocessingDocument.Open(filePathA, false))
            {
                using (WordprocessingDocument bDoc = WordprocessingDocument.Open(filePathB, false))
                {
                    var wordComparer = new FooterComparer(aDoc.MainDocumentPart.FooterParts.First().Footer, bDoc.MainDocumentPart.FooterParts.First().Footer);
                    Assert.IsFalse(wordComparer.Compare());
                }
            }
        }
    }
}