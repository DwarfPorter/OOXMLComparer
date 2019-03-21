using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Texts;

namespace OOXMLComparer.Test.Runs
{
    [Category("OOXML")]
    public class CarriageReturnComparerTests
    {
        [Test]
        public void CarriageReturnComparerTest()
        {
            var a = new CarriageReturn();
            var b = new CarriageReturn();
            Assert.IsTrue(ComparerFactory.Create(a, b).Compare());
            Assert.IsFalse(new CarriageReturnComparer(a, null).Compare());
        }
    }

}