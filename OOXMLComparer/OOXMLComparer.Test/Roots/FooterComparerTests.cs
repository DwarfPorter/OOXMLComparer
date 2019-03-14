using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Roots;

namespace OOXMLComparer.Test.Roots
{
    public class FooterComparerTests
    {
        [Test]
        public void FooterComparerTest()
        {
            var a = new Footer();
            var b = new Footer();
            Assert.IsTrue(new FooterComparer(a, b).Compare());
        }

        [Test]
        public void FooterComparerWrongTest()
        {
            var a = new Footer(new Body(new Paragraph()));
            var b = new Footer();
            Assert.IsFalse(new FooterComparer(a, b).Compare());
        }

        [Test]
        public void FooterComparerHappyTest()
        {
            var a = new Footer(new Body(new Paragraph(new Run(new Text("Test"))), new Table(new TableRow(new TableCell(new Paragraph(new Run(new Text("test2"))))))));
            var b = new Footer(new Body(new Paragraph(new Run(new Text("Test"))), new Table(new TableRow(new TableCell(new Paragraph(new Run(new Text("test2"))))))));
            Assert.IsTrue(new FooterComparer(a, b).Compare());
        }
    }
}
