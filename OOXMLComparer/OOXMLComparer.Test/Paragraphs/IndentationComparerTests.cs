using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Paragraphs.ParagraphProperties;

namespace OOXMLComparer.Test.Paragraphs
{
    [Category("OOXML")]
    public class IndentationComparerTests
    {
        [Test]
        public void IdentationComparerTest()
        {
            var a = new Indentation();
            var b = new Indentation();
            Assert.IsTrue(new IndentationComparer(a, b).Compare());
        }

        [Test]
        public void IdentationComparerNullTest()
        {
            var a = new Indentation();
            Assert.IsFalse(new IndentationComparer(a, null).Compare());
        }

        [Test]
        public void IdentationComparerLeftWrongTest()
        {
            var a = new Indentation() { Left = "42" };
            var b = new Indentation() { Left = "32" };
            Assert.IsFalse(new IndentationComparer(a, b).Compare());
        }

        [Test]
        public void IdentationComparerStartWrongTest()
        {
            var a = new Indentation() { Start = "42" };
            var b = new Indentation() { Start = "32" };
            Assert.IsFalse(new IndentationComparer(a, b).Compare());
        }

        [Test]
        public void IdentationComparerEndWrongTest()
        {
            var a = new Indentation() { End = "42" };
            var b = new Indentation() { End = "32" };
            Assert.IsFalse(new IndentationComparer(a, b).Compare());
        }

        [Test]
        public void IdentationComparerRightWrongTest()
        {
            var a = new Indentation() { Right = "42" };
            var b = new Indentation() { Right = "32" };
            Assert.IsFalse(new IndentationComparer(a, b).Compare());
        }

        [Test]
        public void IdentationComparerRightCharsWrongTest()
        {
            var a = new Indentation() { RightChars = 42 };
            var b = new Indentation() { RightChars = 32 };
            Assert.IsFalse(new IndentationComparer(a, b).Compare());
        }

        [Test]
        public void IdentationComparerLeftCharsWrongTest()
        {
            var a = new Indentation() { LeftChars = 42 };
            var b = new Indentation() { LeftChars = 32 };
            Assert.IsFalse(new IndentationComparer(a, b).Compare());
        }

        [Test]
        public void IdentationComparerStartCharsWrongTest()
        {
            var a = new Indentation() { StartCharacters = 42 };
            var b = new Indentation() { StartCharacters = 32 };
            Assert.IsFalse(new IndentationComparer(a, b).Compare());
        }

        [Test]
        public void IdentationComparerEndCharsWrongTest()
        {
            var a = new Indentation() { EndCharacters = 42 };
            var b = new Indentation() { EndCharacters = 32 };
            Assert.IsFalse(new IndentationComparer(a, b).Compare());
        }
    }
}
