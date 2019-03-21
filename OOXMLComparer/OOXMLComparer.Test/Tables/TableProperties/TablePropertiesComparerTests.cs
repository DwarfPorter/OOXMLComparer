using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Tables.TableProperties;

namespace OOXMLComparer.Test.Tables.TableProperties
{
    [Category("OOXML")]
    public class TablePropertiesComparerTests
    {
        [Test]
        public void TablePropertiesComparerTest()
        {
            var a = new DocumentFormat.OpenXml.Wordprocessing.TableProperties();
            var b = new DocumentFormat.OpenXml.Wordprocessing.TableProperties();
            Assert.IsTrue(new TablePropertiesComparer(a, b).Compare());
        }

        [Test]
        public void TablePropertiesComparerWrongTest()
        {
            var a = new DocumentFormat.OpenXml.Wordprocessing.TableProperties(new TableBorders(new StartBorder {Size = 20 }));
            var b = new DocumentFormat.OpenXml.Wordprocessing.TableProperties();
            Assert.IsFalse(new TablePropertiesComparer(a, b).Compare());
        }
    }
}
