using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Properties;

namespace OOXMLComparer.Test
{
    public class RunPropertiesComparerTests
    {
        [Test]
        public void RunPropertiesComparerEmptyTest()
        {
            var a = new RunProperties();
            var b = new RunProperties();
            var runPropertiesComparer = new RunPropertiesComparer();
            Assert.IsTrue(runPropertiesComparer.Compare(a, b));
        }

        [Test]
        public void RunPropertiesComparerTest()
        {
            var a = new RunProperties { Underline = new Underline{Val = UnderlineValues.DashLong}, Italic = new Italic{ Val = true } };
            var b = new RunProperties { Underline = new Underline{Val = UnderlineValues.DashLong}, Italic = new Italic{ Val = true }  };
            var runPropertiesComparer = new RunPropertiesComparer();
            Assert.IsTrue(runPropertiesComparer.Compare(a, b));

            var a1 = new RunProperties (new List<OpenXmlElement> { new Underline{Val = UnderlineValues.DashLong}, new Bold {Val = true} });
            var b1 = new RunProperties (new List<OpenXmlElement> { new Underline{Val = UnderlineValues.DashLong}, new Bold {Val = true} });
            Assert.IsTrue(runPropertiesComparer.Compare(a1, b1));

            var a2 = new RunProperties { Underline = new Underline{Val = UnderlineValues.DashLong}, Italic = new Italic{ Val = false } };
            var b2 = new RunProperties { Underline = new Underline{Val = UnderlineValues.DashLong}  };
            Assert.IsTrue(runPropertiesComparer.Compare(a2, b2));

            var a3 = new RunProperties (new List<OpenXmlElement> { new Underline{Val = UnderlineValues.DashLong}, new Bold {Val = false} });
            var b3 = new RunProperties (new List<OpenXmlElement> { new Underline{Val = UnderlineValues.DashLong} });
            Assert.IsTrue(runPropertiesComparer.Compare(a3, b3));

        }

        [Test]
        public void RunPropertiesComparerNullTest()
        {
            var a = new RunProperties ();
            var runPropertiesComparer = new RunPropertiesComparer();
            Assert.IsTrue(runPropertiesComparer.Compare(a, null));
            Assert.IsTrue(runPropertiesComparer.Compare(null, null));
            Assert.IsTrue(runPropertiesComparer.Compare(null, a));
        }



        [Test]
        public void RunPropertiesComparerWrongTest()
        {
            var a = new RunProperties { Underline = new Underline{Val = UnderlineValues.DashLong}, Italic = new Italic{ Val = true } };
            var b = new RunProperties { Underline = new Underline{Val = UnderlineValues.DashLong}, Italic = new Italic{ Val = false }  };
            var runPropertiesComparer = new RunPropertiesComparer();
            Assert.IsFalse(runPropertiesComparer.Compare(a, b));

            var a1 = new RunProperties { Underline = new Underline{Val = UnderlineValues.DashLong}, Italic = new Italic{ Val = true } };
            var b1 = new RunProperties { Underline = new Underline{Val = UnderlineValues.DashLong}};
            Assert.IsFalse(runPropertiesComparer.Compare(a1, b1));

            var a2 = new RunProperties (new List<OpenXmlElement> { new Underline{Val = UnderlineValues.DashLong}, new Bold {Val = true} });
            var b2 = new RunProperties (new List<OpenXmlElement> { new Underline{Val = UnderlineValues.DashLong}, new Bold {Val = false} });
            Assert.IsFalse(runPropertiesComparer.Compare(a2, b2));

            var a3 = new RunProperties (new List<OpenXmlElement> { new Underline{Val = UnderlineValues.DashLong}, new Bold {Val = true} });
            var b3 = new RunProperties (new List<OpenXmlElement> { new Underline{Val = UnderlineValues.DashLong} });
            Assert.IsFalse(runPropertiesComparer.Compare(a3, b3));

        }
    }
}