using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Paragraphs.ParaProperties;

namespace OOXMLComparer.Test.Paragraphs
{
    public class ParagraphStyleIdComparerTests
    {
        [Test]
        public void ParagraphStyleIdComparerTest()
        {
            var a = new ParagraphStyleId();
            var b = new ParagraphStyleId();
            Assert.IsTrue(new ParagraphStyleIdComparer(a, b).Compare());
        }

        [Test]
        public void ParagraphStyleIdComparerWrongTest()
        {
            var a = new ParagraphStyleId() { Val = "Header1" };
            var b = new ParagraphStyleId();
            Assert.IsFalse(new ParagraphStyleIdComparer(a, b).Compare());
            b.Val = "Heder2";
            Assert.IsFalse(new ParagraphStyleIdComparer(a, b).Compare());
        }

        [Test]
        public void ParagraphStyleIdComparerHappyTest()
        {
            var a = new ParagraphStyleId() { Val = "Header1" };
            var b = new ParagraphStyleId();
            b.Val = "Header1";
            Assert.IsTrue(new ParagraphStyleIdComparer(a, b).Compare());
        }
    }
}
