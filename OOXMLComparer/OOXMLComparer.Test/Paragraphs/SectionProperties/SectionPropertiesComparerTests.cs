using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Paragraphs.SectionProperties;

namespace OOXMLComparer.Test.Paragraphs.SectionProperties
{
    [Category("OOXML")]
    public class SectionPropertiesComparerTests
    {
        [Test]
        public void SectionPropertiesComparerTest()
        {
            var a = new DocumentFormat.OpenXml.Wordprocessing.SectionProperties();
            var b = new DocumentFormat.OpenXml.Wordprocessing.SectionProperties();
            Assert.IsTrue(new SectionPropertiesComparer(a, b).Compare());
        }
        [Test]
        public void SectionPropertiesComparerHappyTest()
        {
            var a = new DocumentFormat.OpenXml.Wordprocessing.SectionProperties(new PageBorders());
            var b = new DocumentFormat.OpenXml.Wordprocessing.SectionProperties(new PageBorders());
            Assert.IsTrue(new SectionPropertiesComparer(a, b).Compare());
        }
        [Test]
        public void SectionPropertiesComparerWrongTest()
        {
            var a = new DocumentFormat.OpenXml.Wordprocessing.SectionProperties(new PageBorders(new TopBorder()));
            var b = new DocumentFormat.OpenXml.Wordprocessing.SectionProperties();
            Assert.IsFalse(new SectionPropertiesComparer(a, b).Compare());
        }
    }
}
