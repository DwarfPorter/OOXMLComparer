using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Common;

namespace OOXMLComparer.Test.Paragraphs
{
    [Category("OOXML")]
    public class BarBorderComparerTests
    {
        [Test]
        public void BarBorderComparerTest()
        {
            var a = new BarBorder();
            var b = new BarBorder();
            Assert.IsTrue(new BarBorderComparer(a, b).Compare());
        }
    }
}
