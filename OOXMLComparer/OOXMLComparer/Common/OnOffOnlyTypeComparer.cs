using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Common
{
    public abstract class OnOffOnlyTypeComparer : OpenXmlElementComparer<OnOffOnlyType>
    {
        protected OnOffOnlyTypeComparer(OnOffOnlyType a, OnOffOnlyType b) : base(a, b)
        {
        }
        public override bool Compare()
        {
            return a.CompareNullElements(b) ?? Equals(a.Val, b.Val);
        }
    }
}
