using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Properties;

namespace OOXMLComparer.Test.Runs
{
    [Category("OOXML")]
    public class RunFontsCompareTests
    {
        [Test]
        public void RunFontsComparerTest()
        {
            var a = new RunFonts() { Ascii = "Arial", HighAnsi = "Calibri" };
            var b = new RunFonts() { Ascii = "Arial", HighAnsi = "Calibri" };
            var fontComparer = new RunFontsComparer(a, b);
            Assert.IsTrue(fontComparer.Compare());
        }

        [Test]
        public void RunFontsComparerWrongTest()
        {
            var a = new RunFonts() { Ascii = "Arial" };
            var b = new RunFonts() { Ascii = "Arial", HighAnsi = "Calibri" };
            var fontComparer = new RunFontsComparer(a, b);
            Assert.IsFalse(fontComparer.Compare());
            Assert.IsFalse(new RunFontsComparer(a, null).Compare());
        }
    }
}