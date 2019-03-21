using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace OOXMLComparer.IntegrationTest
{
    [Category("OOXML")]
    public class DocxComparerTests
    {
        [TestCase("SimpleDoc1.docx", "SimpleDoc2.docx")]
        [TestCase("HeaderDoc1.docx", "HeaderDoc2.docx")]
        public void DocxCompareTest(string fileA, string fileB)
        {
            var currentPath = AppDomain.CurrentDomain.BaseDirectory;
            var dataPath = Path.Combine(currentPath, "TestData");

            var filePathA = Path.Combine(dataPath, fileA);
            var filePathB = Path.Combine(dataPath, fileB);

            using (var aStream = new FileStream(filePathA, FileMode.Open))
            {
                using (var bStream = new FileStream(filePathB, FileMode.Open))
                {
                    var comparer = new DocxComparer();
                    Assert.IsTrue(comparer.Compare(aStream, bStream));
                }
            }
        }

        [TestCase("SimpleDoc1.docx", "SimpleDoc3.docx")]
        [TestCase("HeaderDoc1.docx", "HeaderDoc3.docx")]
        public void DocxCompareWrongTest(string fileA, string fileB)
        {
            var currentPath = AppDomain.CurrentDomain.BaseDirectory;
            var dataPath = Path.Combine(currentPath, "TestData");

            var filePathA = Path.Combine(dataPath, fileA);
            var filePathB = Path.Combine(dataPath, fileB);

            using (var aStream = new FileStream(filePathA, FileMode.Open))
            {
                using (var bStream = new FileStream(filePathB, FileMode.Open))
                {
                    var comparer = new DocxComparer();
                    Assert.IsFalse(comparer.Compare(aStream, bStream));
                }
            }
        }

    }
}
