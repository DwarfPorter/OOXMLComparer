using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Tables.TableProperties;

namespace OOXMLComparer.Test.Tables.TableProperties
{
    public class HorizontalMergeComparerTests
    {
        [Test]
        public void HorizontalMergeComparerTest()
        {
            var a = new HorizontalMerge();
            var b = new HorizontalMerge();
            Assert.IsTrue(new HorizontalMergeComparer(a, b).Compare());
        }

        [Test]
        public void HorizontalMergeComparerWrongTest()
        {
            var a = new HorizontalMerge() { Val = MergedCellValues.Continue };
            var b = new HorizontalMerge() { Val = MergedCellValues.Restart };
            Assert.IsFalse(new HorizontalMergeComparer(a, b).Compare());
        }
    }
    public class VerticalMergeComparerTests
    {
        [Test]
        public void HorizontalMergeComparerTest()
        {
            var a = new VerticalMerge();
            var b = new VerticalMerge();
            Assert.IsTrue(new VerticalMergeComparer(a, b).Compare());
        }

        [Test]
        public void VerticalMergeComparerWrongTest()
        {
            var a = new VerticalMerge() { Val = MergedCellValues.Continue };
            var b = new VerticalMerge() { Val = MergedCellValues.Restart };
            Assert.IsFalse(new VerticalMergeComparer(a, b).Compare());
        }
    }
}
