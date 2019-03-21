using DocumentFormat.OpenXml.Drawing.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Drawing;

namespace OOXMLComparer.Test
{
    [Category("OOXML")]
    public class DocPropertiesComparerTests
    {
        [Test]
        public void NonVisualDrawingPropertiesComparerTest()
        {
            var a = new DocProperties();
            var b = new DocProperties();
            Assert.IsTrue(new DocPropertiesComparer(a, b).Compare());
            a.Hidden = true;
            b.Hidden = true;
            Assert.IsTrue(new DocPropertiesComparer(a, b).Compare());
        }

        [Test]
        public void NonVisualDrawingPropertiesComparerNullTest()
        {
            var a = new DocProperties();
            Assert.IsTrue(new DocPropertiesComparer(a, null).Compare());
        }

        [Test]
        public void NonVisualDrawingPropertiesComparerWrongTest()
        {
            var a = new DocProperties() { Hidden = true };
            var b = new DocProperties();
            Assert.IsFalse(new DocPropertiesComparer(a, b).Compare());
        }
    }
}
