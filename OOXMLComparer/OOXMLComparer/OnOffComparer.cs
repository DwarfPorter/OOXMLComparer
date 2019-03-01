using DocumentFormat.OpenXml.Wordprocessing;

namespace OOXMLComparer
{
    public abstract class OnOffComparer : IOpenXmlElementComparer<OnOffType>
    {
        public bool Compare(OnOffType a, OnOffType b)
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
