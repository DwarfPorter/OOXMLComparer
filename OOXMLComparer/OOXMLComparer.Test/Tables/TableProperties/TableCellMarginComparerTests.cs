using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Tables.TableProperties;

namespace OOXMLComparer.Test.Tables.TableProperties
{
    [Category("OOXML")]
    public class TableCellMarginComparerTests
    {
        [Test]
        public void TableCellMarginComparer()
        {
            var a = new TableCellMargin();
            var b = new TableCellMargin();
            Assert.IsTrue(new TableCellMarginComparer(a, b).Compare());
        }

        [Test]
        public void TableCellMarginWrongComparer()
        {
            var a = new TableCellMargin(new LeftMargin());
            var b = new TableCellMargin(new RightMargin());
            Assert.IsFalse(new TableCellMarginComparer(a, b).Compare());
        }

    }
}
