using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Tables.TableProperties;

namespace OOXMLComparer.Test.Tables.TableProperties
{
    public class GridSpanComparerTests
    {
        [Test]
        public void GridSpanComparerTest()
        {
            var a = new GridSpan();
            var b = new GridSpan();
            Assert.IsTrue(new GridSpanComparer(a, b).Compare());
        }

        [Test]
        public void GridSpanComparerWrongTest()
        {
            var a = new GridSpan() { Val = 42 };
            var b = new GridSpan() { Val = 40 };
            Assert.IsFalse(new GridSpanComparer(a, b).Compare());
        }
    }
}
