using DocumentFormat.OpenXml.Drawing;
using NUnit.Framework;
using OOXMLComparer.Drawing;

namespace OOXMLComparer.Test
{
    public class BlipFillComparerTests
    {
        [Test]
        public void BlipFillComparerTest()
        {
            var a = new BlipFill();
            var b = new BlipFill();
            Assert.IsTrue(new BlipFillComparer(a, b).Compare());
        }

        [Test]
        public void BlipFillComparerNullTest()
        {
            var a = new BlipFill();
            Assert.IsFalse(new BlipFillComparer(a, null).Compare());
            Assert.IsFalse(new BlipFillComparer(null, a).Compare());
            Assert.IsTrue(new BlipFillComparer(null, null).Compare());
        }

        [Test]
        public void BlipFillComparerAddSourceRectangleTest()
        {
            var a = new BlipFill() { SourceRectangle = new SourceRectangle() };
            var b = new BlipFill() { SourceRectangle = new SourceRectangle() };
            Assert.IsTrue(new BlipFillComparer(a, b).Compare());
        }

        [Test]
        public void BlipFillComparerAddSourceRectangleWrongTest()
        {
            var a = new BlipFill() { SourceRectangle = new SourceRectangle() };
            var b = new BlipFill();
            Assert.IsFalse(new BlipFillComparer(a, b).Compare());
        }

        [Test]
        public void BlipFillComparerAddStretchTest()
        {
            var a = new BlipFill(new Stretch());
            var b = new BlipFill(new Stretch());
            Assert.IsTrue(new BlipFillComparer(a, b).Compare());
        }

        [Test]
        public void BlipFillComparerAddStretchWrongTest()
        {
            var a = new BlipFill(new Stretch(new DocumentFormat.OpenXml.Drawing.FillRectangle()));
            var b = new BlipFill();
            Assert.IsFalse(new BlipFillComparer(a, b).Compare());
        }

        [Test]
        public void BlipFillComparerWrongTest()
        {
            var a = new BlipFill(new Stretch(new DocumentFormat.OpenXml.Drawing.FillRectangle())) { SourceRectangle = new SourceRectangle() };
            var b = new BlipFill() { SourceRectangle = new SourceRectangle() };
            Assert.IsFalse(new BlipFillComparer(a, b).Compare());
        }
    }
}