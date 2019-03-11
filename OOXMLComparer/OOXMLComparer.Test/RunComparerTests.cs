using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Texts;

namespace OOXMLComparer.Test
{
    public class RunComparerTests
    {
        [Test]
        public void RunComparerTest()
        {
            var a = new Run();
            var b = new Run();
            Assert.IsTrue(new RunComparer(a, b).Compare());
        }

        [Test]
        public void RunComparerHappyTest()
        {
            var a = new Run(new Break(), new Text("Test")) { RunProperties = new RunProperties { Bold = new Bold { Val = true } } };
            var b = new Run(new Break(), new Text("Test")) { RunProperties = new RunProperties { Bold = new Bold { Val = true } } };
            Assert.IsTrue(new RunComparer(a, b).Compare());
        }

        [Test]
        public void RunComparerWrongTest()
        {
            var a = new Run(new Break(), new Text("Test")) { RunProperties = new RunProperties { Bold = new Bold { Val = true } } };
            var b = new Run(new Text("Test"));
            Assert.IsFalse(new RunComparer(a, b).Compare());
        }

        [Test]
        public void RunComparerChildrenWrongTest()
        {
            var a = new Run(new Break(), new Text("Test")) { RunProperties = new RunProperties { Bold = new Bold { Val = true } } };
            var b = new Run(new Text("Test")) { RunProperties = new RunProperties { Bold = new Bold { Val = true } } };
            Assert.IsFalse(new RunComparer(a, b).Compare());
        }

        [Test]
        public void RunComparerPropertiesWrongTest()
        {
            var a = new Run(new Break(), new Text("Test")) { RunProperties = new RunProperties { Bold = new Bold { Val = true } } };
            var b = new Run(new Break(), new Text("Test")) { RunProperties = new RunProperties () };
            Assert.IsFalse(new RunComparer(a, b).Compare());
        }


    }
}