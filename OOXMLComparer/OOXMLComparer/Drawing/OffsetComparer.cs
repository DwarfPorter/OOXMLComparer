using DocumentFormat.OpenXml.Drawing;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Drawing
{
    public class OffsetComparer : OpenXmlElementComparer<Offset>
    {
        public OffsetComparer(Offset a, Offset b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareNullElements(b, t => t.X.ToInt64() == 0L && t.Y.ToInt64() == 0L) ?? a.X.ToInt64() == b.X.ToInt64() && a.Y.ToInt64() == b.Y.ToInt64();
        }
    }
}