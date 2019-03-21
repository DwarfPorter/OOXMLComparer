using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Tables;

namespace OOXMLComparer.Test.Tables
{
    [Category("OOXML")]
    public class TableComparerTests
    {
        [Test]
        public void TableComparerTest()
        {
            var a = new Table();
            var b = new Table();
            Assert.IsTrue(new TableComparer(a, b).Compare());
        }

        [Test]
        public void TableComparerHappyTest()
        {
            var a = new Table(new TableRow());
            var b = new Table(new TableRow());
            Assert.IsTrue(new TableComparer(a, b).Compare());
        }

        [Test]
        public void TableComparerWrongTest()
        {
            var a = new Table(new TableRow());
            var b = new Table();
            Assert.IsFalse(new TableComparer(a, b).Compare());
        }

    }
}
