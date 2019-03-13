using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Tables.TableProperties;

namespace OOXMLComparer.Test.Tables.TableProperties
{
    public class TablePositionPropertiesComparerTests
    {
        [Test]
        public void TablePositionPropertiesComparerTest()
        {
            var a = new TablePositionProperties();
            var b = new TablePositionProperties();
            Assert.IsTrue(new TablePositionPropertiesComparer(a, b).Compare());
        }

        [Test]
        public void TablePositionPropertiesComparerHappyTest()
        {
            var a = new TablePositionProperties()
            {
                BottomFromText = 32,
                HorizontalAnchor = HorizontalAnchorValues.Margin,
                LeftFromText = 42,
                RightFromText = 38,
                TopFromText = 45,
                VerticalAnchor = VerticalAnchorValues.Page,
                TablePositionX = 3,
                TablePositionY = 34,
                TablePositionXAlignment = HorizontalAlignmentValues.Inside,
                TablePositionYAlignment = VerticalAlignmentValues.Inline
            };
            var b = new TablePositionProperties()
            {
                BottomFromText = 32,
                HorizontalAnchor = HorizontalAnchorValues.Margin,
                LeftFromText = 42,
                RightFromText = 38,
                TopFromText = 45,
                VerticalAnchor = VerticalAnchorValues.Page,
                TablePositionX = 3,
                TablePositionY = 34,
                TablePositionXAlignment = HorizontalAlignmentValues.Inside,
                TablePositionYAlignment = VerticalAlignmentValues.Inline
            };
            Assert.IsTrue(new TablePositionPropertiesComparer(a, b).Compare());
        }

        [Test]
        public void TablePositionPropertiesComparerBottomFromTextWrongTest()
        {
            var a = new TablePositionProperties()
            {
                BottomFromText = 2,
                HorizontalAnchor = HorizontalAnchorValues.Margin,
                LeftFromText = 42,
                RightFromText = 38,
                TopFromText = 45,
                VerticalAnchor = VerticalAnchorValues.Page,
                TablePositionX = 3,
                TablePositionY = 34,
                TablePositionXAlignment = HorizontalAlignmentValues.Inside,
                TablePositionYAlignment = VerticalAlignmentValues.Inline
            };
            var b = new TablePositionProperties()
            {
                BottomFromText = 32,
                HorizontalAnchor = HorizontalAnchorValues.Margin,
                LeftFromText = 42,
                RightFromText = 38,
                TopFromText = 45,
                VerticalAnchor = VerticalAnchorValues.Page,
                TablePositionX = 3,
                TablePositionY = 34,
                TablePositionXAlignment = HorizontalAlignmentValues.Inside,
                TablePositionYAlignment = VerticalAlignmentValues.Inline
            };
            Assert.IsFalse(new TablePositionPropertiesComparer(a, b).Compare());
        }

        [Test]
        public void TablePositionPropertiesComparerHorizontalAnchorFromTextWrongTest()
        {
            var a = new TablePositionProperties()
            {
                BottomFromText = 32,
                HorizontalAnchor = HorizontalAnchorValues.Text,
                LeftFromText = 42,
                RightFromText = 38,
                TopFromText = 45,
                VerticalAnchor = VerticalAnchorValues.Page,
                TablePositionX = 3,
                TablePositionY = 34,
                TablePositionXAlignment = HorizontalAlignmentValues.Inside,
                TablePositionYAlignment = VerticalAlignmentValues.Inline
            };
            var b = new TablePositionProperties()
            {
                BottomFromText = 32,
                HorizontalAnchor = HorizontalAnchorValues.Margin,
                LeftFromText = 42,
                RightFromText = 38,
                TopFromText = 45,
                VerticalAnchor = VerticalAnchorValues.Page,
                TablePositionX = 3,
                TablePositionY = 34,
                TablePositionXAlignment = HorizontalAlignmentValues.Inside,
                TablePositionYAlignment = VerticalAlignmentValues.Inline
            };
            Assert.IsFalse(new TablePositionPropertiesComparer(a, b).Compare());
        }

        [Test]
        public void TablePositionPropertiesComparerTablePositionXAlignmentWrongTest()
        {
            var a = new TablePositionProperties()
            {
                BottomFromText = 32,
                HorizontalAnchor = HorizontalAnchorValues.Text,
                LeftFromText = 42,
                RightFromText = 38,
                TopFromText = 45,
                VerticalAnchor = VerticalAnchorValues.Page,
                TablePositionX = 3,
                TablePositionY = 34,
                TablePositionXAlignment = HorizontalAlignmentValues.Center,
                TablePositionYAlignment = VerticalAlignmentValues.Inline
            };
            var b = new TablePositionProperties()
            {
                BottomFromText = 32,
                HorizontalAnchor = HorizontalAnchorValues.Margin,
                LeftFromText = 42,
                RightFromText = 38,
                TopFromText = 45,
                VerticalAnchor = VerticalAnchorValues.Page,
                TablePositionX = 3,
                TablePositionY = 34,
                TablePositionXAlignment = HorizontalAlignmentValues.Inside,
                TablePositionYAlignment = VerticalAlignmentValues.Inline
            };
            Assert.IsFalse(new TablePositionPropertiesComparer(a, b).Compare());
        }
    }
}
