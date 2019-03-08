using DocumentFormat.OpenXml.Drawing;
using NUnit.Framework;
using OOXMLComparer.Drawing;

namespace OOXMLComparer.Test
{
    public class NonVisualDrawingPropertiesComparerTests
    {
        [Test]
        public void NonVisualDrawingPropertiesComparerTest()
        {
            var a = new NonVisualDrawingProperties();
            var b = new NonVisualDrawingProperties();
            Assert.IsTrue(new NonVisualDrawingPropertiesComparer(a, b).Compare());
            a.Hidden = true;
            b.Hidden = true;
            Assert.IsTrue(new NonVisualDrawingPropertiesComparer(a, b).Compare());
        }

        [Test]
        public void NonVisualDrawingPropertiesComparerNullTest()
        {
            var a = new NonVisualDrawingProperties();
            Assert.IsTrue(new NonVisualDrawingPropertiesComparer(a, null).Compare());
            Assert.IsTrue(new NonVisualDrawingPropertiesComparer(null, a).Compare());
            Assert.IsTrue(new NonVisualDrawingPropertiesComparer(null, null).Compare());
        }

        [Test]
        public void NonVisualDrawingPropertiesComparerWrongTest()
        {
            var a = new NonVisualDrawingProperties() { Hidden = true };
            var b = new NonVisualDrawingProperties();
            Assert.IsFalse(new NonVisualDrawingPropertiesComparer(a, b).Compare());
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
