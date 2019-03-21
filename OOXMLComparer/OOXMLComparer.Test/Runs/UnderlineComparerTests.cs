using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Properties;

namespace OOXMLComparer.Test.Runs
{
    [Category("OOXML")]
    public class UnderlineComparerTests
    {
        [Test]
        public void UnderlineComparerTest()
        {
            var a = new Underline { Val = UnderlineValues.Dash };
            var b = new Underline { Val = UnderlineValues.Dash };
            var underlineComparer = new UnderlineComparer(a, b);
            Assert.IsTrue(underlineComparer.Compare());
        }

        [Test]
        public void UnderlineComparerNullTest()
        {
            var a = new Underline { Val = UnderlineValues.None };
            var underlineComparer = new UnderlineComparer(a, null);
            Assert.IsTrue(underlineComparer.Compare());
        }

        [Test]
        public void UnderlineComparerNullWrongTest()
        {
            var a = new Underline { Val = UnderlineValues.DashLong };
            Assert.IsFalse(new UnderlineComparer(a, null).Compare());
        }

        [Test]
        public void UnderlineComparerWrongTest()
        {
            var a = new Underline { Val = UnderlineValues.Dash };
            var b = new Underline { Val = UnderlineValues.Dotted };
            var underlineComparer = new UnderlineComparer(a, b);
            Assert.IsFalse(underlineComparer.Compare());
        }

        [Test]
        public void UnderlineComparerDefaultTest()
        {
            var a = new Underline { Val = UnderlineValues.None };
            var b = new Underline();
            Assert.IsTrue(new UnderlineComparer(a, b).Compare());
        }

    }
}