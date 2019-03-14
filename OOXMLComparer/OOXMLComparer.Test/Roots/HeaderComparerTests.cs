using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Roots;

namespace OOXMLComparer.Test.Roots
{
    public class HeaderComparerTests
    {
        [Test]
        public void HeaderComparerTest()
        {
            var a = new Header();
            var b = new Header();
            Assert.IsTrue(new HeaderComparer(a, b).Compare());
        }

        [Test]
        public void HeaderComparerWrongTest()
        {
            var a = new Header(new Body(new Paragraph()));
            var b = new Header();
            Assert.IsFalse(new HeaderComparer(a, b).Compare());
        }

        [Test]
        public void HeaderComparerHappyTest()
        {
            var a = new Header(new Body(new Paragraph(new Run(new Text("Test"))), new Table(new TableRow(new TableCell(new Paragraph(new Run(new Text("test2"))))))));
            var b = new Header(new Body(new Paragraph(new Run(new Text("Test"))), new Table(new TableRow(new TableCell(new Paragraph(new Run(new Text("test2"))))))));
            Assert.IsTrue(new HeaderComparer(a, b).Compare());
        }
    }
}
