using NUnit.Framework;
using OOXMLComparer.Drawing;

namespace OOXMLComparer.Test
{
    [Category("OOXML")]
    public class DrawingComparerTests
    {
        [Test]
        public void DrawingComparerTest()
        {
            var a = new DocumentFormat.OpenXml.Wordprocessing.Drawing();
            var b = new DocumentFormat.OpenXml.Wordprocessing.Drawing();
            Assert.IsTrue(new DrawingComparer(a, b).Compare());
        }

        [Test]
        public void DrawingComparerChildrenTest()
        {
            var a = new DocumentFormat.OpenXml.Wordprocessing.Drawing(new DocumentFormat.OpenXml.Drawing.Wordprocessing.Inline() { DistanceFromBottom = 42 });
            var b = new DocumentFormat.OpenXml.Wordprocessing.Drawing(new DocumentFormat.OpenXml.Drawing.Wordprocessing.Inline() { DistanceFromBottom = 42 });
            Assert.IsTrue(new DrawingComparer(a, b).Compare());
        }

        [Test]
        public void DrawingComparerChildrenWrongTest()
        {
            var a = new DocumentFormat.OpenXml.Wordprocessing.Drawing(new DocumentFormat.OpenXml.Drawing.Wordprocessing.Inline() { DistanceFromBottom = 42 });
            var b = new DocumentFormat.OpenXml.Wordprocessing.Drawing();
            Assert.IsFalse(new DrawingComparer(a, b).Compare());
        }
    }
}