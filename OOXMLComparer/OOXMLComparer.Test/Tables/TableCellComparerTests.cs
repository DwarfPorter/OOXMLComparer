using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Tables;

namespace OOXMLComparer.Test.Tables
{
    [Category("OOXML")]
    public class TableCellComparerTests
    {
        [Test]
        public void TableCellComparerTest()
        {
            var a = new TableCell();
            var b = new TableCell();
            Assert.IsTrue(new TableCellComparer(a, b).Compare());
        }

        [Test]
        public void TableCellComparerHappyTest()
        {
            var a = new TableCell(new Run(new Text("aaa")), new TableCellProperties { NoWrap = new NoWrap { Val = OnOffOnlyValues.On } });
            var b = new TableCell(new Run(new Text("aaa"))) { TableCellProperties = new TableCellProperties { NoWrap = new NoWrap { Val = OnOffOnlyValues.On } } };
            Assert.IsTrue(new TableCellComparer(a, b).Compare());
        }

        [Test]
        public void TableCellComparerWrongTest()
        {
            var a = new TableCell(new TableCellProperties { NoWrap = new NoWrap { Val = OnOffOnlyValues.On } }, new Run(new Text("bbb")), new Run(new Text("aaa")));
            var b = new TableCell(new Run(new Text("aaa")), new Run(new Text("bbb"))) { TableCellProperties = new TableCellProperties { NoWrap = new NoWrap { Val = OnOffOnlyValues.On } } };
            Assert.IsFalse(new TableCellComparer(a, b).Compare());
        }
    }
}
