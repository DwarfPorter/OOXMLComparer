using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Paragraphs.ParagraphProperties;

namespace OOXMLComparer.Test.Paragraphs
{
    [Category("OOXML")]
    public class TextAlignmentComparerTests
    {
        [Test]
        public void TextAlignmentComparerTest()
        {
            var a = new TextAlignment();
            var b = new TextAlignment();
            Assert.IsTrue(new TextAlignmentComparer(a, b).Compare());
        }
        [Test]
        public void TextAlignmentComparerWrongTest()
        {
            var a = new TextAlignment() { Val = VerticalTextAlignmentValues.Baseline };
            var b = new TextAlignment();
            Assert.IsFalse(new TextAlignmentComparer(a, b).Compare());
            b.Val = VerticalTextAlignmentValues.Bottom;
            Assert.IsFalse(new TextAlignmentComparer(a, b).Compare());
        }

        [Test]
        public void TextAlignmentComparerHappyTest()
        {
            var a = new TextAlignment() { Val = VerticalTextAlignmentValues.Baseline };
            var b = new TextAlignment();
            b.Val = VerticalTextAlignmentValues.Baseline;
            Assert.IsTrue(new TextAlignmentComparer(a, b).Compare());
        }
    }

}
