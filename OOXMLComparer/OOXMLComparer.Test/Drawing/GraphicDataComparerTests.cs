using DocumentFormat.OpenXml.Drawing;
using NUnit.Framework;
using OOXMLComparer.Drawing;

namespace OOXMLComparer.Test
{
    [Category("OOXML")]
    public class GraphicDataComparerTests
    {
        [Test]
        public void GraphicDataComparerTest()
        {
            var a = new GraphicData();
            var b = new GraphicData();
            Assert.IsTrue(new GraphicDataComparer(a, b).Compare());
        }

        [Test]
        public void GraphicDataComparerWrongTest()
        {
            var a = new GraphicData(new DocumentFormat.OpenXml.Drawing.Pictures.Picture(
                                        new DocumentFormat.OpenXml.Drawing.Pictures.NonVisualPictureProperties(
                                            new DocumentFormat.OpenXml.Drawing.Pictures.NonVisualDrawingProperties(),
                                            new DocumentFormat.OpenXml.Drawing.Pictures.NonVisualPictureDrawingProperties(
                                                new DocumentFormat.OpenXml.Drawing.PictureLocks() { NoChangeAspect = true, NoChangeArrowheads = true })
                                            )
                                        )
                                    );
            var b = new GraphicData();
            Assert.IsFalse(new GraphicDataComparer(a, b).Compare());
        }
    }
}