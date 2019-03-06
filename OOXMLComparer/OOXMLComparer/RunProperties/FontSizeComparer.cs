using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Properties
{
    public class FontSizeComparer : OpenXmlElementComparer<FontSize>
    {
        public FontSizeComparer(FontSize a, FontSize b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareNullElements(b) ?? Equals(a.Val, b.Val);
        }
    }
}
