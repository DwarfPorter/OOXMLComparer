using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Properties;

namespace OOXMLComparer.Test
{
    public class BorderComparerTests
    {
        [Test]
        public void BorderComparerTest()
        {
            var a = new Border { Val = BorderValues.Single };
            var b = new Border { Val = BorderValues.Single };
            var borderComparer = new BorderComparer();
            Assert.IsTrue(borderComparer.Compare(a, b));
        }

        [Test]
        public void BorderComparerWrongTest()
        {
            var a = new Border { Val = BorderValues.Single };
            var b = new Border { Val = BorderValues.Sombrero };
            var BorderComparer = new BorderComparer();
            Assert.IsFalse(BorderComparer.Compare(a, b));
        }

        [Test]
        public void BorderComparerNullTest()
        {
            var a = new Border { Val = BorderValues.None };
            var a1 = new Border { Val = BorderValues.Nil };
            var BorderComparer = new BorderComparer();
            Assert.IsTrue(BorderComparer.Compare(a, null));
            Assert.IsTrue(BorderComparer.Compare(null, a));
            Assert.IsTrue(BorderComparer.Compare(a1, null));
            Assert.IsTrue(BorderComparer.Compare(null, a1));
            Assert.IsTrue(BorderComparer.Compare(null, null));
        }

        [Test]
        public void BorderComparerNullWrongTest()
        {
            var a = new Border { Val = BorderValues.Single };
            var BorderComparer = new BorderComparer();
            Assert.IsFalse(BorderComparer.Compare(a, null));
            Assert.IsFalse(BorderComparer.Compare(null, a));
        }
    }
}