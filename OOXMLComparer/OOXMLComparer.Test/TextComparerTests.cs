using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;

namespace OOXMLComparer.Test
{
    public class TextComparerTests
    {
        [Test]
        public void TextComparerTest()
        {
            var a = new Text("Test");
            var b = new Text("Test");
            var textComparer = new TextComparer();
            Assert.IsTrue(textComparer.Compare(a, b));
        }

        [Test]
        public void TextComparerWrongTest()
        {
            var a = new Text("Test");
            var b = new Text("Probe");
            var textComparer = new TextComparer();
            Assert.IsFalse(textComparer.Compare(a, b));
        }

        [Test]
        public void UnderlineComparerTest()
        {
            var a = new Underline { Val = UnderlineValues.Dash };
            var b = new Underline { Val = UnderlineValues.Dash };
            var underlineComparer = new UnderlineComparer();
            Assert.IsTrue(underlineComparer.Compare(a, b));
        }

        [Test]
        public void UnderlineComparerWrongTest()
        {
            var a = new Underline { Val = UnderlineValues.Dash };
            var b = new Underline { Val = UnderlineValues.Dotted };
            var underlineComparer = new UnderlineComparer();
            Assert.IsFalse(underlineComparer.Compare(a, b));
        }
    }
}