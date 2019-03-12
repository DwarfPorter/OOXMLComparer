using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Paragraphs.ParaProperties;

namespace OOXMLComparer.Test.Paragraphs
{
    public class ContextualSpacingComparerTests
    {
        [Test]
        public void KeepLinesComparerTest()
        {
            var a = new ContextualSpacing();
            var b = new ContextualSpacing();
            Assert.IsTrue(new ContextualSpacingComparer(a, b).Compare());
        }

        [Test]
        public void KeepLinesComparerWrongTest()
        {
            var a = new ContextualSpacing() { Val = true };
            var b = new ContextualSpacing();
            Assert.IsFalse(new ContextualSpacingComparer(a, b).Compare());
        }
    }
}