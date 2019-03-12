using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Properties;

namespace OOXMLComparer.Test.Runs
{
    public class FontSizeComparerTests
    {
        [Test]
        public void FontSizeComparerTest()
        {
            var a = new FontSize { Val = "5" };
            var b = new FontSize { Val = "5" };
            var fontSizeComparer = new FontSizeComparer(a, b);
            Assert.IsTrue(fontSizeComparer.Compare());
            Assert.IsTrue(new FontSizeComparer(null, null).Compare());
        }

        [Test]
        public void FontSizeComparerWrongTest()
        {
            var a = new FontSize { Val = "5" };
            var b = new FontSize { Val = "6" };
            var fontSizeComparer = new FontSizeComparer(a, b);
            Assert.IsFalse(fontSizeComparer.Compare());
            Assert.IsFalse(new FontSizeComparer(a, null).Compare());
            Assert.IsFalse(new FontSizeComparer(null, b).Compare());
        }
    }
}
