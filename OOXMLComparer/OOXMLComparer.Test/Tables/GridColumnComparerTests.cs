using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Tables;

namespace OOXMLComparer.Test.Tables
{
    [Category("OOXML")]
    public class GridColumnComparerTests
    {
        [Test]
        public void GridColumnComparerTest()
        {
            var a = new GridColumn();
            var b = new GridColumn();
            Assert.IsTrue(new GridColumnComparer(a, b).Compare());
        }

        [Test]
        public void GridColumnComparerWrongTest()
        {
            var a = new GridColumn() { Width = "30" };
            var b = new GridColumn();
            Assert.IsFalse(new GridColumnComparer(a, b).Compare());
        }
    }
}
