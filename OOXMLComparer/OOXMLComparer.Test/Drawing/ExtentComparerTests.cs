using DocumentFormat.OpenXml.Drawing.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Drawing;

namespace OOXMLComparer.Test
{
    public class ExtentComparerTests
    {
        [Test]
        public void ExtentComparerTest()
        {
            var a = new Extent { Cx = 555, Cy = 666 };
            var b = new Extent { Cx = 555, Cy = 666 };
            Assert.IsTrue(new ExtentComparer(a, b).Compare());
        }

        [Test]
        public void ExtentComparerNullTest()
        {
            var f = new Extent { Cx = 0, Cy = 0 };
            Assert.IsTrue(new ExtentComparer(f, null).Compare());
            Assert.IsTrue(new ExtentComparer(null, f).Compare());
        }

        [Test]
        public void ExtentComparerNullParamsTest()
        {
            var c = new Extent { Cx = null, Cy = null };
            var d = new Extent { Cx = 0, Cy = 0 };
            Assert.IsTrue(new ExtentComparer(c, d).Compare());
        }

        [Test]
        public void ExtentComparerWrongTest()
        {
            var a = new Extent { Cx = 555, Cy = 555 };
            var b = new Extent { Cx = 666, Cy = 555 };
            Assert.IsFalse(new ExtentComparer(a, b).Compare());
            Assert.IsFalse(new ExtentComparer(a, null).Compare());
            Assert.IsFalse(new ExtentComparer(null, a).Compare());
        }
    }
}