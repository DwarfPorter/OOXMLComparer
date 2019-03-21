using DocumentFormat.OpenXml.Drawing;
using NUnit.Framework;
using OOXMLComparer.Drawing;

namespace OOXMLComparer.Test
{
    [Category("OOXML")]
    public class Transform2DComparerTests
    {
        [Test]
        public void Transform2DComparerTest()
        {
            var a = new Transform2D() { Offset = new Offset { X = 1L, Y = 0L }, Extents = new Extents { Cx = 444, Cy = 0 } };
            var b = new Transform2D(new Offset { X = 1L }, new Extents { Cx = 444 });
            Assert.IsTrue(new Transform2DComparer(a, b).Compare());
            Assert.IsTrue(new Transform2DComparer(new Transform2D(), null).Compare());
            Assert.IsTrue(new Transform2DComparer(new Transform2D() { Offset = new Offset { X = 0L, Y = 0L } }, new Transform2D()).Compare());
        }

        [Test]
        public void Transform2DComparerWrongTest()
        {
            var a = new Transform2D() { Offset = new Offset { X = 1L, Y = 0L }, Extents = new Extents { Cx = 444, Cy = 0 } };
            var b = new Transform2D(new Offset { X = 2L }, new Extents { Cx = 444 });
            Assert.IsFalse(new Transform2DComparer(a, b).Compare());
        }
    }
}