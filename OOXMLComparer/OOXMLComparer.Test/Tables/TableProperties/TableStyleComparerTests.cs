using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Tables.TableProperties;

namespace OOXMLComparer.Test.Tables.TableProperties
{
    public class TableStyleComparerTests
    {
        [Test]
        public void TableStyleComparerTest()
        {
            var a = new TableStyle();
            var b = new TableStyle();
            Assert.IsTrue(new TableStyleComparer(a, b).Compare());
        }

        [Test]
        public void TableStyleComparerWrongTest()
        {
            var a = new TableStyle() { Val = "aa" };
            var b = new TableStyle();
            Assert.IsFalse(new TableStyleComparer(a, b).Compare());
        }
    }
}
