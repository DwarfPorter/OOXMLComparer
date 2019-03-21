using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Tables.TableProperties;

namespace OOXMLComparer.Test.Tables.TableProperties
{
    [Category("OOXML")]
    public class TopMarginComparerTests
    {
        [Test]
        public void TopMarginComparerTest()
        {
            var a = new TopMargin();
            var b = new TopMargin();
            Assert.IsTrue(new TopMarginComparer(a, b).Compare());
        }
    }
    public class CantSplitComparerTests
    {
        [Test]
        public void CantSplitComparerTest()
        {
            var a = new CantSplit();
            var b = new CantSplit();
            Assert.IsTrue(new CantSplitComparer(a, b).Compare());
        }
    }
}
