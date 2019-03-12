using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Paragraphs.ParaProperties;

namespace OOXMLComparer.Test.Paragraphs
{
    public class NumberingPropertiesComparerTests
    {
        [Test]
        public void NumberingPropertiesComparerTest()
        {
            var a = new NumberingProperties();
            var b = new NumberingProperties();
            Assert.IsTrue(new NumberingPropertiesComparer(a, b).Compare());
        }

        [Test]
        public void NumberingLevelReferenceComparerWrongTest()
        {
            var a = new NumberingProperties() { NumberingId = new NumberingId { Val = 42 }, NumberingLevelReference = new NumberingLevelReference { Val = 21 } };
            var b = new NumberingProperties() { NumberingId = new NumberingId { Val = 42 }, NumberingLevelReference = new NumberingLevelReference { Val = 22 } };
            Assert.IsFalse(new NumberingPropertiesComparer(a, b).Compare());
        }
    }
}