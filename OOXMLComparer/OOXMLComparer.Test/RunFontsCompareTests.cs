using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Properties;

namespace OOXMLComparer.Test
{
    public class RunFontsCompareTests
    {
        [Test]
        public void RunFontsComparerTest()
        {
            var a = new RunFonts() { Ascii = "Arial", HighAnsi = "Calibri" };
            var b = new RunFonts() { Ascii = "Arial", HighAnsi = "Calibri" };
            var fontComparer = new RunFontsComparer();
            Assert.IsTrue(fontComparer.Compare(a, b));
            Assert.IsTrue(fontComparer.Compare(null, null));
        }

        [Test]
        public void RunFontsComparerWrongTest()
        {
            var a = new RunFonts() { Ascii = "Arial" };
            var b = new RunFonts() { Ascii = "Arial", HighAnsi = "Calibri" };
            var fontComparer = new RunFontsComparer();
            Assert.IsFalse(fontComparer.Compare(a, b));
            Assert.IsFalse(fontComparer.Compare(a, null));
            Assert.IsFalse(fontComparer.Compare(null, b));
        }

    }
}