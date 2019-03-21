using DocumentFormat.OpenXml.Drawing;
using NUnit.Framework;
using OOXMLComparer.Drawing;

namespace OOXMLComparer.Test
{
    [Category("OOXML")]
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
        public void PictureLocksComparerNullTest()
        {
            var a = new PictureLocks();
            Assert.IsTrue(new PictureLocksComparer(a, null).Compare());
            a.NoRotation = true;
            Assert.IsFalse(new PictureLocksComparer(a, null).Compare());

        }

        [Test]
        public void PictureLocksComparerHappyNullTest()
        {
            var a = new PictureLocks() { NoChangeShapeType = true };
            var b = new PictureLocks();
            Assert.IsFalse(new PictureLocksComparer(a, b).Compare());
        }

        [Test]
        public void PictureLocksComparer_DefaultNullTest()
        {
            var a = new PictureLocks()
            {
                NoChangeShapeType = false,
                NoAdjustHandles = false,
                NoChangeArrowheads = false,
                NoChangeAspect = false,
                NoCrop = false,
                NoEditPoints = false,
                NoGrouping = false,
                NoMove = false,
                NoResize = false,
                NoRotation = false,
                NoSelection = false
            };
            var b = new PictureLocks();
            Assert.IsTrue(new PictureLocksComparer(a, b).Compare());
        }

        [Test]
        public void PictureLocksComparer_NoChangeShapeTypeWrongTest()
        {
            var a = new PictureLocks() { NoChangeShapeType = true };
            var b = new PictureLocks();
            Assert.IsFalse(new PictureLocksComparer(a, b).Compare());
        }

        [Test]
        public void PictureLocksComparer_NoChangeArrowheadsWrongTest()
        {
            var a = new PictureLocks() { NoChangeArrowheads = true };
            var b = new PictureLocks();
            Assert.IsFalse(new PictureLocksComparer(a, b).Compare());
        }

        [Test]
        public void PictureLocksComparer_NoAdjustHandlesWrongTest()
        {
            var a = new PictureLocks() { NoAdjustHandles = true };
            var b = new PictureLocks();
            Assert.IsFalse(new PictureLocksComparer(a, b).Compare());
        }

        [Test]
        public void PictureLocksComparer_NoEditPointsWrongTest()
        {
            var a = new PictureLocks() { NoEditPoints = true };
            var b = new PictureLocks();
            Assert.IsFalse(new PictureLocksComparer(a, b).Compare());
        }

        [Test]
        public void PictureLocksComparer_NoResizeWrongTest()
        {
            var a = new PictureLocks() { NoResize = true };
            var b = new PictureLocks();
            Assert.IsFalse(new PictureLocksComparer(a, b).Compare());
        }

        [Test]
        public void PictureLocksComparer_NoMoveWrongTest()
        {
            var a = new PictureLocks() { NoMove = true };
            var b = new PictureLocks();
            Assert.IsFalse(new PictureLocksComparer(a, b).Compare());
        }

        [Test]
        public void PictureLocksComparer_NoRotationWrongTest()
        {
            var a = new PictureLocks() { NoRotation = true };
            var b = new PictureLocks();
            Assert.IsFalse(new PictureLocksComparer(a, b).Compare());
        }

        [Test]
        public void PictureLocksComparer_NoSelectionWrongTest()
        {
            var a = new PictureLocks() { NoSelection = true };
            var b = new PictureLocks();
            Assert.IsFalse(new PictureLocksComparer(a, b).Compare());
        }

        [Test]
        public void PictureLocksComparer_NoGroupingWrongTest()
        {
            var a = new PictureLocks() { NoGrouping = true };
            var b = new PictureLocks();
            Assert.IsFalse(new PictureLocksComparer(a, b).Compare());
        }

        [Test]
        public void PictureLocksComparer_NoChangeAspectWrongTest()
        {
            var a = new PictureLocks() { NoChangeAspect = true };
            var b = new PictureLocks();
            Assert.IsFalse(new PictureLocksComparer(a, b).Compare());
        }
    }
}