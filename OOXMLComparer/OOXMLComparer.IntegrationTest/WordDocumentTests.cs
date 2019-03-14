using DocumentFormat.OpenXml.Packaging;
using NUnit.Framework;
using OOXMLComparer.Roots;
using System;
using System.IO;

namespace Tests
{
    public class WordDocumentTests
    {
        [TestCase("SimpleDoc1.docx", "SimpleDoc2.docx")]
        public void DocumentCompareTest(string fileA, string fileB)
        {
            var currentPath = AppDomain.CurrentDomain.BaseDirectory;
            var dataPath = Path.Combine(currentPath, "TestData");

            var filePathA = Path.Combine(dataPath, fileA);
            var filePathB = Path.Combine(dataPath, fileB);

            using (WordprocessingDocument aDoc = WordprocessingDocument.Open(filePathA, false))
            {
                using (WordprocessingDocument bDoc = WordprocessingDocument.Open(filePathB, false))
                {
                    var wordComparer = new MainDocumentPartComparer(aDoc.MainDocumentPart, bDoc.MainDocumentPart);
                    Assert.IsTrue(wordComparer.Compare());
                }
            }
        }

        [TestCase("SimpleDoc1.docx", "SimpleDoc3.docx")]
        public void DocumentCompareWrongTest(string fileA, string fileB)
        {
            var currentPath = AppDomain.CurrentDomain.BaseDirectory;
            var dataPath = Path.Combine(currentPath, "TestData");

            var filePathA = Path.Combine(dataPath, fileA);
            var filePathB = Path.Combine(dataPath, fileB);

            using (WordprocessingDocument aDoc = WordprocessingDocument.Open(filePathA, false))
            {
                using (WordprocessingDocument bDoc = WordprocessingDocument.Open(filePathB, false))
                {
                    var wordComparer = new MainDocumentPartComparer(aDoc.MainDocumentPart, bDoc.MainDocumentPart);
                    Assert.IsFalse(wordComparer.Compare());
                }
            }
        }
    }
}