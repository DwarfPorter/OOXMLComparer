using DocumentFormat.OpenXml.Wordprocessing;

namespace OOXMLComparer.Properties
{
    public class UnderlineComparer : IOpenXmlElementComparer<Underline>
    {
        public bool Compare(Underline a, Underline b)
        {
            if (a == null && b == null)
            {
                return true;
            }
            if (a == null && b.Val == UnderlineValues.None)
            {
                return true;
            }
            if (b == null && a.Val == UnderlineValues.None)
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
