using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Common;

namespace OOXMLComparer.Test.Tables.TableProperties
{
    [Category("OOXML")]
    public class InsideHorizontalBorderComparerTests
    {
        [Test]
        public void InsideHorizontalBorderComparerTest()
        {
            var a = new InsideHorizontalBorder();
            var b = new InsideHorizontalBorder();
            Assert.IsTrue(new InsideHorizontalBorderComparer(a, b).Compare());
        }
    }
}
