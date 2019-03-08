using DocumentFormat.OpenXml.Drawing;
using NUnit.Framework;
using OOXMLComparer.Drawing;

namespace OOXMLComparer.Test
{
    public class GraphicFrameLocksComparerTests
    {
        [Test]
        public void GraphicFrameLocksComparerTest()
        {
            var a = new GraphicFrameLocks();
            var b = new GraphicFrameLocks();
            Assert.IsTrue(new GraphicFrameLocksComparer(a, b).Compare());
        }

        [Test]
        public void GraphicFrameLocksComparerNullTest()
        {
            var a = new GraphicFrameLocks();
            Assert.IsTrue(new GraphicFrameLocksComparer(a, null).Compare());
            Assert.IsTrue(new GraphicFrameLocksComparer(null, a).Compare());
            Assert.IsTrue(new GraphicFrameLocksComparer(null, null).Compare());
            a.NoGrouping = true;
            Assert.IsFalse(new GraphicFrameLocksComparer(a, null).Compare());
            Assert.IsFalse(new GraphicFrameLocksComparer(null, a).Compare());
        }

        [Test]
        public void GraphicFrameLocksComparer_DefaultNullTest()
        {
            var a = new GraphicFrameLocks()
            {
                NoGrouping = false,
                NoDrilldown = false,
                NoChangeAspect = false,
                NoMove = false,
                NoResize = false,
                NoSelection = false
            };
            var b = new GraphicFrameLocks();
            Assert.IsTrue(new GraphicFrameLocksComparer(a, b).Compare());
        }

        [Test]
        public void GraphicFrameLocksComparer_NoGroupingWrongTest()
        {
            var a = new GraphicFrameLocks() { NoGrouping = true };
            var b = new GraphicFrameLocks();
            Assert.IsFalse(new GraphicFrameLocksComparer(a, b).Compare());
        }

        [Test]
        public void GraphicFrameLocksComparer_NoDrilldownWrongTest()
        {
            var a = new GraphicFrameLocks() { NoDrilldown = true };
            var b = new GraphicFrameLocks();
            Assert.IsFalse(new GraphicFrameLocksComparer(a, b).Compare());
        }

        [Test]
        public void GraphicFrameLocksComparer_NoChangeAspectWrongTest()
        {
            var a = new GraphicFrameLocks() { NoChangeAspect = true };
            var b = new GraphicFrameLocks();
            Assert.IsFalse(new GraphicFrameLocksComparer(a, b).Compare());
        }

        [Test]
        public void GraphicFrameLocksComparer_NoMoveWrongTest()
        {
            var a = new GraphicFrameLocks() { NoMove = true };
            var b = new GraphicFrameLocks();
            Assert.IsFalse(new GraphicFrameLocksComparer(a, b).Compare());
        }

        [Test]
        public void GraphicFrameLocksComparer_NoResizeWrongTest()
        {
            var a = new GraphicFrameLocks() { NoResize = true };
            var b = new GraphicFrameLocks();
            Assert.IsFalse(new GraphicFrameLocksComparer(a, b).Compare());
        }

        [Test]
        public void GraphicFrameLocksComparer_NoSelectionWrongTest()
        {
            var a = new GraphicFrameLocks() { NoSelection = true };
            var b = new GraphicFrameLocks();
            Assert.IsFalse(new GraphicFrameLocksComparer(a, b).Compare());
        }
    }
}