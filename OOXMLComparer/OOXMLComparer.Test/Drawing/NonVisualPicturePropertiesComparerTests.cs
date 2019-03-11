using DocumentFormat.OpenXml.Drawing.Pictures;
using NUnit.Framework;
using OOXMLComparer.Drawing;

namespace OOXMLComparer.Test
{
    public class NonVisualPicturePropertiesComparerTests
    {
        [Test]
        public void NonVisualPicturePropertiesComparerTest()
        {
            var a = new NonVisualPictureProperties();
            var b = new NonVisualPictureProperties();
            Assert.IsTrue(new NonVisualPicturePropertiesComparer(a, b).Compare());
        }

        [Test]
        public void NonVisualPicturePropertiesComparerHappyTest()
        { 
            var a = new NonVisualPictureProperties(new NonVisualPictureDrawingProperties() { PreferRelativeResize = true });
            var b = new NonVisualPictureProperties(new NonVisualPictureDrawingProperties() { PreferRelativeResize = true });
            Assert.IsTrue(new NonVisualPicturePropertiesComparer(a, b).Compare());
        }

        [Test]
        public void NonVisualPicturePropertiesComparerNullTest()
        {
            var a = new NonVisualPictureProperties();
            Assert.IsTrue(new NonVisualPicturePropertiesComparer(a, null).Compare());
            Assert.IsTrue(new NonVisualPicturePropertiesComparer(null, a).Compare());
            Assert.IsTrue(new NonVisualPicturePropertiesComparer(null, null).Compare());
        }

        [Test]
        public void NonVisualPicturePropertiesComparerWrongTest()
        {
            var a = new NonVisualPictureProperties(new NonVisualPictureDrawingProperties() { PreferRelativeResize = true });
            var b = new NonVisualPictureProperties(new NonVisualPictureDrawingProperties() { PreferRelativeResize = false });
            Assert.IsFalse(new NonVisualPicturePropertiesComparer(a, b).Compare());
        }
    }
}
