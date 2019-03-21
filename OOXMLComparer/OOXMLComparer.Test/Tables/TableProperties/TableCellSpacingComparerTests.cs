using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Tables.TableProperties;

namespace OOXMLComparer.Test.Tables.TableProperties
{
    [Category("OOXML")]
    public class TableCellSpacingComparerTests
    {
        [Test]
        public void TableCellSpacingComparerTest()
        {
            var a = new TableCellSpacing();
            var b = new TableCellSpacing();
            Assert.IsTrue(ComparerFactory.Create(a, b).Compare());
        }
    }
}
