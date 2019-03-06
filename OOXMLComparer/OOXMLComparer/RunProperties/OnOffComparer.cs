using DocumentFormat.OpenXml.Wordprocessing;

namespace OOXMLComparer.Properties
{
    public abstract class OnOffComparer : OpenXmlElementComparer<OnOffType>
    {
        protected OnOffComparer(OnOffType a, OnOffType b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            if (a == null && b == null)
            {
                return true;
            }
            if (a == null && b.Val == false)
            {
                return true;
            }
            if (b == null && a.Val == false)
            {
                return true;
            }
            if (a == null || b == null)
            {
                return false;
            }
            return Equals(a.Val, b.Val);
        }
    }
}
