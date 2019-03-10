using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Texts;

namespace OOXMLComparer.Test
{
    public class BreakComparerTests
    {
        [Test]
        public void BreakComparerTest()
        {
            var a = new Break();
            var b = new Break();
            Assert.IsTrue(new BreakComparer(a, b).Compare());
        }

        [Test]
        public void BreakComparerNullTest()
        {
            var a = new Break();
            Assert.IsFalse(new BreakComparer(a, null).Compare());
            Assert.IsFalse(new BreakComparer(null, a).Compare());
            Assert.IsTrue(new BreakComparer(null, null).Compare());
        }

        [Test]
        public void BreakComparerHappyTest()
        {
            var a = new Break() { Type = BreakValues.TextWrapping };
            var b = new Break() { Type = BreakValues.TextWrapping };
            Assert.IsTrue(new BreakComparer(a, b).Compare());
        }

        [Test]
        public void BreakComparerWrongTest()
        {
            var a = new Break() { Type = BreakValues.TextWrapping };
            var b = new Break();
            Assert.IsFalse(new BreakComparer(a, b).Compare());
        }
    }
}