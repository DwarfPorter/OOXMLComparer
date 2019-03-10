using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Texts
{
    public class BreakComparer : OpenXmlElementComparer<Break>
    {
        public BreakComparer(Break a, Break b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareNullElements(b) ?? Equals(a.Type ?? BreakValues.TextWrapping, b.Type ?? BreakValues.TextWrapping);
        }
    }
}
