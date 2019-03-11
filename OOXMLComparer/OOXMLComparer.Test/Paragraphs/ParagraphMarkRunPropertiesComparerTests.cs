using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Paragraphs;

namespace OOXMLComparer.Test.Paragraphs
{
    public class ParagraphMarkRunPropertiesComparerTests
    {
        [Test]
        public void ParagraphMarkRunPropertiesComparerTest()
        {
            var a = new ParagraphMarkRunProperties();
            var b = new ParagraphMarkRunProperties();
            Assert.IsTrue(new ParagraphMarkRunPropertiesComparer(a, b).Compare());
        }
        [Test]
        public void ParagraphMarkRunPropertiesComparerWrongTest()
        {
            var a = new ParagraphMarkRunProperties(new Italic() { Val = true });
            var b = new ParagraphMarkRunProperties();
            Assert.IsFalse(new ParagraphMarkRunPropertiesComparer(a, b).Compare());
        }
        [Test]
        public void ParagraphMarkRunPropertiesComparerHappyTest()
        {
            var a = new ParagraphMarkRunProperties(new Italic() { Val = true }, new Bold() { Val = true });
            var b = new ParagraphMarkRunProperties(new Italic() { Val = true }, new Bold() { Val = true });
            Assert.IsTrue(new ParagraphMarkRunPropertiesComparer(a, b).Compare());
        }
    }
}
