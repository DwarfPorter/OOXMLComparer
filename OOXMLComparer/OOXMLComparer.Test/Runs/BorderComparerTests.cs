using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Properties;

namespace OOXMLComparer.Test.Runs
{
    [Category("OOXML")]
    public class BorderComparerTests
    {
        [Test]
        public void BorderComparerTest()
        {
            var a = new Border { Val = BorderValues.Single };
            var b = new Border { Val = BorderValues.Single };
            Assert.IsTrue(ComparerFactory.Create(a, b).Compare());
        }

        [Test]
        public void BorderComparerWrongTest()
        {
            var a = new Border { Val = BorderValues.Single };
            var b = new Border { Val = BorderValues.Sombrero };
            var BorderComparer = new BorderComparer(a, b);
            Assert.IsFalse(BorderComparer.Compare());
        }

        [Test]
        public void BorderComparerNullTest()
        {
            var a = new Border { Val = BorderValues.None };
            var a1 = new Border { Val = BorderValues.Nil };
            var BorderComparer = new BorderComparer(a, null);
            Assert.IsTrue(BorderComparer.Compare());
            Assert.IsTrue(new BorderComparer(a1, null).Compare());
        }

        [Test]
        public void BorderComparerNullWrongTest()
        {
            var a = new Border { Val = BorderValues.Single };
            var BorderComparer = new BorderComparer(a, null);
            Assert.IsFalse(BorderComparer.Compare());
        }
    }
}