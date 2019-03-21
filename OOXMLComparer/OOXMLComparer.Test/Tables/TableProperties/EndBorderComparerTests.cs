using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Common;

namespace OOXMLComparer.Test.Tables.TableProperties
{
    [Category("OOXML")]
    public class EndBorderComparerTests
    {
        [Test]
        public void EndBorderComparerTest()
        {
            var a = new EndBorder();
            var b = new EndBorder();
            Assert.IsTrue(ComparerFactory.Create(a, b).Compare());
        }
    }
}
