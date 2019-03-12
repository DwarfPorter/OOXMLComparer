using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Paragraphs.ParaProperties;

namespace OOXMLComparer.Test.Paragraphs
{
    public class NumberingIdComparerTests
    {
        [Test]
        public void NumberingIdComparerTest()
        {
            var a = new NumberingId();
            var b = new NumberingId();
            Assert.IsTrue(new NumberingIdComparer(a, b).Compare());
        }

        [Test]
        public void NumberingIdComparerWrongTest()
        {
            var a = new NumberingId() { Val = 42 };
            var b = new NumberingId();
            Assert.IsFalse(new NumberingIdComparer(a, b).Compare());
            b.Val = 21;
            Assert.IsFalse(new NumberingIdComparer(a, b).Compare());
        }

        [Test]
        public void NumberingIdComparerHappyTest()
        {
            var a = new NumberingId() { Val = 42 };
            var b = new NumberingId() { Val = 42 };
            Assert.IsTrue(new NumberingIdComparer(a, b).Compare());
        }
    }
}