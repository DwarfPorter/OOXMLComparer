using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Texts;

namespace OOXMLComparer.Test.Runs
{
    [Category("OOXML")]
    public class SoftHyphenComparerTests
    {
        [Test]
        public void SoftHyphenComparerTest()
        {
            var a = new SoftHyphen();
            var b = new SoftHyphen();
            Assert.IsTrue(new SoftHyphenComparer(a, b).Compare());
            Assert.IsFalse(new SoftHyphenComparer(a, null).Compare());
        }
    }

}