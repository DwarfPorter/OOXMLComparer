using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Roots;

namespace OOXMLComparer.Test.Roots
{
    [Category("OOXML")]
    public class DocumentComparerTests
    {
        [Test]
        public void DocumentComparerTest()
        {
            var a = new Document();
            var b = new Document();
            Assert.IsTrue(ComparerFactory.Create(a, b).Compare());
        }

        [Test]
        public void DocumentComparerWrongTest()
        {
            var a = new Document(new Body(new Paragraph()));
            var b = new Document();
            Assert.IsFalse(new DocumentComparer(a, b).Compare());
        }

        [Test]
        public void DocumentComparerHappyTest()
        {
            var a = new Document(new Body(new Paragraph(new Run(new Text("Test"))), new Table(new TableRow(new TableCell(new Paragraph(new Run(new Text("test2"))))))));
            var b = new Document(new Body(new Paragraph(new Run(new Text("Test"))), new Table(new TableRow(new TableCell(new Paragraph(new Run(new Text("test2"))))))));
            Assert.IsTrue(new DocumentComparer(a, b).Compare());
        }
    }
}
