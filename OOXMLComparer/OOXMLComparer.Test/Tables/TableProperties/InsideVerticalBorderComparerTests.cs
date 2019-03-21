using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Common;

namespace OOXMLComparer.Test.Tables.TableProperties
{
    [Category("OOXML")]
    public class InsideVerticalBorderComparerTests
    {
        [Test]
        public void InsideVerticalBorderComparerTest()
        {
            var a = new InsideVerticalBorder();
            var b = new InsideVerticalBorder();
            Assert.IsTrue(new InsideVerticalBorderComparer(a, b).Compare());
        }
    }
}
