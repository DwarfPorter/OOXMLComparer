using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Tables.TableProperties;

namespace OOXMLComparer.Test.Tables.TableProperties
{
    [Category("OOXML")]
    public class RightMarginComparerTests
    {
        [Test]
        public void RightMarginComparerTest()
        {
            var a = new RightMargin();
            var b = new RightMargin();
            Assert.IsTrue(new RightMarginComparer(a, b).Compare());
        }

        [Test]
        public void RightMarginComparerWrongTest()
        {
            var a = new RightMargin() { Width = "2" };
            var b = new RightMargin() { Width = "5" };
            Assert.IsFalse(new RightMarginComparer(a, b).Compare());
        }
    }
}
