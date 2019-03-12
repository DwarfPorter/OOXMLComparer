using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Tables.TableProperties;

namespace OOXMLComparer.Test.Tables.TableProperties
{
    public class TableCellFitTextComparerTests
    {
        [Test]
        public void TableCellFitTextComparerTest()
        {
            var a = new TableCellFitText() { Val = OnOffOnlyValues.On };
            var b = new TableCellFitText() { Val = OnOffOnlyValues.On };
            Assert.IsTrue(new TableCellFitTextComparer(a, b).Compare());
        }
        [Test]
        public void TableCellFitTextComparerWrongTest()
        {
            var a = new TableCellFitText() { Val = OnOffOnlyValues.On };
            var b = new TableCellFitText();
            Assert.IsFalse(new TableCellFitTextComparer(a, b).Compare());
        }
    }
    
}
