using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;

namespace OOXMLComparer.Test
{
    public class ItalicComparerTests
    {
        [Test]
        public void ItalicComparerTest()
        {
            var a = new Italic { Val = true };
            var b = new Italic { Val = true };
            var ItalicComparer = new ItalicComparer();
            Assert.IsTrue(ItalicComparer.Compare(a, b));
        }

        [Test]
        public void ItalicComparerWrongTest()
        {
            var a = new Italic { Val = true };
            var b = new Italic { Val = false };
            var ItalicComparer = new ItalicComparer();
            Assert.IsFalse(ItalicComparer.Compare(a, b));
        }

        [Test]
        public void ItalicComparerNullWrongTest()
        {
            var a = new Italic { Val = true };
            Italic b = null;
            var ItalicComparer = new ItalicComparer();
            Assert.IsFalse(ItalicComparer.Compare(a, b));
            Assert.IsFalse(ItalicComparer.Compare(b, a));
        }

        [Test]
        public void ItalicComparerNullTest()
        {
            var a = new Italic { Val = false };
            Italic b = null;
            var ItalicComparer = new ItalicComparer();
            Assert.IsTrue(ItalicComparer.Compare(a, b));
            Assert.IsTrue(ItalicComparer.Compare(b, a));
            Assert.IsTrue(ItalicComparer.Compare(null, null));
        }
    }
}