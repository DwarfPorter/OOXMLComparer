using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Common
{
    public abstract class EmptyTypeComparer : OpenXmlElementComparer<EmptyType>
    {
        protected EmptyTypeComparer(EmptyType a, EmptyType b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareNullElements(b) ?? true;
        }
    }
}
