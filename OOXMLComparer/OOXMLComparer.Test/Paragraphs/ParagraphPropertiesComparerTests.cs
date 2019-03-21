using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Paragraphs.ParagraphProperties;

namespace OOXMLComparer.Test.Paragraphs
{
    [Category("OOXML")]
    public class ParagraphPropertiesComparerTests
    {
        [Test]
        public void ParagraphPropertiesComparerTest()
        {
            var a = new ParagraphProperties();
            var b = new ParagraphProperties();
            Assert.IsTrue(new ParagraphPropertiesComparer(a, b).Compare());
        }

        [Test]
        public void ParagraphPropertiesComparerHappyTest()
        {
            var a = new ParagraphProperties(new TextDirection { Val = TextDirectionValues.BottomToTopLeftToRight });
            var b = new ParagraphProperties(new TextDirection { Val = TextDirectionValues.BottomToTopLeftToRight });
            Assert.IsTrue(new ParagraphPropertiesComparer(a, b).Compare());
        }

        [Test]
        public void ParagraphPropertiesComparerWrongTest()
        {
            var a = new ParagraphProperties(new TextDirection { Val = TextDirectionValues.BottomToTopLeftToRight });
            var b = new ParagraphProperties();
            Assert.IsFalse(new ParagraphPropertiesComparer(a, b).Compare());
        }
    }
}
