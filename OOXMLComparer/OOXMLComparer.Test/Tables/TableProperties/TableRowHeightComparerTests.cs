using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Tables.TableProperties;

namespace OOXMLComparer.Test.Tables.TableProperties
{
    [Category("OOXML")]
    public class TableRowHeightComparerTests
    {
        [Test]
        public void TableRowHeightComparerTest()
        {
            var a = new TableRowHeight();
            var b = new TableRowHeight();
            Assert.IsTrue(new TableRowHeightComparer(a, b).Compare());
        }

        [Test]
        public void TableRowHeightComparerHappyTest()
        {
            var a = new TableRowHeight() { HeightType = HeightRuleValues.Auto, Val = 32 };
            var b = new TableRowHeight() { HeightType = HeightRuleValues.Auto, Val = 32 };
            Assert.IsTrue(new TableRowHeightComparer(a, b).Compare());
        }

        [Test]
        public void TableRowHeightComparerValWrongTest()
        {
            var a = new TableRowHeight() { HeightType = HeightRuleValues.Auto, Val = 31 };
            var b = new TableRowHeight() { HeightType = HeightRuleValues.Auto, Val = 32 };
            Assert.IsFalse(new TableRowHeightComparer(a, b).Compare());
        }

        [Test]
        public void TableRowHeightComparerHeightTypeWrongTest()
        {
            var a = new TableRowHeight() { HeightType = HeightRuleValues.AtLeast, Val = 32 };
            var b = new TableRowHeight() { HeightType = HeightRuleValues.Auto, Val = 32 };
            Assert.IsFalse(new TableRowHeightComparer(a, b).Compare());
        }
    }
}
