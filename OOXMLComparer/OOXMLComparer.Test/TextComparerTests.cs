using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;

namespace OOXMLComparer.Test
{
    public class TextComparerTests
    {
        [Test]
        public void TextComparerTest()
        {
            var a = new Text("Test");
            var b = new Text("Test");
            var textComparer = new TextComparer();
            Assert.IsTrue(textComparer.Compare(a, b));
        }

        [Test]
        public void TextComparerWrongTest()
        {
            var a = new Text("Test");
            var b = new Text("Probe");
            var textComparer = new TextComparer();
            Assert.IsFalse(textComparer.Compare(a, b));
        }

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