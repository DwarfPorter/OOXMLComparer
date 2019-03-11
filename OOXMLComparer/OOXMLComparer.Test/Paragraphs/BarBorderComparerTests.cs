using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Paragraphs;

namespace OOXMLComparer.Test.Paragraphs
{
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
