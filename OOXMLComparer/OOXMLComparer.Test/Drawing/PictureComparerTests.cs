using DocumentFormat.OpenXml.Drawing.Pictures;
using NUnit.Framework;
using OOXMLComparer.Drawing;

namespace OOXMLComparer.Test
{
    public class PictureComparerTests
    {
        [Test]
        public void PictureComparerTest()
        {
            var a = new Picture();
            var b = new Picture();
            Assert.IsTrue(new PictureComparer(a, b).Compare());
        }

        [Test]
        public void PictureComparerWrongTest()
        {
            var a = new Picture(new ShapeProperties { BlackWhiteMode = DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues.Black });
            var b = new Picture();
            Assert.IsFalse(new PictureComparer(a, b).Compare());
        }
    }
}
