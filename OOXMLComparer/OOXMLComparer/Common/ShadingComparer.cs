using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Common
{
    public class ShadingComparer : OpenXmlElementComparer<Shading>
    {
        public ShadingComparer(Shading a, Shading b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareNullElements(b)
                ?? Equals(a.Color, b.Color)
                && Equals(a.Val, b.Val)
                && Equals(a.Fill, b.Fill)
                && Equals(a.ThemeColor, b.ThemeColor)
                && Equals(a.ThemeFill, b.ThemeFill)
                && Equals(a.ThemeFillShade, b.ThemeFillShade)
                && Equals(a.ThemeTint, b.ThemeTint)
                && Equals(a.ThemeFillTint, b.ThemeFillTint)
                && Equals(a.ThemeShade, b.ThemeShade);
        }
    }
}