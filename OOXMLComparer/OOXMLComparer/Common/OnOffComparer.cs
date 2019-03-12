using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Common
{
    public abstract class OnOffComparer : OpenXmlElementComparer<OnOffType>
    {
        protected OnOffComparer(OnOffType a, OnOffType b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareNullElements(b, t => (t.Val ?? false) == false) ?? Equals(a.Val, b.Val);
        }
    }
}
