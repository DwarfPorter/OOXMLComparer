using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Properties;
using System.Collections.Generic;

namespace OOXMLComparer.Test.Runs
{
    [Category("OOXML")]
    public class RunPropertiesComparerTests
    {
        [Test]
        public void RunPropertiesComparerEmptyTest()
        {
            var a = new RunProperties();
            var b = new RunProperties();
            var runPropertiesComparer = new RunPropertiesComparer(a, b);
            Assert.IsTrue(runPropertiesComparer.Compare());
        }

        [Test]
        public void RunPropertiesComparerTest()
        {
            var a = new RunProperties { Underline = new Underline{Val = UnderlineValues.DashLong}, Italic = new Italic{ Val = true } };
            var b = new RunProperties { Underline = new Underline{Val = UnderlineValues.DashLong}, Italic = new Italic{ Val = true }  };
            var runPropertiesComparer = new RunPropertiesComparer(a, b);
            Assert.IsTrue(runPropertiesComparer.Compare());

            var a1 = new RunProperties (new List<OpenXmlElement> { new Underline{Val = UnderlineValues.DashLong}, new Bold {Val = true} });
            var b1 = new RunProperties (new List<OpenXmlElement> { new Underline{Val = UnderlineValues.DashLong}, new Bold {Val = true} });
            Assert.IsTrue(new RunPropertiesComparer(a1, b1).Compare());

            var a2 = new RunProperties { Underline = new Underline{Val = UnderlineValues.DashLong}, Italic = new Italic{ Val = false } };
            var b2 = new RunProperties { Underline = new Underline{Val = UnderlineValues.DashLong}  };
            Assert.IsTrue(new RunPropertiesComparer(a2, b2).Compare());

            var a3 = new RunProperties (new List<OpenXmlElement> { new Underline{Val = UnderlineValues.DashLong}, new Bold {Val = false} });
            var b3 = new RunProperties (new List<OpenXmlElement> { new Underline{Val = UnderlineValues.DashLong} });
            Assert.IsTrue(new RunPropertiesComparer(a3, b3).Compare());

        }

        [Test]
        public void RunPropertiesComparerBNullTest()
        {
            var a = new RunProperties();
            var runPropertiesComparer = new RunPropertiesComparer(a, null);
            Assert.IsTrue(runPropertiesComparer.Compare());
        }

        [Test]
        public void RunPropertiesComparerWrongTest()
        {
            var a = new RunProperties { Underline = new Underline{Val = UnderlineValues.DashLong}, Italic = new Italic{ Val = true } };
            var b = new RunProperties { Underline = new Underline{Val = UnderlineValues.DashLong}, Italic = new Italic{ Val = false }  };
            var runPropertiesComparer = new RunPropertiesComparer(a, b);
            Assert.IsFalse(runPropertiesComparer.Compare());

            var a1 = new RunProperties { Underline = new Underline{Val = UnderlineValues.DashLong}, Italic = new Italic{ Val = true } };
            var b1 = new RunProperties { Underline = new Underline{Val = UnderlineValues.DashLong}};
            Assert.IsFalse(new RunPropertiesComparer(a1, b1).Compare());

            var a2 = new RunProperties (new List<OpenXmlElement> { new Underline{Val = UnderlineValues.DashLong}, new Bold {Val = true} });
            var b2 = new RunProperties (new List<OpenXmlElement> { new Underline{Val = UnderlineValues.DashLong}, new Bold {Val = false} });
            Assert.IsFalse(new RunPropertiesComparer(a2, b2).Compare());

            var a3 = new RunProperties (new List<OpenXmlElement> { new Underline{Val = UnderlineValues.DashLong}, new Bold {Val = true} });
            var b3 = new RunProperties (new List<OpenXmlElement> { new Underline{Val = UnderlineValues.DashLong} });
            Assert.IsFalse(new RunPropertiesComparer(a3, b3).Compare());
        }
    }
}