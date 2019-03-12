using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Tables.TableProperties;

namespace OOXMLComparer.Test.Tables.TableProperties
{
    public class NoWrapComparerTests
    {
        [Test]
        public void NoWrapComparerTest()
        {
            var a = new NoWrap() { Val = OnOffOnlyValues.On };
            var b = new NoWrap() { Val = OnOffOnlyValues.On };
            Assert.IsTrue(new NoWrapComparer(a, b).Compare());
        }
        [Test]
        public void NoWrapComparerWrongTest()
        {
            var a = new NoWrap() { Val = OnOffOnlyValues.On };
            var b = new NoWrap();
            Assert.IsFalse(new NoWrapComparer(a, b).Compare());
        }
    }
}
