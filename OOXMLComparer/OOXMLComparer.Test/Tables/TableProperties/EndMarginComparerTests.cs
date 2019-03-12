using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Tables.TableProperties;

namespace OOXMLComparer.Test.Tables.TableProperties
{
    public class EndMarginComparerTests
    {
        [Test]
        public void EndMarginComparerTest()
        {
            var a = new EndMargin();
            var b = new EndMargin();
            Assert.IsTrue(new EndMarginComparer(a, b).Compare());
        }
    }
}
