using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Common;

namespace OOXMLComparer.Test.Tables.TableProperties
{
    public class StartBorderComparerTests
    {
        [Test]
        public void StartBorderComparerTest()
        {
            var a = new StartBorder();
            var b = new StartBorder();
            Assert.IsTrue(new StartBorderComparer(a, b).Compare());
        }
    }
}
