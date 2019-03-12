using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Paragraphs.ParaProperties;

namespace OOXMLComparer.Test.Paragraphs
{
    public class TabStopComparerTests
    {
        [Test]
        public void TabStopComparerTest()
        {
            var a = new TabStop();
            var b = new TabStop();
            Assert.IsTrue(new TabStopComparer(a, b).Compare());
        }

        [Test]
        public void TabStopComparerHappyTest()
        {
            var a = new TabStop { Val = TabStopValues.Left, Position = 32 };
            var b = new TabStop { Val = TabStopValues.Left, Position = 32 };
            Assert.IsTrue(new TabStopComparer(a, b).Compare());
        }

        [Test]
        public void TabStopComparerValWrongTest()
        {
            var a = new TabStop { Val = TabStopValues.Left };
            var b = new TabStop { Val = TabStopValues.Right };
            Assert.IsFalse(new TabStopComparer(a, b).Compare());
        }

        [Test]
        public void TabStopComparerPositionWrongTest()
        {
            var a = new TabStop { Position = 42 };
            var b = new TabStop { Position = 43 };
            Assert.IsFalse(new TabStopComparer(a, b).Compare());
        }
    }
}
