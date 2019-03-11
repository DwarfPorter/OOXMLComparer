using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Properties;

namespace OOXMLComparer.Test
{
    public class BoldComparerTests
    {
        [Test]
        public void BoldComparerTest()
        {
            var a = new Bold { Val = true };
            var b = new Bold { Val = true };
            var boldComparer = new BoldComparer(a, b);
            Assert.IsTrue(boldComparer.Compare());
        }

        [Test]
        public void BoldComparerWrongTest()
        {
            var a = new Bold { Val = true };
            var b = new Bold { Val = false };
            var boldComparer = new BoldComparer(a, b);
            Assert.IsFalse(boldComparer.Compare());
        }

        [Test]
        public void BoldComparerDefaultWrongTest()
        {
            var a = new Bold { Val = true };
            var b = default(Bold);
            var boldComparer = new BoldComparer(a, b);
            Assert.IsFalse(boldComparer.Compare());
        }

        [Test]
        public void BoldComparerNullWrongTest()
        {
            var a = new Bold { Val = true };
            Bold b = null;
            var boldComparer = new BoldComparer(a, b);
            Assert.IsFalse(boldComparer.Compare());
            boldComparer = new BoldComparer(b, a);
            Assert.IsFalse(boldComparer.Compare());
        }

        [Test]
        public void BoldComparerNullTest()
        {
            var a = new Bold { Val = false };
            Bold b = null;
            var boldComparer = new BoldComparer(a, b);
            Assert.IsTrue(boldComparer.Compare());
            boldComparer = new BoldComparer(b, a);
            Assert.IsTrue(boldComparer.Compare());
            boldComparer = new BoldComparer(null, null);
            Assert.IsTrue(boldComparer.Compare());
        }
    }
}