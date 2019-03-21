using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Paragraphs.ParagraphProperties;

namespace OOXMLComparer.Test.Paragraphs
{
    [Category("OOXML")]
    public class TextBoxTightWrapComparerTests
    {
        [Test]
        public void TextBoxTightWrapComparerTest()
        {
            var a = new TextBoxTightWrap();
            var b = new TextBoxTightWrap();
            Assert.IsTrue(ComparerFactory.Create(a, b).Compare());
        }
        [Test]
        public void TextBoxTightWrapComparerWrongTest()
        {
            var a = new TextBoxTightWrap() { Val = TextBoxTightWrapValues.FirstAndLastLine };
            var b = new TextBoxTightWrap();
            Assert.IsFalse(new TextBoxTightWrapComparer(a, b).Compare());
            b.Val = TextBoxTightWrapValues.FirstLineOnly;
            Assert.IsFalse(new TextBoxTightWrapComparer(a, b).Compare());
        }

        [Test]
        public void TextBoxTightWrapComparerHappyTest()
        {
            var a = new TextBoxTightWrap() { Val = TextBoxTightWrapValues.AllLines };
            var b = new TextBoxTightWrap();
            b.Val = TextBoxTightWrapValues.AllLines;
            Assert.IsTrue(new TextBoxTightWrapComparer(a, b).Compare());
        }
    }

}
