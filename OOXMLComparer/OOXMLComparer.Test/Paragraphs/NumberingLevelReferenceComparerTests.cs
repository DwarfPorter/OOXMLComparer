using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Paragraphs;

namespace OOXMLComparer.Test
{
    public class NumberingLevelReferenceComparerTests
    {
        [Test]
        public void NumberingLevelReferenceComparerTest()
        {
            var a = new NumberingLevelReference();
            var b = new NumberingLevelReference();
            Assert.IsTrue(new NumberingLevelReferenceComparer(a, b).Compare());
        }
        [Test]
        public void NumberingLevelReferenceComparerWrongTest()
        {
            var a = new NumberingLevelReference() { Val = 42 };
            var b = new NumberingLevelReference();
            Assert.IsFalse(new NumberingLevelReferenceComparer(a, b).Compare());
        }
    }
}