using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Properties;

namespace OOXMLComparer.Test.Runs
{
    public class ItalicComparerTests
    {
        [Test]
        public void ItalicComparerTest()
        {
            var a = new Italic { Val = true };
            var b = new Italic { Val = true };
            var ItalicComparer = new ItalicComparer(a, b);
            Assert.IsTrue(ItalicComparer.Compare());
        }

        [Test]
        public void ItalicComparerWrongTest()
        {
            var a = new Italic { Val = true };
            var b = new Italic { Val = false };
            var ItalicComparer = new ItalicComparer(a, b);
            Assert.IsFalse(ItalicComparer.Compare());
        }

        [Test]
        public void ItalicComparerNullWrongTest()
        {
            var a = new Italic { Val = true };
            Italic b = null;
            var ItalicComparer = new ItalicComparer(a, b);
            Assert.IsFalse(ItalicComparer.Compare());
            Assert.IsFalse(new ItalicComparer(b, a).Compare());
        }

        [Test]
        public void ItalicComparerNullTest()
        {
            var a = new Italic { Val = false };
            Italic b = null;
            var ItalicComparer = new ItalicComparer(a, b);
            Assert.IsTrue(ItalicComparer.Compare());
            Assert.IsTrue(new ItalicComparer(b, a).Compare());
            Assert.IsTrue(new ItalicComparer(null, null).Compare());
        }
    }
}