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
    }
}