using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Tables;

namespace OOXMLComparer.Test.Tables
{
    [Category("OOXML")]
    public class TableGridComparerTests
    {
        [Test]
        public void TableGridComparerTest()
        {
            var a = new TableGrid();
            var b = new TableGrid();
            Assert.IsTrue(new TableGridComparer(a, b).Compare());
        }

        [Test]
        public void TableGridComparerWrongTest()
        {
            var a = new TableGrid(new GridColumn { Width = "50" }, new GridColumn { Width = "42" });
            var b = new TableGrid(new GridColumn { Width = "42" }, new GridColumn { Width = "50" });
            Assert.IsFalse(new TableGridComparer(a, b).Compare());
        }
    }
}
