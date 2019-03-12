using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Tables.TableProperties;

namespace OOXMLComparer.Test.Tables.TableProperties
{
    public class TableHeaderComparerTests
    {
        [Test]
        public void TableHeaderComparerTest()
        {
            var a = new TableHeader();
            var b = new TableHeader();
            Assert.IsTrue(new TableHeaderComparer(a, b).Compare());
        }
    }
}
