using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Properties;

namespace OOXMLComparer.Test
{
    public class UnderlineComparerTests
    {
        [Test]
        public void UnderlineComparerTest()
        {
            var a = new Underline { Val = UnderlineValues.Dash };
            var b = new Underline { Val = UnderlineValues.Dash };
            var underlineComparer = new UnderlineComparer();
            Assert.IsTrue(underlineComparer.Compare(a, b));
        }

        [Test]
        public void UnderlineComparerNullTest()
        {
            var a = new Underline { Val = UnderlineValues.None };
            var underlineComparer = new UnderlineComparer();
            Assert.IsTrue(underlineComparer.Compare(a, null));
            Assert.IsTrue(underlineComparer.Compare(null, a));
            Assert.IsTrue(underlineComparer.Compare(null, null));
        }

        [Test]
        public void UnderlineComparerNullWrongTest()
        {
            var a = new Underline { Val = UnderlineValues.DashLong };
            var underlineComparer = new UnderlineComparer();
            Assert.IsFalse(underlineComparer.Compare(a, null));
            Assert.IsFalse(underlineComparer.Compare(null, a));
        }

        [Test]
        public void UnderlineComparerWrongTest()
        {
            var a = new Underline { Val = UnderlineValues.Dash };
            var b = new Underline { Val = UnderlineValues.Dotted };
            var underlineComparer = new UnderlineComparer();
            Assert.IsFalse(underlineComparer.Compare(a, b));
        }

    }
}