using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Texts;

namespace OOXMLComparer.Test.Runs
{

    public class TextComparerTests
    {
        [Test]
        public void TextComparerTest()
        {
            var a = new Text("Test");
            var b = new Text("Test");
            var textComparer = new TextComparer(a, b);
            Assert.IsTrue(textComparer.Compare());
        }

        [Test]
        public void TextComparerWrongTest()
        {
            var a = new Text("Test");
            var b = new Text("Probe");
            var textComparer = new TextComparer(a, b);
            Assert.IsFalse(textComparer.Compare());
            Assert.IsFalse(new TextComparer(a, null).Compare());
        }
    }
}