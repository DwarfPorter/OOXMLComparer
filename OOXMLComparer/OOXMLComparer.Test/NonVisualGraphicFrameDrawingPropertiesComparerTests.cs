using NUnit.Framework;
using OOXMLComparer.Drawing;

namespace OOXMLComparer.Test
{
    public class NonVisualGraphicFrameDrawingPropertiesComparerTests
    {
        [Test]
        public void NonVisualGraphicFrameDrawingPropertiesComparerTest()
        {
            var a = new DocumentFormat.OpenXml.Drawing.Wordprocessing.NonVisualGraphicFrameDrawingProperties();
            var b = new DocumentFormat.OpenXml.Drawing.Wordprocessing.NonVisualGraphicFrameDrawingProperties();
            Assert.IsTrue(new NonVisualGraphicFrameDrawingPropertiesComparer(a, b).Compare());
        }

        [Test]
        public void NonVisualGraphicFrameDrawingPropertiesComparerWrongTest()
        {
            var a = new DocumentFormat.OpenXml.Drawing.Wordprocessing.NonVisualGraphicFrameDrawingProperties()
            { GraphicFrameLocks = new DocumentFormat.OpenXml.Drawing.GraphicFrameLocks() { NoChangeAspect = true } };
            var b = new DocumentFormat.OpenXml.Drawing.Wordprocessing.NonVisualGraphicFrameDrawingProperties();
            Assert.IsFalse(new NonVisualGraphicFrameDrawingPropertiesComparer(a, b).Compare());
        }

        [Test]
        public void NonVisualGraphicFrameDrawingPropertiesComparerHappyTest()
        {
            var a = new DocumentFormat.OpenXml.Drawing.Wordprocessing.NonVisualGraphicFrameDrawingProperties()
            { GraphicFrameLocks = new DocumentFormat.OpenXml.Drawing.GraphicFrameLocks() { NoChangeAspect = true } };
            var b = new DocumentFormat.OpenXml.Drawing.Wordprocessing.NonVisualGraphicFrameDrawingProperties()
            { GraphicFrameLocks = new DocumentFormat.OpenXml.Drawing.GraphicFrameLocks() { NoChangeAspect = true } };
            Assert.IsTrue(new NonVisualGraphicFrameDrawingPropertiesComparer(a, b).Compare());
        }
    }
}