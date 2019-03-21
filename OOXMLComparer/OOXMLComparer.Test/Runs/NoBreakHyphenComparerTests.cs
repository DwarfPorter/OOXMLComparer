using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Texts;

namespace OOXMLComparer.Test.Runs
{
    [Category("OOXML")]
    public class NoBreakHyphenComparerTests
    {
        [Test]
        public void NoBreakHyphenComparerTest()
        {
            var a = new NoBreakHyphen();
            var b = new NoBreakHyphen();
            Assert.IsTrue(ComparerFactory.Create(a, b).Compare());
            Assert.IsFalse(new NoBreakHyphenComparer(a, null).Compare());
        }
    }

}