using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Tables.TableProperties;

namespace OOXMLComparer.Test.Tables.TableProperties
{
    public class TableIndentationComparerTests
    {
        [Test]
        public void TableIndentationComparerTest()
        {
            var a = new TableIndentation();
            var b = new TableIndentation();
            Assert.IsTrue(new TableIndentationComparer(a, b).Compare());
        }

        [Test]
        public void TableIndentationComparerHappyTest()
        {
            var a = new TableIndentation() { Type = TableWidthUnitValues.Dxa, Width = 33 };
            var b = new TableIndentation() { Type = TableWidthUnitValues.Dxa, Width = 33 };
            Assert.IsTrue(new TableIndentationComparer(a, b).Compare());
        }

        [Test]
        public void TableIndentationComparerWidhtWrongTest()
        {
            var a = new TableIndentation() { Type = TableWidthUnitValues.Dxa, Width = 30 };
            var b = new TableIndentation() { Type = TableWidthUnitValues.Dxa, Width = 33 };
            Assert.IsFalse(new TableIndentationComparer(a, b).Compare());
        }

        [Test]
        public void TableIndentationComparerTypeWrongTest()
        {
            var a = new TableIndentation() { Type = TableWidthUnitValues.Dxa, Width = 33 };
            var b = new TableIndentation() { Type = TableWidthUnitValues.Pct, Width = 33 };
            Assert.IsFalse(new TableIndentationComparer(a, b).Compare());
        }
    }
}
