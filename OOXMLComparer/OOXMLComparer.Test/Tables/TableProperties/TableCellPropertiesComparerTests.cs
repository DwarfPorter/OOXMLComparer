using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Tables.TableProperties;

namespace OOXMLComparer.Test.Tables.TableProperties
{
    public class TableCellPropertiesComparerTests
    {
        [Test]
        public void TableCellPropertiesComparerTest()
        {
            var a = new TableCellProperties();
            var b = new TableCellProperties();
            Assert.IsTrue(new TableCellPropertiesComparer(a, b).Compare());
        }

        [Test]
        public void TableCellPropertiesComparerWrongTest()
        {
            var a = new TableCellProperties(new TextDirection() { Val = TextDirectionValues.BottomToTopLeftToRight });
            var b = new TableCellProperties();
            Assert.IsFalse(new TableCellPropertiesComparer(a, b).Compare());
        }
    }
}
