using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Paragraphs.ParaProperties;

namespace OOXMLComparer.Test.Paragraphs
{
    public class FramePropertiesComparerTests
    {
        [Test]
        public void FramePropertiesComparerTest()
        {
            var a = new FrameProperties();
            var b = new FrameProperties();
            Assert.IsTrue(new FramePropertiesComparer(a, b).Compare());
        }

        [Test]
        public void FramePropertiesComparerNullTest()
        {
            var a = new FrameProperties();
            Assert.IsFalse(new FramePropertiesComparer(a, null).Compare());
            Assert.IsFalse(new FramePropertiesComparer(null, a).Compare());
            Assert.IsTrue(new FramePropertiesComparer(null, null).Compare());
        }

        [Test]
        public void FramePropertiesComparerHappyTest()
        {
            var a = new FrameProperties()
            {
                Width = "50",
                Height = 42,
                HeightType = HeightRuleValues.Auto,
                HorizontalSpace = "42",
                Wrap = TextWrappingValues.None,
                HorizontalPosition = HorizontalAnchorValues.Text,
                VerticalPosition = VerticalAnchorValues.Text,
                VerticalSpace = "42",
                AnchorLock = true,
                X = "42",
                Y = "42",
                YAlign = VerticalAlignmentValues.Center,
                XAlign = HorizontalAlignmentValues.Center
            };
            var b = new FrameProperties()
            {
                Width = "50",
                Height = 42,
                HeightType = HeightRuleValues.Auto,
                HorizontalSpace = "42",
                Wrap = TextWrappingValues.None,
                HorizontalPosition = HorizontalAnchorValues.Text,
                VerticalPosition = VerticalAnchorValues.Text,
                VerticalSpace = "42",
                AnchorLock = true,
                X = "42",
                Y = "42",
                YAlign = VerticalAlignmentValues.Center,
                XAlign = HorizontalAlignmentValues.Center

            };
            Assert.IsTrue(new FramePropertiesComparer(a, b).Compare());
        }


        [Test]
        public void FramePropertiesComparerWidthWrongTest()
        {
            var a = new FrameProperties() { Width = "50" };
            var b = new FrameProperties() { Width = "40" };
            Assert.IsFalse(new FramePropertiesComparer(a, b).Compare());
        }

        [Test]
        public void FramePropertiesComparerHeightWrongTest()
        {
            var a = new FrameProperties() { Height = 50 };
            var b = new FrameProperties() { Height = 40 };
            Assert.IsFalse(new FramePropertiesComparer(a, b).Compare());
        }

        [Test]
        public void FramePropertiesComparerHeightTypeWrongTest()
        {
            var a = new FrameProperties() { HeightType = HeightRuleValues.Auto };
            var b = new FrameProperties() { HeightType = HeightRuleValues.Exact };
            Assert.IsFalse(new FramePropertiesComparer(a, b).Compare());
        }

        [Test]
        public void FramePropertiesComparerHorSpaceWrongTest()
        {
            var a = new FrameProperties() { HorizontalSpace = "30"};
            var b = new FrameProperties();
            Assert.IsFalse(new FramePropertiesComparer(a, b).Compare());
        }

        [Test]
        public void FramePropertiesComparerWrapWrongTest()
        {
            var a = new FrameProperties() { Wrap = TextWrappingValues.Auto };
            var b = new FrameProperties() { Wrap = TextWrappingValues.Around };
            Assert.IsFalse(new FramePropertiesComparer(a, b).Compare());
        }

        [Test]
        public void FramePropertiesComparerHorPositionWrongTest()
        {
            var a = new FrameProperties() { HorizontalPosition = HorizontalAnchorValues.Margin };
            var b = new FrameProperties() { HorizontalPosition = HorizontalAnchorValues.Page };
            Assert.IsFalse(new FramePropertiesComparer(a, b).Compare());
        }

        [Test]
        public void FramePropertiesComparerVerPositionWrongTest()
        {
            var a = new FrameProperties() { VerticalPosition = VerticalAnchorValues.Margin };
            var b = new FrameProperties() { VerticalPosition = VerticalAnchorValues.Page };
            Assert.IsFalse(new FramePropertiesComparer(a, b).Compare());
        }

        [Test]
        public void FramePropertiesComparerVerSpaceWrongTest()
        {
            var a = new FrameProperties() { VerticalSpace = "42" };
            var b = new FrameProperties() { VerticalSpace = "21" };
            Assert.IsFalse(new FramePropertiesComparer(a, b).Compare());
        }

        [Test]
        public void FramePropertiesComparerAnchorLockWrongTest()
        {
            var a = new FrameProperties() { AnchorLock = true };
            var b = new FrameProperties() { AnchorLock = false };
            Assert.IsFalse(new FramePropertiesComparer(a, b).Compare());
        }

        [Test]
        public void FramePropertiesComparerXWrongTest()
        {
            var a = new FrameProperties() { X = "30" };
            var b = new FrameProperties() { X = "42" };
            Assert.IsFalse(new FramePropertiesComparer(a, b).Compare());
        }

        [Test]
        public void FramePropertiesComparerYWrongTest()
        {
            var a = new FrameProperties() { Y = "30" };
            var b = new FrameProperties() { Y = "42" };
            Assert.IsFalse(new FramePropertiesComparer(a, b).Compare());
        }

        [Test]
        public void FramePropertiesComparerYAlignWrongTest()
        {
            var a = new FrameProperties() { YAlign = VerticalAlignmentValues.Bottom };
            var b = new FrameProperties() { YAlign = VerticalAlignmentValues.Inline };
            Assert.IsFalse(new FramePropertiesComparer(a, b).Compare());
        }

        [Test]
        public void FramePropertiesComparerXAlignWrongTest()
        {
            var a = new FrameProperties() { XAlign = HorizontalAlignmentValues.Left };
            var b = new FrameProperties() { XAlign = HorizontalAlignmentValues.Outside };
            Assert.IsFalse(new FramePropertiesComparer(a, b).Compare());
        }
    }
}
