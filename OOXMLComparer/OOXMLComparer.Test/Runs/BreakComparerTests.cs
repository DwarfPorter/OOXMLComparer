using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Texts;

namespace OOXMLComparer.Test.Runs
{
    [Category("OOXML")]
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
        }

        [Test]
        public void BreakComparerHappyTest()
        {
            var a = new Break() { Type = BreakValues.TextWrapping };
            var b = new Break() { Type = BreakValues.TextWrapping };
            Assert.IsTrue(new BreakComparer(a, b).Compare());
        }

        [Test]
        public void BreakComparerDefaultTest()
        {
            var a = new Break() { Type = BreakValues.TextWrapping };
            var b = new Break();
            Assert.IsTrue(new BreakComparer(a, b).Compare());
        }

        [Test]
        public void BreakComparerWrongTest()
        {
            var a = new Break() { Type = BreakValues.TextWrapping };
            var b = new Break() { Type = BreakValues.Page };
            Assert.IsFalse(new BreakComparer(a, b).Compare());
        }
    }
}