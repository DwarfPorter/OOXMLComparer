using DocumentFormat.OpenXml.Drawing;
using NUnit.Framework;
using OOXMLComparer.Drawing;

namespace OOXMLComparer.Test
{
    [Category("OOXML")]
    public class ExtentsComparerTests
    {
        [Test]
        public void ExtentsComparerTest()
        {
            var a = new Extents { Cx = 555, Cy = 666 };
            var b = new Extents { Cx = 555, Cy = 666 };
            Assert.IsTrue(new ExtentsComparer(a, b).Compare());
        }

        [Test]
        public void ExtentsComparerNullTest()
        {
            var f = new Extents { Cx = 0, Cy = 0 };
            Assert.IsTrue(new ExtentsComparer(f, null).Compare());
        }

        [Test]
        public void ExtentsComparerNullParamsTest()
        { 
            var c = new Extents { Cx = null, Cy = null };
            var d = new Extents { Cx = 0, Cy = 0 };
            Assert.IsTrue(new ExtentsComparer(c, d).Compare());
        }

        [Test]
        public void ExtentsComparerWrongTest()
        {
            var a = new Extents { Cx = 555, Cy = 555 };
            var b = new Extents { Cx = 666, Cy = 555 };
            Assert.IsFalse(new ExtentsComparer(a, b).Compare());
            Assert.IsFalse(new ExtentsComparer(a, null).Compare());
        }
    }
}