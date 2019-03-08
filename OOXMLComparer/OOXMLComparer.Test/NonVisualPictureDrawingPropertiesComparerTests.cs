using DocumentFormat.OpenXml.Drawing.Pictures;
using NUnit.Framework;
using OOXMLComparer.Drawing;

namespace OOXMLComparer.Test
{
    public class NonVisualPictureDrawingPropertiesComparerTests
    {
        [Test]
        public void NonVisualPictureDrawingPropertiesComparerTest()
        {
            var a = new NonVisualPictureDrawingProperties();
            var b = new NonVisualPictureDrawingProperties();
            Assert.IsTrue(new NonVisualPictureDrawingPropertiesComparer(a, b).Compare());
        }

        [Test]
        public void NonVisualPictureDrawingPropertiesComparer2Test()
        {
            var a = new NonVisualPictureDrawingProperties() { PreferRelativeResize = true };
            var b = new NonVisualPictureDrawingProperties() {PreferRelativeResize = true};
            Assert.IsTrue(new NonVisualPictureDrawingPropertiesComparer(a, b).Compare());
        }

        [Test]
        public void NonVisualPictureDrawingPropertiesComparer_PreferRelativeResizeNullTest()
        {
            var a = new NonVisualPictureDrawingProperties() { PreferRelativeResize = false };
            var b = new NonVisualPictureDrawingProperties();
            Assert.IsTrue(new NonVisualPictureDrawingPropertiesComparer(a, b).Compare());
        }

        [Test]
        public void NonVisualPictureDrawingPropertiesComparerNullTest()
        {
            var a = new NonVisualPictureDrawingProperties();
            Assert.IsTrue(new NonVisualPictureDrawingPropertiesComparer(a, null).Compare());
            Assert.IsTrue(new NonVisualPictureDrawingPropertiesComparer(null, a).Compare());
            Assert.IsTrue(new NonVisualPictureDrawingPropertiesComparer(null, null).Compare());
            a.PreferRelativeResize = true;
            Assert.IsFalse(new NonVisualPictureDrawingPropertiesComparer(a, null).Compare());
            Assert.IsFalse(new NonVisualPictureDrawingPropertiesComparer(null, a).Compare());
        }

        [Test]
        public void NonVisualPictureDrawingPropertiesComparerWrongTest()
        {
            var a = new NonVisualPictureDrawingProperties() { PreferRelativeResize = true };
            var b = new NonVisualPictureDrawingProperties() { PreferRelativeResize = false };
            Assert.IsFalse(new NonVisualPictureDrawingPropertiesComparer(a, b).Compare());
        }

        [Test]
        public void NonVisualPictureDrawingPropertiesComparerChildTest()
        {
            var a = new NonVisualPictureDrawingProperties(new DocumentFormat.OpenXml.Drawing.PictureLocks()) { PreferRelativeResize = true };
            var b = new NonVisualPictureDrawingProperties() { PreferRelativeResize = true };
            Assert.IsTrue(new NonVisualPictureDrawingPropertiesComparer(a, b).Compare());
        }

        [Test]
        public void NonVisualPictureDrawingPropertiesComparerWrongChildTest()
        {
            var a = new NonVisualPictureDrawingProperties(new DocumentFormat.OpenXml.Drawing.PictureLocks() {NoAdjustHandles = true }) { PreferRelativeResize = true };
            var b = new NonVisualPictureDrawingProperties() { PreferRelativeResize = true };
            Assert.IsFalse(new NonVisualPictureDrawingPropertiesComparer(a, b).Compare());
        }
    }
}
