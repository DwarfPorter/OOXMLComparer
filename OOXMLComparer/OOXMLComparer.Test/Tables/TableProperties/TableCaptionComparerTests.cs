using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Tables.TableProperties;

namespace OOXMLComparer.Test.Tables.TableProperties
{
    public class TableCaptionComparerTests
    {
        [Test]
        public void TableCaptionComparerTest()
        {
            var a = new TableCaption();
            var b = new TableCaption();
            Assert.IsTrue(new TableCaptionComparer(a, b).Compare());
        }

        [Test]
        public void TableCaptionComparerHappyTest()
        {
            var a = new TableCaption() { Val = "AAA" };
            var b = new TableCaption() { Val = "AAA" };
            Assert.IsTrue(new TableCaptionComparer(a, b).Compare());
        }

        [Test]
        public void TableCaptionComparerWrongTest()
        {
            var a = new TableCaption() { Val = "AAA" };
            var b = new TableCaption() { Val = "AAwA" };
            Assert.IsFalse(new TableCaptionComparer(a, b).Compare());
        }
    }
}
