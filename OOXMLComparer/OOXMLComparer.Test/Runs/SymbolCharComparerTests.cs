using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Texts;

namespace OOXMLComparer.Test.Runs
{
    [Category("OOXML")]
    public class SymbolCharComparerTests
    {
        [Test]
        public void SymbolCharComparerTest()
        {
            var a = new SymbolChar();
            var b = new SymbolChar();
            Assert.IsTrue(new SymbolCharComparer(a, b).Compare());
            Assert.IsFalse(new SymbolCharComparer(a, null).Compare());
        }

        [Test]
        public void SymbolCharComparerHappyTest()
        {
            var a = new SymbolChar() { Char = "99", Font = "Arial" };
            var b = new SymbolChar() { Char = "99", Font = "Arial" };
            Assert.IsTrue(new SymbolCharComparer(a, b).Compare());
        }

        [Test]
        public void SymbolCharComparerWrongTest()
        {
            var a = new SymbolChar() { Char = "99", Font = "Arial" };
            var b = new SymbolChar() { Char = "98", Font = "Arial" };
            Assert.IsFalse(new SymbolCharComparer(a, b).Compare());
        }

        [Test]
        public void SymbolCharComparerWrong2Test()
        {
            var a = new SymbolChar() { Char = "99", Font = "Arial" };
            var b = new SymbolChar() { Char = "98" };
            Assert.IsFalse(new SymbolCharComparer(a, b).Compare());
        }
    }

}