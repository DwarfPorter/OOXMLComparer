using DocumentFormat.OpenXml.Drawing.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Drawing;

namespace OOXMLComparer.Test
{
    [Category("OOXML")]
    public class EffectExtentComparerTests
    {
        [Test]
        public void EffectExtentComparerTest()
        {
            var a = new EffectExtent() { LeftEdge = 42, TopEdge = 21, RightEdge = 1, BottomEdge = 5 };
            var b = new EffectExtent() { LeftEdge = 42, TopEdge = 21, RightEdge = 1, BottomEdge = 5 };
            Assert.IsTrue(new EffectExtentComparer(a,b).Compare());
        }

        [Test]
        public void EffectExtentComparerWrongTest()
        {
            var a = new EffectExtent() { LeftEdge = 0, TopEdge = 21, RightEdge = 1, BottomEdge = 5 };
            var b = new EffectExtent() { LeftEdge = 42, TopEdge = 21, RightEdge = 1};
            Assert.IsFalse(new EffectExtentComparer(a, b).Compare());
        }

    }
}