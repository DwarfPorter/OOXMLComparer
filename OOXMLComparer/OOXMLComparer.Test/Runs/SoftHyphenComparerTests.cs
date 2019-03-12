using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Texts;

namespace OOXMLComparer.Test.Runs
{
    public class SoftHyphenComparerTests
    {
        [Test]
        public void SoftHyphenComparerTest()
        {
            var a = new SoftHyphen();
            var b = new SoftHyphen();
            Assert.IsTrue(new SoftHyphenComparer(a, b).Compare());
            Assert.IsTrue(new SoftHyphenComparer(null, null).Compare());
            Assert.IsFalse(new SoftHyphenComparer(a, null).Compare());
            Assert.IsFalse(new SoftHyphenComparer(null, a).Compare());
        }
    }

}