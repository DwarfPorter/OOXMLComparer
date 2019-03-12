using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Texts;

namespace OOXMLComparer.Test.Runs
{
    public class CarriageReturnComparerTests
    {
        [Test]
        public void CarriageReturnComparerTest()
        {
            var a = new CarriageReturn();
            var b = new CarriageReturn();
            Assert.IsTrue(new CarriageReturnComparer(a, b).Compare());
            Assert.IsTrue(new CarriageReturnComparer(null, null).Compare());
            Assert.IsFalse(new CarriageReturnComparer(a, null).Compare());
            Assert.IsFalse(new CarriageReturnComparer(null, a).Compare());
        }
    }

}