using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Tables.TableProperties;

namespace OOXMLComparer.Test.Tables.TableProperties
{
    public class TableBordersComparerTests
    {
        [Test]
        public void TableBordersComparerTest()
        {
            var a = new TableBorders();
            var b = new TableBorders();
            Assert.IsTrue(new TableBordersComparer(a, b).Compare());
        }

        [Test]
        public void TableBordersComparerHappyTest()
        {
            var a = new TableBorders(new TopBorder { Size = 20 });
            var b = new TableBorders() { TopBorder = new TopBorder { Size = 20 } };
            Assert.IsTrue(new TableBordersComparer(a, b).Compare());
        }

        [Test]
        public void TableCellBordersComparerWrongTest()
        {
            var a = new TableBorders(new TopBorder { Size = 20 });
            var b = new TableBorders();
            Assert.IsFalse(new TableBordersComparer(a, b).Compare());
        }
    }
}
