using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Tables.TableProperties;

namespace OOXMLComparer.Test.Tables.TableProperties
{
    [Category("OOXML")]
    public class LeftMarginComparerTests
    {
        [Test]
        public void LeftMarginComparerTest()
        {
            var a = new LeftMargin();
            var b = new LeftMargin();
            Assert.IsTrue(new LeftMarginComparer(a, b).Compare());
        }

        [Test]
        public void LeftMarginComparerHappyTest()
        {
            var a = new LeftMargin() { Type = TableWidthUnitValues.Dxa, Width = "42" };
            var b = new LeftMargin() { Type = TableWidthUnitValues.Dxa, Width = "42" };
            Assert.IsTrue(new LeftMarginComparer(a, b).Compare());
        }

        [Test]
        public void LeftMarginComparerTypeWrongTest()
        {
            var a = new LeftMargin() { Type = TableWidthUnitValues.Nil, Width = "42" };
            var b = new LeftMargin() { Type = TableWidthUnitValues.Dxa, Width = "42" };
            Assert.IsFalse(new LeftMarginComparer(a, b).Compare());
        }

        [Test]
        public void LeftMarginComparerWidthWrongTest()
        {
            var a = new LeftMargin() { Type = TableWidthUnitValues.Dxa };
            var b = new LeftMargin() { Type = TableWidthUnitValues.Dxa, Width = "42" };
            Assert.IsFalse(new LeftMarginComparer(a, b).Compare());
        }
    }
}
