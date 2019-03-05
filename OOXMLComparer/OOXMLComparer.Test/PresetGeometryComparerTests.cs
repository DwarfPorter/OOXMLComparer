using DocumentFormat.OpenXml.Drawing;
using NUnit.Framework;
using OOXMLComparer.Drawing;

namespace OOXMLComparer.Test
{
    public class PresetGeometryComparerTests
    {
        [Test]
        public void PresetGeometryComparerTest()
        {
            var a = new PresetGeometry { Preset = ShapeTypeValues.Rectangle };
            var b = new PresetGeometry { Preset = ShapeTypeValues.Rectangle };
            Assert.IsTrue(new PresetGeometryComparer(a, b).Compare());
            Assert.IsTrue(new PresetGeometryComparer(new PresetGeometry(), new PresetGeometry()).Compare());

            a = new PresetGeometry { Preset = ShapeTypeValues.Rectangle, AdjustValueList = new AdjustValueList() };
            b = new PresetGeometry { Preset = ShapeTypeValues.Rectangle, AdjustValueList = new AdjustValueList() };
            Assert.IsTrue(new PresetGeometryComparer(a, b).Compare());
        }

        public void PresetGeometryComparerWrongTest()
        {
            var a = new PresetGeometry { Preset = ShapeTypeValues.Rectangle };
            var b = new PresetGeometry();
            var c = new PresetGeometry { Preset = ShapeTypeValues.Ribbon };
            Assert.IsFalse(new PresetGeometryComparer(a, b).Compare());
            Assert.IsFalse(new PresetGeometryComparer(a, c).Compare());
        }

        public void PresetGeometryComparerNullTest()
        {
            var a = new PresetGeometry { Preset = ShapeTypeValues.Rectangle };
            Assert.IsFalse(new PresetGeometryComparer(a, null).Compare());
            Assert.IsFalse(new PresetGeometryComparer(null, a).Compare());
            Assert.IsTrue(new PresetGeometryComparer(null, null).Compare());
        }

    }
}