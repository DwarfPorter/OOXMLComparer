using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Common;

namespace OOXMLComparer.Test.Paragraphs
{
    [Category("OOXML")]
    public class TopBorderComparerTests
    {
        [Test]
        public void TopBorderComparerTest()
        {
            var a = new TopBorder();
            var b = new TopBorder();
            Assert.IsTrue(new TopBorderComparer(a, b).Compare());
        }

        [Test]
        public void TopBorderComparerValWrongTest()
        {
            var a = new TopBorder() { Val = BorderValues.BabyRattle };
            var b = new TopBorder();
            Assert.IsFalse(new TopBorderComparer(a, b).Compare());
        }

        [Test]
        public void TopBorderComparerSizeWrongTest()
        {
            var a = new TopBorder() { Size = 2 };
            var b = new TopBorder();
            Assert.IsFalse(new TopBorderComparer(a, b).Compare());
        }

        [Test]
        public void TopBorderComparerSpaceWrongTest()
        {
            var a = new TopBorder() { Space = 2 };
            var b = new TopBorder() { Space = 6 };
            Assert.IsFalse(new TopBorderComparer(a, b).Compare());
        }

        [Test]
        public void TopBorderComparerColorWrongTest()
        {
            var a = new TopBorder() { Color = "Auto" };
            var b = new TopBorder() { Color = "Blue" };
            Assert.IsFalse(new TopBorderComparer(a, b).Compare());
        }
    }
}
