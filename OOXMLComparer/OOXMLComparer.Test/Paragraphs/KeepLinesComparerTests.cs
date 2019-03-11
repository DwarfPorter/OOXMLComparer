using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Paragraphs;

namespace OOXMLComparer.Test
{
    public class KeepLinesComparerTests
    {
        [Test]
        public void KeepLinesComparerTest()
        {
            var a = new KeepLines();
            var b = new KeepLines();
            Assert.IsTrue(new KeepLinesComparer(a, b).Compare());
        }

        [Test]
        public void KeepLinesComparerWrongTest()
        {
            var a = new KeepLines() { Val = true};
            var b = new KeepLines();
            Assert.IsFalse(new KeepLinesComparer(a, b).Compare());
        }
    }
}