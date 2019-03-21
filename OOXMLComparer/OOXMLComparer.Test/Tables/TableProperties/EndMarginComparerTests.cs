using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Tables.TableProperties;

namespace OOXMLComparer.Test.Tables.TableProperties
{
    [Category("OOXML")]
    public class EndMarginComparerTests
    {
        [Test]
        public void EndMarginComparerTest()
        {
            var a = new EndMargin();
            var b = new EndMargin();
            Assert.IsTrue(ComparerFactory.Create(a, b).Compare());
        }
    }
}
