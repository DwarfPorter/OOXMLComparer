using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Roots;

namespace OOXMLComparer.Test.Roots
{
    public class BodyComparerTests
    {
        [Test]
        public void BodyComparerTest()
        {
            var a = new Body();
            var b = new Body();
            Assert.IsTrue(new BodyComparer(a, b).Compare());
        }

        [Test]
        public void BodyComparerWrongTest()
        {
            var a = new Body(new Paragraph());
            var b = new Body();
            Assert.IsFalse(new BodyComparer(a, b).Compare());
        }

        [Test]
        public void BodyComparerHappyTest()
        {
            var a = new Body(new Paragraph( new Run(new Text("Test"))), new Table(new TableRow(new TableCell(new Paragraph(new Run (new Text("test2")))))));
            var b = new Body(new Paragraph(new Run(new Text("Test"))), new Table(new TableRow(new TableCell(new Paragraph(new Run(new Text("test2")))))));
            Assert.IsTrue(new BodyComparer(a, b).Compare());
        }
    }
}
