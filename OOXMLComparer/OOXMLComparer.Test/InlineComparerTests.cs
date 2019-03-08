using DocumentFormat.OpenXml.Drawing.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Drawing;

namespace OOXMLComparer.Test
{
    public class InlineComparerTests
    {
        [Test]
        public void InlineComparerTest()
        {
            var a = new Inline ();
            var b = new Inline ();
            Assert.IsTrue(new InlineComparer(a, b).Compare());
        }

        [Test]
        public void InlineComparerHappyTest()
        {
            var a = new Inline() { DistanceFromBottom = 3, DistanceFromLeft = 2, DistanceFromRight = 0 };
            var b = new Inline() { DistanceFromBottom = 3, DistanceFromLeft = 2 };
            Assert.IsTrue(new InlineComparer(a, b).Compare());
        }

        [Test]
        public void InlineComparerWrongTest()
        {
            var a = new Inline() { DistanceFromBottom = 3, DistanceFromLeft = 2, DistanceFromRight = 0 };
            var b = new Inline() { DistanceFromBottom = 3, DistanceFromLeft = 1 };
            Assert.IsFalse(new InlineComparer(a, b).Compare());
            var c = new Inline(new DocumentFormat.OpenXml.Drawing.Wordprocessing.Extent() { Cx = 2, Cy = 2 });
            var d = new Inline();
            Assert.IsFalse(new InlineComparer(c, d).Compare());
        }

        [Test]
        public void InlineComparerappyChildrenTest()
        {
            var a = new Inline(new DocumentFormat.OpenXml.Drawing.Wordprocessing.Extent() { Cx = 2, Cy = 2 });
            var b = new Inline(new DocumentFormat.OpenXml.Drawing.Wordprocessing.Extent() { Cx = 2, Cy = 2 });
            Assert.IsTrue(new InlineComparer(a, b).Compare());
        }
    }
}