using DocumentFormat.OpenXml.Drawing;
using NUnit.Framework;
using OOXMLComparer.Drawing;

namespace OOXMLComparer.Test
{
    public class StretchComparerTests
    {
        [Test]
        public void StretchComparerTest()
        {
            var a = new Stretch();
            var b = new Stretch();
            Assert.IsTrue(new StretchComparer(a, b).Compare());
        }

        [Test]
        public void StretchComparerNullTest()
        {
            var a = new Stretch();
            Assert.IsTrue(new StretchComparer(a, null).Compare());
            Assert.IsTrue(new StretchComparer(null, a).Compare());
            Assert.IsTrue(new StretchComparer(null, null).Compare());
        }

        [Test]
        public void StretchComparerWrongTest()
        {
            var a = new Stretch() { FillRectangle = new FillRectangle() };
            var b = new Stretch();
            Assert.IsFalse(new StretchComparer(a, b).Compare());
            Assert.IsFalse(new StretchComparer(b, a).Compare());

            b = new Stretch(new FillRectangle());
            Assert.IsTrue(new StretchComparer(a, b).Compare());
        }
    }
}