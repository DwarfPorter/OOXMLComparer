using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Paragraphs.ParagraphProperties;

namespace OOXMLComparer.Test.Paragraphs
{
    [Category("OOXML")]
    public class JustificationComparerTests
    {
        [Test]
        public void JustificationComparerTest()
        {
            var a = new Justification();
            var b = new Justification();
            Assert.IsTrue(new JustificationComparer(a, b).Compare());
        }

        [Test]
        public void JustificationComparerNullTest()
        {
            var a = new Justification();
            Assert.IsTrue(new JustificationComparer(a, null).Compare());
            a.Val = JustificationValues.Center;
            Assert.IsFalse(new JustificationComparer(a, null).Compare());
        }

        [Test]
        public void JustificationComparerHappyTest()
        {
            var a = new Justification() { Val = JustificationValues .Both };
            var b = new Justification() { Val = JustificationValues.Both };
            Assert.IsTrue(new JustificationComparer(a, b).Compare());
        }

        [Test]
        public void JustificationComparerWrongTest()
        {
            var a = new Justification() { Val = JustificationValues.Both };
            var b = new Justification() { Val = JustificationValues.Left };
            Assert.IsFalse(new JustificationComparer(a, b).Compare());
        }
    }
}
