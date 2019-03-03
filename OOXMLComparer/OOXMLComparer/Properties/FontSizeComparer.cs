using DocumentFormat.OpenXml.Wordprocessing;

namespace OOXMLComparer.Properties
{
    public class FontSizeComparer : IOpenXmlElementComparer<FontSize>
    {
        public bool Compare(FontSize a, FontSize b)
        {
            if (a == null && b == null)
            {
                return true;
            }
            if (a == null && b != null)
            {
                return false;
            }
            if (a != null && b == null)
            {
                return false;
            }
            return Equals(a.Val, b.Val);
        }
    }
}
