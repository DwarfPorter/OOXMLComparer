using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Paragraphs.SectionProperties;

namespace OOXMLComparer.Test.Paragraphs.SectionProperties
{
    public class ColumnComparerTests
    {
        [Test]
        public void ColumnComparerTest()
        {
            var a = new Column();
            var b = new Column();
            Assert.IsTrue(new ColumnComparer(a, b).Compare());
        }

        [Test]
        public void ColumnComparerHappyTest()
        {
            var a = new Column() { Width = "42", Space = "42" };
            var b = new Column() { Width = "42", Space = "42" };
            Assert.IsTrue(new ColumnComparer(a, b).Compare());
        }

        [Test]
        public void ColumnComparerWrongTest()
        {
            var a = new Column() { Width = "42", Space = "42" };
            var b = new Column() { Width = "40", Space = "42" };
            Assert.IsFalse(new ColumnComparer(a, b).Compare());
            b.Width = "42";
            b.Space = "40";
            Assert.IsFalse(new ColumnComparer(a, b).Compare());
        }
    }
}
