using DocumentFormat.OpenXml.Drawing;
using NUnit.Framework;
using OOXMLComparer.Drawing;

namespace OOXMLComparer.Test
{
    public class OffsetComparerTests
    {
        [Test]
        public void OffsetComparerTest()
        {
            var a = new Offset { X = 0L, Y = 0L };
            var b = new Offset { X = 0L, Y = 0L };
            var a1 = new Offset { X = 1L, Y = 1L };
            var b1 = new Offset { X = 1L, Y = 1L };
            Assert.IsTrue(new OffsetComparer(a, b).Compare());
            Assert.IsTrue(new OffsetComparer(a, null).Compare());
            Assert.IsTrue(new OffsetComparer(null, b).Compare());
            Assert.IsTrue(new OffsetComparer(null, null).Compare());
            Assert.IsTrue(new OffsetComparer(a1, b1).Compare());
            var c = new Offset();
            Assert.IsTrue(new OffsetComparer(a, c).Compare());
            var d = new Offset() { X = null, Y = 0 };
            Assert.IsTrue(new OffsetComparer(a, d).Compare());
        }

        [Test]
        public void OffsetComparerWrongTest()
        {
            var a = new Offset { X = 0L, Y = 0L };
            var b = new Offset { X = 1L, Y = 0L };
            Assert.IsFalse(new OffsetComparer(a, b).Compare());
            Assert.IsFalse(new OffsetComparer(b, null).Compare());
            Assert.IsFalse(new OffsetComparer(null, b).Compare());
            var d = new Offset() { X = null, Y = 1 };
            Assert.IsFalse(new OffsetComparer(a, d).Compare());
        }
    }
}