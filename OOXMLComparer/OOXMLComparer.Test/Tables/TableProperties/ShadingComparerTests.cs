using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Common;

namespace OOXMLComparer.Test.Tables.TableProperties
{
    [Category("OOXML")]
    public class ShadingComparerTests
    {
        [Test]
        public void ShadingComparerTest()
        {
            var a = new Shading();
            var b = new Shading();
            Assert.IsTrue(new ShadingComparer(a,b).Compare());
        }

        [Test]
        public void ShadingComparerHappyTest()
        {
            var a = new Shading()
            {
                Val = ShadingPatternValues.DiagonalCross,
                Color = "Blue",
                Fill = "Green",
                ThemeColor = ThemeColorValues.Accent1,
                ThemeFill = ThemeColorValues.Accent4,
                ThemeFillShade = "Red",
                ThemeTint = "Red",
                ThemeFillTint = "Red",
                ThemeShade = "Red"
            };
            var b = new Shading()
            {
                Val = ShadingPatternValues.DiagonalCross,
                Color = "Blue",
                Fill = "Green",
                ThemeColor = ThemeColorValues.Accent1,
                ThemeFill = ThemeColorValues.Accent4,
                ThemeFillShade = "Red",
                ThemeTint = "Red",
                ThemeFillTint = "Red",
                ThemeShade = "Red"
            };
            Assert.IsTrue(new ShadingComparer(a, b).Compare());
        }

        [Test]
        public void ShadingComparerValWrongTest()
        {
            var a = new Shading()
            {
                Val = ShadingPatternValues.DiagonalStripe,
                Color = "Blue",
                Fill = "Green",
                ThemeColor = ThemeColorValues.Accent1,
                ThemeFill = ThemeColorValues.Accent4,
                ThemeFillShade = "Red",
                ThemeTint = "Red",
                ThemeFillTint = "Red",
                ThemeShade = "Red"
            };
            var b = new Shading()
            {
                Val = ShadingPatternValues.DiagonalCross,
                Color = "Blue",
                Fill = "Green",
                ThemeColor = ThemeColorValues.Accent1,
                ThemeFill = ThemeColorValues.Accent4,
                ThemeFillShade = "Red",
                ThemeTint = "Red",
                ThemeFillTint = "Red",
                ThemeShade = "Red"
            };
            Assert.IsFalse(new ShadingComparer(a, b).Compare());
        }

        [Test]
        public void ShadingComparerColorWrongTest()
        {
            var a = new Shading()
            {
                Val = ShadingPatternValues.DiagonalCross,
                Color = "Yellow",
                Fill = "Green",
                ThemeColor = ThemeColorValues.Accent1,
                ThemeFill = ThemeColorValues.Accent4,
                ThemeFillShade = "Red",
                ThemeTint = "Red",
                ThemeFillTint = "Red",
                ThemeShade = "Red"
            };
            var b = new Shading()
            {
                Val = ShadingPatternValues.DiagonalCross,
                Color = "Blue",
                Fill = "Green",
                ThemeColor = ThemeColorValues.Accent1,
                ThemeFill = ThemeColorValues.Accent4,
                ThemeFillShade = "Red",
                ThemeTint = "Red",
                ThemeFillTint = "Red",
                ThemeShade = "Red"
            };
            Assert.IsFalse(new ShadingComparer(a, b).Compare());
        }

        [Test]
        public void ShadingComparerThemeShadeWrongTest()
        {
            var a = new Shading()
            {
                Val = ShadingPatternValues.DiagonalCross,
                Color = "Blue",
                Fill = "Green",
                ThemeColor = ThemeColorValues.Accent1,
                ThemeFill = ThemeColorValues.Accent4,
                ThemeFillShade = "Red",
                ThemeTint = "Red",
                ThemeFillTint = "Red",
                ThemeShade = "Red"
            };
            var b = new Shading()
            {
                Val = ShadingPatternValues.DiagonalCross,
                Color = "Blue",
                Fill = "Green",
                ThemeColor = ThemeColorValues.Accent1,
                ThemeFill = ThemeColorValues.Accent4,
                ThemeFillShade = "Red",
                ThemeTint = "Red",
                ThemeFillTint = "Red",
                ThemeShade = "Green"
            };
            Assert.IsFalse(new ShadingComparer(a, b).Compare());
        }
    }
}
