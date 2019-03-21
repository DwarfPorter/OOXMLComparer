using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Paragraphs.SectionProperties;

namespace OOXMLComparer.Test.Paragraphs.SectionProperties
{
    [Category("OOXML")]
    public class ColumnsComparerTests
    {
        [Test]
        public void ColumnsComparerTest()
        {
            var a = new Columns();
            var b = new Columns();
            Assert.IsTrue(new ColumnsComparer(a, b).Compare());
        }

        [Test]
        public void ColumnsComparerHappyTest()
        {
            var a = new Columns() { ColumnCount = 2, EqualWidth = true, Separator = true, Space = "1" };
            var b = new Columns() { ColumnCount = 2, EqualWidth = true, Separator = true, Space = "1" };
            Assert.IsTrue(new ColumnsComparer(a, b).Compare());
        }

        [Test]
        public void ColumnsComparerChildrenHappyTest()
        {
            var a = new Columns(new Column() { Width = "1" }, new Column() { Width = "2", Space = "3" });
            var b = new Columns(new Column() { Width = "1" }, new Column() { Width = "2", Space = "3" });
            Assert.IsTrue(new ColumnsComparer(a, b).Compare());
        }

        [Test]
        public void ColumnsComparerWrongTest()
        {
            var a = new Columns(new Column() { Width = "1" }) { EqualWidth = true };
            var b = new Columns(new Column() { Width = "1" }) { EqualWidth = false };
            Assert.IsFalse(new ColumnsComparer(a, b).Compare());
        }

        [Test]
        public void ColumnsComparerChildrenWrongTest()
        {
            var a = new Columns(new Column() { Width = "1" });
            var b = new Columns(new Column() { Width = "2" });
            Assert.IsFalse(new ColumnsComparer(a, b).Compare());
        }
    }
}
