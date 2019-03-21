using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Tables.TableProperties;

namespace OOXMLComparer.Test.Tables.TableProperties
{
    [Category("OOXML")]
    public class BottomMarginComparerTests
    {
        [Test]
        public void BottomMarginComparerTest()
        {
            var a = new BottomMargin();
            var b = new BottomMargin();
            Assert.IsTrue(new BottomMarginComparer(a, b).Compare());
        }
    }
        
}
