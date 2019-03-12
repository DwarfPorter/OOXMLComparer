using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Texts;

namespace OOXMLComparer.Test.Runs
{
    public class NoBreakHyphenComparerTests
    {
        [Test]
        public void NoBreakHyphenComparerTest()
        {
            var a = new NoBreakHyphen();
            var b = new NoBreakHyphen();
            Assert.IsTrue(new NoBreakHyphenComparer(a, b).Compare());
            Assert.IsTrue(new NoBreakHyphenComparer(null, null).Compare());
            Assert.IsFalse(new NoBreakHyphenComparer(a, null).Compare());
            Assert.IsFalse(new NoBreakHyphenComparer(null, a).Compare());
        }
    }

}