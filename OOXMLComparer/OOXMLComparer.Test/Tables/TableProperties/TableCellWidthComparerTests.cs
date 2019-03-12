using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Tables.TableProperties;

namespace OOXMLComparer.Test.Tables.TableProperties
{
    public class TableCellWidthComparerTests
    {
        [Test]
        public void TableCellWidthComparerTest()
        {
            var a = new TableCellWidth();
            var b = new TableCellWidth();
            Assert.IsTrue(new TableCellWidthComparer(a, b).Compare());
        }
    }
    public class TableCellSpacingComparerTests
    {
        [Test]
        public void TableCellSpacingComparerTest()
        {
            var a = new TableCellSpacing();
            var b = new TableCellSpacing();
            Assert.IsTrue(new TableCellSpacingComparer(a, b).Compare());
        }
    }
}
