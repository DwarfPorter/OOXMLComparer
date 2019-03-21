using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Common;

namespace OOXMLComparer.Test.Paragraphs
{
    [Category("OOXML")]
    public class RightBorderComparerTests
    {
        [Test]
        public void RightBorderComparerTest()
        {
            var a = new RightBorder();
            var b = new RightBorder();
            Assert.IsTrue(new RightBorderComparer(a, b).Compare());
        }
    }
}
