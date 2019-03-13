using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Tables.TableProperties;

namespace OOXMLComparer.Test.Tables.TableProperties
{
    public class TableWidthComparerTests
    {
        [Test]
        public void TableWidthComparerTest()
        {
            var a = new TableWidth();
            var b = new TableWidth();
            Assert.IsTrue(new TableWidthComparer(a, b).Compare());
        }

        [Test]
        public void TableWidthComparerTypeWrongTest()
        {
            var a = new TableWidth() { Type = TableWidthUnitValues.Dxa };
            var b = new TableWidth() { Type = TableWidthUnitValues.Pct };
            Assert.IsFalse(new TableWidthComparer(a, b).Compare());
        }

        [Test]
        public void TableWidthComparerWidthWrongTest()
        {
            var a = new TableWidth() { Width = "20" };
            var b = new TableWidth();
            Assert.IsFalse(new TableWidthComparer(a, b).Compare());
        }
    }
}
