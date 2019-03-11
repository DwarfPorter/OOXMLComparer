using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Paragraphs.SectionProperties;

namespace OOXMLComparer.Test.Paragraphs.SectionProperties
{
    public class PageMarginComparerTests
    {
        [Test]
        public void PageMarginComparerTest()
        {
            var a = new PageMargin();
            var b = new PageMargin();
            Assert.IsTrue(new PageMarginComparer(a, b).Compare());
        }

        [Test]
        public void PageMarginComparerWrongTest()
        {
            var a = new PageMargin() { Bottom = 32, Footer = 28, Gutter = 42, Header = 33, Left = 12, Right = 15, Top = 6 };
            var b = new PageMargin();
            Assert.IsFalse(new PageMarginComparer(a, b).Compare());
        }

        [Test]
        public void PageMarginComparerHappyTest()
        {
            var a = new PageMargin() { Bottom = 32, Footer = 28, Gutter = 42, Header = 33, Left = 12, Right = 15, Top = 6 };
            var b = new PageMargin() { Bottom = 32, Footer = 28, Gutter = 42, Header = 33, Left = 12, Right = 15, Top = 6 };
            Assert.IsTrue(new PageMarginComparer(a, b).Compare());
        }
    }
}
