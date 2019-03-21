using DocumentFormat.OpenXml.Drawing;
using NUnit.Framework;
using OOXMLComparer.Drawing;

namespace OOXMLComparer.Test
{
    [Category("OOXML")]
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