using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Paragraphs;

namespace OOXMLComparer.Test.Paragraphs
{
    public class LeftBorderComparerTests
    {
        [Test]
        public void LeftBorderComparerTest()
        {
            var a = new LeftBorder();
            var b = new LeftBorder();
            Assert.IsTrue(new LeftBorderComparer(a, b).Compare());
        }
    }
}
