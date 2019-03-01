using DocumentFormat.OpenXml.Wordprocessing;

namespace OOXMLComparer.Properties
{
    public class BorderComparer : IOpenXmlElementComparer<Border>
    {
        public bool Compare(Border a, Border b)
        {
            if (a == null && b == null)
            {
                return true;
            }
            if (a == null && (b.Val == BorderValues.None || b.Val == BorderValues.Nil))
            {
                return true;
            }
            if (b == null && (a.Val == BorderValues.None || a.Val == BorderValues.Nil))
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
