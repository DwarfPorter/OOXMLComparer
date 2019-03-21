using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Common;

namespace OOXMLComparer.Test.Paragraphs
{
    [Category("OOXML")]
    public class BottomBorderComparerTests
    {
        [Test]
        public void BottomBorderComparerTest()
        {
            var a = new BottomBorder();
            var b = new BottomBorder();
            Assert.IsTrue(new BottomBorderComparer(a, b).Compare());
        }

        [Test]
        public void BottomBorderComparerValWrongTest()
        {
            var a = new BottomBorder() { Val = BorderValues.BabyRattle };
            var b = new BottomBorder() { Val = BorderValues.Cabins };
            Assert.IsFalse(new BottomBorderComparer(a, b).Compare());
        }

        [Test]
        public void BottomBorderComparerSizeWrongTest()
        {
            var a = new BottomBorder() { Size = 2 };
            var b = new BottomBorder() { Size = 1 };
            Assert.IsFalse(new BottomBorderComparer(a, b).Compare());
        }

        [Test]
        public void BottomBorderComparerSpaceWrongTest()
        {
            var a = new BottomBorder() { Space = 2 };
            var b = new BottomBorder();
            Assert.IsFalse(new BottomBorderComparer(a, b).Compare());
        }

        [Test]
        public void BottomBorderComparerColorWrongTest()
        {
            var a = new BottomBorder() { Color = "Auto" };
            var b = new BottomBorder();
            Assert.IsFalse(new BottomBorderComparer(a, b).Compare());
        }
    }
}
