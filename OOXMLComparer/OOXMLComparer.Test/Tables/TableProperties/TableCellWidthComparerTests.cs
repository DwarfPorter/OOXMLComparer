using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Tables.TableProperties;

namespace OOXMLComparer.Test.Tables.TableProperties
{
    [Category("OOXML")]
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
}
