using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Tables.TableProperties;

namespace OOXMLComparer.Test.Tables.TableProperties
{
    public class TableCellBordersComparerTests
    {
        [Test]
        public void TableCellBordersComparerTest()
        {
            var a = new TableCellBorders();
            var b = new TableCellBorders();
            Assert.IsTrue(new TableCellBordersComparer(a, b).Compare());
        }

        [Test]
        public void TableCellBordersComparerHappyTest()
        {
            var a = new TableCellBorders(new TopBorder { Size = 20 });
            var b = new TableCellBorders() { TopBorder = new TopBorder { Size = 20 } };
            Assert.IsTrue(new TableCellBordersComparer(a, b).Compare());
        }

        [Test]
        public void TableCellBordersComparerWrongTest()
        {
            var a = new TableCellBorders(new TopBorder { Size = 20 });
            var b = new TableCellBorders();
            Assert.IsFalse(new TableCellBordersComparer(a, b).Compare());
        }
    }
}
