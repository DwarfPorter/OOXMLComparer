using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Tables.TableProperties;

namespace OOXMLComparer.Test.Tables.TableProperties
{
    [Category("OOXML")]
    public class TableRowPropertiesComparerTests
    {
        [Test]
        public void TableRowPropertiesComparerTest()
        {
            var a = new TableRowProperties();
            var b = new TableRowProperties();
            Assert.IsTrue(new TableRowPropertiesComparer(a, b).Compare());
        }

        [Test]
        public void TableRowPropertiesComparerWrongTest()
        {
            var a = new TableRowProperties(new CantSplit { Val = OnOffOnlyValues.On });
            var b = new TableRowProperties();
            Assert.IsFalse(new TableRowPropertiesComparer(a, b).Compare());
        }
    }

}
