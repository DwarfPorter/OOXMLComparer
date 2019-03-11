using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Paragraphs;

namespace OOXMLComparer.Test
{
    public class KeepNextComparerTests
    {
        [Test]
        public void KeepNextComparerTest()
        {
            var a = new KeepNext();
            var b = new KeepNext();
            Assert.IsTrue(new KeepNextComparer(a, b).Compare());
        }

        [Test]
        public void KeepNextComparerWrongTest()
        {
            var a = new KeepNext() { Val = true };
            var b = new KeepNext();
            Assert.IsFalse(new KeepNextComparer(a, b).Compare());
        }
    }
}