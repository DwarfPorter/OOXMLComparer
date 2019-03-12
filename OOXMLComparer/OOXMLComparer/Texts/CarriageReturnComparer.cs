using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Common;

namespace OOXMLComparer.Texts
{
    public class CarriageReturnComparer : EmptyTypeComparer
    {
        public CarriageReturnComparer(CarriageReturn a, CarriageReturn b) : base(a, b)
        {
        }
    }
}
