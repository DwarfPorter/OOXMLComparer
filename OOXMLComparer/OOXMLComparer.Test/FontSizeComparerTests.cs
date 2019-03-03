using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Properties;

namespace OOXMLComparer.Test
{
    public class FontSizeComparerTests
    {
        [Test]
        public void FontSizeComparerTest()
        {
            var a = new FontSize { Val = "5" };
            var b = new FontSize { Val = "5" };
            var fontSizeComparer = new FontSizeComparer();
            Assert.IsTrue(fontSizeComparer.Compare(a, b));
            Assert.IsTrue(fontSizeComparer.Compare(null, null));
        }

        [Test]
        public void FontSizeComparerWrongTest()
        {
            var a = new FontSize { Val = "5" };
            var b = new FontSize { Val = "6" };
            var fontSizeComparer = new FontSizeComparer();
            Assert.IsFalse(fontSizeComparer.Compare(a, b));
            Assert.IsFalse(fontSizeComparer.Compare(a, null));
            Assert.IsFalse(fontSizeComparer.Compare(null, b));
        }
    }
}