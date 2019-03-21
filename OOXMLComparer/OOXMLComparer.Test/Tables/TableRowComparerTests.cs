using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Tables;

namespace OOXMLComparer.Test.Tables
{
    [Category("OOXML")]
    public class TableRowComparerTests
    {
        [Test]
        public void TableRowComparerTest()
        {
            var a = new TableRow();
            var b = new TableRow();
            Assert.IsTrue(new TableRowComparer(a, b).Compare());
        }

        [Test]
        public void TableRowPropertiesComparerWrongTest()
        {
            var a = new TableRow(new TableRowProperties(new CantSplit { Val = OnOffOnlyValues.On }));
            var b = new TableRow();
            Assert.IsFalse(new TableRowComparer(a, b).Compare());
        }
    }
}
