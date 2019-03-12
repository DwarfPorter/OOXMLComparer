using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Tables.TableProperties;

namespace OOXMLComparer.Test.Tables.TableProperties
{
    public class TableJustificationComparerTests
    {
        [Test]
        public void TableJustificationComparerTest()
        {
            var a = new TableJustification();
            var b = new TableJustification();
            Assert.IsTrue(new TableJustificationComparer(a, b).Compare());
        }

        [Test]
        public void TableJustificationComparerHappyTest()
        {
            var a = new TableJustification() { Val = TableRowAlignmentValues.Center };
            var b = new TableJustification() { Val = TableRowAlignmentValues.Center };
            Assert.IsTrue(new TableJustificationComparer(a, b).Compare());
        }

        [Test]
        public void TableJustificationComparerWrongTest()
        {
            var a = new TableJustification() { Val = TableRowAlignmentValues.Center };
            var b = new TableJustification() { Val = TableRowAlignmentValues.Left };
            Assert.IsFalse(new TableJustificationComparer(a, b).Compare());
        }
    }
}
