using DocumentFormat.OpenXml.Wordprocessing;

namespace OOXMLComparer
{
    public class BoldComparer : IOpenXmlElementComparer<Bold>
    {
        public bool Compare(Bold a, Bold b)
        {
            if (a == null && b== null)
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

    public class ItalicComparer : IOpenXmlElementComparer<Italic>
    {
        public bool Compare(Italic a, Italic b)
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
