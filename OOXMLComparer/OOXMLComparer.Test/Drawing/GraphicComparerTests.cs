using DocumentFormat.OpenXml.Drawing;
using NUnit.Framework;
using OOXMLComparer.Drawing;

namespace OOXMLComparer.Test
{
    [Category("OOXML")]
    public class GraphicComparerTests
    {
        [Test]
        public void GraphicComparerTest()
        {
            var a = new Graphic();
            var b = new Graphic();
            Assert.IsTrue(new GraphicComparer(a, b).Compare());
        }

        [Test]
        public void GraphicComparerWrongTest()
        {
            var a = new Graphic(
                new GraphicData(new DocumentFormat.OpenXml.Drawing.Pictures.Picture(
                                        new DocumentFormat.OpenXml.Drawing.Pictures.NonVisualPictureProperties(
                                            new DocumentFormat.OpenXml.Drawing.Pictures.NonVisualDrawingProperties(),
                                            new DocumentFormat.OpenXml.Drawing.Pictures.NonVisualPictureDrawingProperties(
                                                new DocumentFormat.OpenXml.Drawing.PictureLocks() { NoChangeAspect = true, NoChangeArrowheads = true })
                                            )
                                        )
                                    )
                                   );
            var b = new Graphic();
            Assert.IsFalse(new GraphicComparer(a, b).Compare());
        }
    }
}