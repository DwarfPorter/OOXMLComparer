using DocumentFormat.OpenXml.Wordprocessing;

namespace OOXMLComparer.Properties
{
    public class FontSizeComparer : OpenXmlElementComparer<FontSize>
    {
        public FontSizeComparer(FontSize a, FontSize b) : base(a, b)
        {
        }

        public override bool Compare()
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
