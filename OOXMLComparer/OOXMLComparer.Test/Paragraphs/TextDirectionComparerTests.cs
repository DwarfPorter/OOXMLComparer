using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Paragraphs.ParagraphProperties;

namespace OOXMLComparer.Test.Paragraphs
{
    [Category("OOXML")]
    public class TextDirectionComparerTests
    {
        [Test]
        public void TextDirectionComparerTest()
        {
            var a = new TextDirection();
            var b = new TextDirection();
            Assert.IsTrue(new TextDirectionComparer(a, b).Compare());
        }
        [Test]
        public void TextDirectionComparerWrongTest()
        {
            var a = new TextDirection() { Val = TextDirectionValues.LefToRightTopToBottom };
            var b = new TextDirection();
            Assert.IsFalse(new TextDirectionComparer(a, b).Compare());
            b.Val = TextDirectionValues.LefttoRightTopToBottomRotated;
            Assert.IsFalse(new TextDirectionComparer(a, b).Compare());
        }

        [Test]
        public void TextDirectionComparerHappyTest()
        {
            var a = new TextDirection() { Val = TextDirectionValues.TopToBottomLeftToRightRotated };
            var b = new TextDirection();
            b.Val = TextDirectionValues.TopToBottomLeftToRightRotated;
            Assert.IsTrue(new TextDirectionComparer(a, b).Compare());
        }
    }

}
