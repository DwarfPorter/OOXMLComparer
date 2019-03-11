using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Paragraphs;

namespace OOXMLComparer.Test.Paragraphs
{
    public class TopBorderComparerTests
    {
        [Test]
        public void BottomBorderComparerTest()
        {
            var a = new TopBorder();
            var b = new TopBorder();
            Assert.IsTrue(new TopBorderComparer(a, b).Compare());
        }

        [Test]
        public void BottomBorderComparerValWrongTest()
        {
            var a = new TopBorder() { Val = BorderValues.BabyRattle };
            var b = new TopBorder();
            Assert.IsFalse(new TopBorderComparer(a, b).Compare());
        }

        [Test]
        public void BottomBorderComparerSizeWrongTest()
        {
            var a = new TopBorder() { Size = 2 };
            var b = new TopBorder();
            Assert.IsFalse(new TopBorderComparer(a, b).Compare());
        }

        [Test]
        public void BottomBorderComparerSpaceWrongTest()
        {
            var a = new TopBorder() { Space = 2 };
            var b = new TopBorder() { Space = 6 };
            Assert.IsFalse(new TopBorderComparer(a, b).Compare());
        }

        [Test]
        public void BottomBorderComparerColorWrongTest()
        {
            var a = new TopBorder() { Color = "Auto" };
            var b = new TopBorder() { Color = "Blue" };
            Assert.IsFalse(new TopBorderComparer(a, b).Compare());
        }
    }
    public class RightBorderComparerTests
    {
        [Test]
        public void BottomBorderComparerTest()
        {
            var a = new RightBorder();
            var b = new RightBorder();
            Assert.IsTrue(new RightBorderComparer(a, b).Compare());
        }
    }
    public class LeftBorderComparerTests
    {
        [Test]
        public void BottomBorderComparerTest()
        {
            var a = new LeftBorder();
            var b = new LeftBorder();
            Assert.IsTrue(new LeftBorderComparer(a, b).Compare());
        }
    }
}
