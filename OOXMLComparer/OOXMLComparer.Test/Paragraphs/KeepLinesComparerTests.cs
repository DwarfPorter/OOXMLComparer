using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Paragraphs.ParagraphProperties;

namespace OOXMLComparer.Test.Paragraphs
{
    [Category("OOXML")]
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

        [Test]
        public void KeepLinesComparerNullDefaultTest()
        {
            var a = new KeepLines() { Val = false };
            Assert.IsTrue(new KeepLinesComparer(a, null).Compare());
        }

        [Test]
        public void KeepLinesComparerNullTest()
        {
            var a = new KeepLines();
            Assert.IsTrue(new KeepLinesComparer(a, null).Compare());
        }

    }
}