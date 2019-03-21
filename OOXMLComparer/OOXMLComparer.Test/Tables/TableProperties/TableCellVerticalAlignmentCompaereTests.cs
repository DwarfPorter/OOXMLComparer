using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Tables.TableProperties;

namespace OOXMLComparer.Test.Tables.TableProperties
{
    [Category("OOXML")]
    public class TableCellVerticalAlignmentCompaereTests
    {
        [Test]
        public void TableCellVerticalAlignmentComparerTest()
        {
            var a = new TableCellVerticalAlignment();
            var b = new TableCellVerticalAlignment();
            Assert.IsTrue(new TableCellVerticalAlignmentComparer(a, b).Compare());
        }
        [Test]
        public void VerticalMergeComparerWrongTest()
        {
            var a = new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Bottom };
            var b = new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center };
            Assert.IsFalse(new TableCellVerticalAlignmentComparer(a, b).Compare());
        }
    }
}
