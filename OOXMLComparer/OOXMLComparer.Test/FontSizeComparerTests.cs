using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Drawing;
using OOXMLComparer.Properties;

namespace OOXMLComparer.Test
{
    public class FontSizeComparerTests
    {
        [Test]
        public void FontSizeComparerTest()
        {
            var a = new FontSize { Val = "5" };
            var b = new FontSize { Val = "5" };
            var fontSizeComparer = new FontSizeComparer(a, b);
            Assert.IsTrue(fontSizeComparer.Compare());
            Assert.IsTrue(new FontSizeComparer(null, null).Compare());
        }

        [Test]
        public void FontSizeComparerWrongTest()
        {
            var a = new FontSize { Val = "5" };
            var b = new FontSize { Val = "6" };
            var fontSizeComparer = new FontSizeComparer(a, b);
            Assert.IsFalse(fontSizeComparer.Compare());
            Assert.IsFalse(new FontSizeComparer(a, null).Compare());
            Assert.IsFalse(new FontSizeComparer(null, b).Compare());
        }
    }
    public class PictureLocksComparerTests
    {
        [Test]
        public void PictureLocksComparerTest()
        {
            var a = new PictureLocks();
            var b = new PictureLocks();
            Assert.IsTrue(new PictureLocksComparer(a, b).Compare());
        }

        [Test]
        public void PictureLocksComparer_NoChangeShapeTypeWrongTest()
        {
            var a = new PictureLocks() { NoChangeShapeType = true };
            var b = new PictureLocks();
            Assert.IsTrue(new PictureLocksComparer(a, b).Compare());
        }

        [Test]
        public void PictureLocksComparer_NoChangeArrowheadsWrongTest()
        {
            var a = new PictureLocks() { NoChangeArrowheads = true };
            var b = new PictureLocks();
            Assert.IsTrue(new PictureLocksComparer(a, b).Compare());
        }

        [Test]
        public void PictureLocksComparer_NoAdjustHandlesWrongTest()
        {
            var a = new PictureLocks() { NoAdjustHandles = true };
            var b = new PictureLocks();
            Assert.IsTrue(new PictureLocksComparer(a, b).Compare());
        }

        [Test]
        public void PictureLocksComparer_NoEditPointsWrongTest()
        {
            var a = new PictureLocks() { NoEditPoints = true };
            var b = new PictureLocks();
            Assert.IsTrue(new PictureLocksComparer(a, b).Compare());
        }

        [Test]
        public void PictureLocksComparer_NoResizeWrongTest()
        {
            var a = new PictureLocks() { NoResize = true };
            var b = new PictureLocks();
            Assert.IsTrue(new PictureLocksComparer(a, b).Compare());
        }

        [Test]
        public void PictureLocksComparer_NoMoveWrongTest()
        {
            var a = new PictureLocks() { NoMove = true };
            var b = new PictureLocks();
            Assert.IsTrue(new PictureLocksComparer(a, b).Compare());
        }

        [Test]
        public void PictureLocksComparer_NoRotationWrongTest()
        {
            var a = new PictureLocks() { NoRotation = true };
            var b = new PictureLocks();
            Assert.IsTrue(new PictureLocksComparer(a, b).Compare());
        }

        [Test]
        public void PictureLocksComparer_NoSelectionWrongTest()
        {
            var a = new PictureLocks() { NoSelection = true };
            var b = new PictureLocks();
            Assert.IsTrue(new PictureLocksComparer(a, b).Compare());
        }

        [Test]
        public void PictureLocksComparer_NoGroupingWrongTest()
        {
            var a = new PictureLocks() { NoGrouping = true };
            var b = new PictureLocks();
            Assert.IsTrue(new PictureLocksComparer(a, b).Compare());
        }

        [Test]
        public void PictureLocksComparer_NoChangeAspectWrongTest()
        {
            var a = new PictureLocks() { NoChangeAspect = true };
            var b = new PictureLocks();
            Assert.IsTrue(new PictureLocksComparer(a, b).Compare());
        }
        
    }
}
