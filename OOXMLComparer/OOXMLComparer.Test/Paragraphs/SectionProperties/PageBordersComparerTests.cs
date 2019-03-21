using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Paragraphs;
using OOXMLComparer.Paragraphs.SectionProperties;

namespace OOXMLComparer.Test.Paragraphs
{
    [Category("OOXML")]
    public class PageBordersComparerTests
    {
        [Test]
        public void ParagraphBordersComparerTest()
        {
            var a = new PageBorders();
            var b = new PageBorders();
            Assert.IsTrue(new PageBordersComparer(a, b).Compare());
        }

        [Test]
        public void ParagraphBordersComparerHappyTest()
        {
            var a = new PageBorders()
            {
                BottomBorder = new BottomBorder { Space = 21},
                LeftBorder = new LeftBorder { Val = BorderValues.Bats},
                RightBorder = new RightBorder { Color = "Auto"}
            };
            var b = new PageBorders(new LeftBorder { Val = BorderValues.Bats },
                new BottomBorder { Space = 21 },
                new RightBorder { Color = "Auto" });
            Assert.IsTrue(new PageBordersComparer(a, b).Compare());
        }

        [Test]
        public void ParagraphBordersComparerWrongTest()
        {
            var a = new PageBorders() { BottomBorder = new BottomBorder { Size = 30, Val = BorderValues.BasicWideInline, Space = 42, Color = "Blue" } };
            var b = new PageBorders(new BottomBorder { Size = 30, Val = BorderValues.BasicWideInline, Space = 42, Color = "Auto" });
            Assert.IsFalse(new PageBordersComparer(a, b).Compare());
        }

        [Test]
        public void ParagraphBordersComparerWrong2Test()
        {
            var a = new PageBorders() { BottomBorder = new BottomBorder(), TopBorder = new TopBorder()};
            var b = new PageBorders(new BarBorder());
            Assert.IsFalse(new PageBordersComparer(a, b).Compare());
        }
    }
}
