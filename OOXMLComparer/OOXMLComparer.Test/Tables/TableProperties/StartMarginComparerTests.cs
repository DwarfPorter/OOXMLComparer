using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Tables.TableProperties;

namespace OOXMLComparer.Test.Tables.TableProperties
{
    [Category("OOXML")]
    public class StartMarginComparerTests
    {
        [Test]
        public void StartMarginComparerTest()
        {
            var a = new StartMargin();
            var b = new StartMargin();
            Assert.IsTrue(ComparerFactory.Create(a, b).Compare());
        }
    }
}
