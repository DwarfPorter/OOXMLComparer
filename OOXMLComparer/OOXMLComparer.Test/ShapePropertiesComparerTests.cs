using DocumentFormat.OpenXml.Drawing;
using NUnit.Framework;
using OOXMLComparer.Drawing;

namespace OOXMLComparer.Test
{
    public class ShapePropertiesComparerTests
    {
        [Test]
        public void ShapePropertiesComparerTest()
        {
            var a = new DocumentFormat.OpenXml.Drawing.Pictures.ShapeProperties();
            var b = new DocumentFormat.OpenXml.Drawing.Pictures.ShapeProperties();
            Assert.IsTrue(new ShapePropertiesComparer(a, b).Compare());

            a.BlackWhiteMode = BlackWhiteModeValues.Black;
            b.BlackWhiteMode = BlackWhiteModeValues.Black;
            Assert.IsTrue(new ShapePropertiesComparer(a, b).Compare());
        }

        [Test]
        public void ShapePropertiesComparerComplexTest()
        {
            var a = new DocumentFormat.OpenXml.Drawing.Pictures.ShapeProperties(
                new DocumentFormat.OpenXml.Drawing.Transform2D(
                    new DocumentFormat.OpenXml.Drawing.Offset() { X = 0L, Y = 0L },
                    new DocumentFormat.OpenXml.Drawing.Extents() { Cx = 42, Cy = 42 }
                    ),
                new DocumentFormat.OpenXml.Drawing.PresetGeometry(
                    new DocumentFormat.OpenXml.Drawing.AdjustValueList()
                ) { Preset = DocumentFormat.OpenXml.Drawing.ShapeTypeValues.Rectangle }
            ) { BlackWhiteMode = BlackWhiteModeValues.Black };
            var b = new DocumentFormat.OpenXml.Drawing.Pictures.ShapeProperties(
                new DocumentFormat.OpenXml.Drawing.Transform2D(
                    new DocumentFormat.OpenXml.Drawing.Extents() { Cx = 42, Cy = 42 }
                    ),
                new DocumentFormat.OpenXml.Drawing.PresetGeometry(
                    new DocumentFormat.OpenXml.Drawing.AdjustValueList()
                )
                { Preset = DocumentFormat.OpenXml.Drawing.ShapeTypeValues.Rectangle }
            ) { BlackWhiteMode = BlackWhiteModeValues.Black };

            Assert.IsTrue(new ShapePropertiesComparer(a, b).Compare());
        }

        [Test]
        public void ShapePropertiesComparerWrongTest()
        {
            var a = new DocumentFormat.OpenXml.Drawing.Pictures.ShapeProperties() { BlackWhiteMode = BlackWhiteModeValues.Black };
            var b = new DocumentFormat.OpenXml.Drawing.Pictures.ShapeProperties();
            Assert.IsFalse(new ShapePropertiesComparer(a, b).Compare());
        }

        [Test]
        public void ShapePropertiesComparerNullTest()
        {
            var a = new DocumentFormat.OpenXml.Drawing.Pictures.ShapeProperties() { BlackWhiteMode = BlackWhiteModeValues.Black };
            Assert.IsFalse(new ShapePropertiesComparer(a, null).Compare());
            Assert.IsFalse(new ShapePropertiesComparer(null, a).Compare());
            Assert.IsTrue(new ShapePropertiesComparer(null, null).Compare());
        }

        [Test]
        public void ShapePropertiesComparerComplexWrongTest()
        {
            var a = new DocumentFormat.OpenXml.Drawing.Pictures.ShapeProperties(
                new DocumentFormat.OpenXml.Drawing.Transform2D(
                    new DocumentFormat.OpenXml.Drawing.Offset() { X = 1L, Y = 0L },
                    new DocumentFormat.OpenXml.Drawing.Extents() { Cx = 42, Cy = 42 }
                    ),
                new DocumentFormat.OpenXml.Drawing.PresetGeometry(
                    new DocumentFormat.OpenXml.Drawing.AdjustValueList()
                )
                { Preset = DocumentFormat.OpenXml.Drawing.ShapeTypeValues.Rectangle }
            )
            { BlackWhiteMode = BlackWhiteModeValues.Black };
            var b = new DocumentFormat.OpenXml.Drawing.Pictures.ShapeProperties(
                new DocumentFormat.OpenXml.Drawing.Transform2D(
                    new DocumentFormat.OpenXml.Drawing.Extents() { Cx = 42, Cy = 42 }
                    ),
                new DocumentFormat.OpenXml.Drawing.PresetGeometry(
                    new DocumentFormat.OpenXml.Drawing.AdjustValueList()
                )
                { Preset = DocumentFormat.OpenXml.Drawing.ShapeTypeValues.Rectangle }
            )
            { BlackWhiteMode = BlackWhiteModeValues.Black };

            Assert.IsFalse(new ShapePropertiesComparer(a, b).Compare());
        }
    }
}