using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Paragraphs.ParagraphProperties;

namespace OOXMLComparer.Test.Paragraphs
{
    [Category("OOXML")]
    public class TabsComparerTests
    {
        [Test]
        public void TabsComparerTest()
        {
            var a = new Tabs();
            var b = new Tabs();
            Assert.IsTrue(new TabsComparer(a, b).Compare());
        }

        [Test]
        public void TabsComparerHappyTest()
        {
            var a = new Tabs(new TabStop { Position = 42 }, new TabStop { Val = TabStopValues.Bar });
            var b = new Tabs(new TabStop { Position = 42 }, new TabStop { Val = TabStopValues.Bar });
            Assert.IsTrue(new TabsComparer(a, b).Compare());
        }

        [Test]
        public void TabsComparerWrongTest()
        {
            var a = new Tabs(new TabStop { Position = 42 }, new TabStop { Val = TabStopValues.Center });
            var b = new Tabs(new TabStop { Position = 42 }, new TabStop { Val = TabStopValues.Bar });
            Assert.IsFalse(new TabsComparer(a, b).Compare());
        }
    }
}
