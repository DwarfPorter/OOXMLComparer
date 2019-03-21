using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Tables.TableProperties;

namespace OOXMLComparer.Test.Tables.TableProperties
{
    [Category("OOXML")]
    public class HorizontalMergeComparerTests
    {
        [Test]
        public void HorizontalMergeComparerTest()
        {
            var a = new HorizontalMerge();
            var b = new HorizontalMerge();
            Assert.IsTrue(ComparerFactory.Create(a, b).Compare());
        }

        [Test]
        public void HorizontalMergeComparerWrongTest()
        {
            var a = new HorizontalMerge() { Val = MergedCellValues.Continue };
            var b = new HorizontalMerge() { Val = MergedCellValues.Restart };
            Assert.IsFalse(new HorizontalMergeComparer(a, b).Compare());
        }
    }
}
