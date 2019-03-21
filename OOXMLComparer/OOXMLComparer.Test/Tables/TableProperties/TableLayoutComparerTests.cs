using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Tables.TableProperties;

namespace OOXMLComparer.Test.Tables.TableProperties
{
    [Category("OOXML")]
    public class TableLayoutComparerTests
    {
        [Test]
        public void TableLayoutComparerTest()
        {
            var a = new TableLayout();
            var b = new TableLayout();
            Assert.IsTrue(new TableLayoutComparer(a, b).Compare());
        }

        [Test]
        public void TableLayoutComparerWrongTest()
        {
            var a = new TableLayout() { Type = TableLayoutValues.Fixed };
            var b = new TableLayout();
            Assert.IsFalse(new TableLayoutComparer(a, b).Compare());
        }

        [Test]
        public void TableLayoutComparerDefaultTest()
        {
            var a = new TableLayout() { Type = TableLayoutValues.Autofit };
            var b = new TableLayout();
            Assert.IsTrue(new TableLayoutComparer(a, b).Compare());
            Assert.IsTrue(new TableLayoutComparer(a, null).Compare());
        }
    }
}
