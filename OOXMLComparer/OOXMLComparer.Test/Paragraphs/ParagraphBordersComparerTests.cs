using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Paragraphs.ParagraphProperties;

namespace OOXMLComparer.Test.Paragraphs
{
    [Category("OOXML")]
    public class ParagraphBordersComparerTests
    {
        [Test]
        public void ParagraphBordersComparerTest()
        {
            var a = new ParagraphBorders();
            var b = new ParagraphBorders();
            Assert.IsTrue(new ParagraphBordersComparer(a, b).Compare());
        }

        [Test]
        public void ParagraphBordersComparerHappyTest()
        {
            var a = new ParagraphBorders()
            {
                BarBorder = new BarBorder { Size = 30, Val = BorderValues.BasicWideInline, Space = 42, Color = "Blue" },
                BetweenBorder = new BetweenBorder { Size = 40 },
                BottomBorder = new BottomBorder { Space = 21},
                LeftBorder = new LeftBorder { Val = BorderValues.Bats},
                RightBorder = new RightBorder { Color = "Auto"}
            };
            var b = new ParagraphBorders(new BarBorder { Size = 30, Val = BorderValues.BasicWideInline, Space = 42, Color = "Blue" },
                new BetweenBorder { Size = 40 },
                new LeftBorder { Val = BorderValues.Bats },
                new BottomBorder { Space = 21 },
                new RightBorder { Color = "Auto" });
            Assert.IsTrue(new ParagraphBordersComparer(a, b).Compare());
        }

        [Test]
        public void ParagraphBordersComparerWrongTest()
        {
            var a = new ParagraphBorders() { BarBorder = new BarBorder { Size = 30, Val = BorderValues.BasicWideInline, Space = 42, Color = "Blue" } };
            var b = new ParagraphBorders(new BarBorder { Size = 30, Val = BorderValues.BasicWideInline, Space = 42, Color = "Auto" });
            Assert.IsFalse(new ParagraphBordersComparer(a, b).Compare());
        }

        [Test]
        public void ParagraphBordersComparerWrong2Test()
        {
            var a = new ParagraphBorders() { BarBorder = new BarBorder(), TopBorder = new TopBorder()};
            var b = new ParagraphBorders(new BarBorder());
            Assert.IsFalse(new ParagraphBordersComparer(a, b).Compare());
        }
    }
}
