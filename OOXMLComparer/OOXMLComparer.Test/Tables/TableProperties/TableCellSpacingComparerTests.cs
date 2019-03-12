using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Tables.TableProperties;

namespace OOXMLComparer.Test.Tables.TableProperties
{
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
