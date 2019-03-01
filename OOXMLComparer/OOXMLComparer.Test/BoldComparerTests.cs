using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;

namespace OOXMLComparer.Test
{
    public class BoldComparerTests
    {
        [Test]
        public void BoldComparerTest()
        {
            var a = new Bold { Val = true };
            var b = new Bold { Val = true };
            var boldComparer = new BoldComparer();
            Assert.IsTrue(boldComparer.Compare(a, b));
        }

        [Test]
        public void BoldComparerWrongTest()
        {
            var a = new Bold { Val = true };
            var b = new Bold { Val = false };
            var boldComparer = new BoldComparer();
            Assert.IsFalse(boldComparer.Compare(a, b));
        }

        [Test]
        public void BoldComparerDefaultWrongTest()
        {
            var a = new Bold { Val = true };
            var b = default(Bold);
            var boldComparer = new BoldComparer();
            Assert.IsFalse(boldComparer.Compare(a, b));
        }

        [Test]
        public void BoldComparerNullWrongTest()
        {
            var a = new Bold { Val = true };
            Bold b = null;
            var boldComparer = new BoldComparer();
            Assert.IsFalse(boldComparer.Compare(a, b));
            Assert.IsFalse(boldComparer.Compare(b, a));
        }

        [Test]
        public void BoldComparerNullTest()
        {
            var a = new Bold { Val = false };
            Bold b = null;
            var boldComparer = new BoldComparer();
            Assert.IsTrue(boldComparer.Compare(a, b));
            Assert.IsTrue(boldComparer.Compare(b, a));
            Assert.IsTrue(boldComparer.Compare(null, null));
        }
    }
}