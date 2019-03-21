using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Common;

namespace OOXMLComparer.Test.Paragraphs
{
    [Category("OOXML")]
    public class BetweenBorderComparerTests
    {
        [Test]
        public void BetweenBorderComparerTest()
        {
            var a = new BetweenBorder();
            var b = new BetweenBorder();
            Assert.IsTrue(new BetweenBorderComparer(a, b).Compare());
        }
    }
}
