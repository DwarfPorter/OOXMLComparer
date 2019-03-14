using DocumentFormat.OpenXml.Packaging;
using NUnit.Framework;

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
    }
}
