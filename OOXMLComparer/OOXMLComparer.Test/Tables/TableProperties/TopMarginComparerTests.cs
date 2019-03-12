using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Tables.TableProperties;

namespace OOXMLComparer.Test.Tables.TableProperties
{
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
}
