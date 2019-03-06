using DocumentFormat.OpenXml.Drawing;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Drawing
{
    public class StretchComparer : OpenXmlElementComparer<Stretch>
    {
        public StretchComparer(Stretch a, Stretch b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareNullElements(b, t => t.FillRectangle == null) ?? ((a.FillRectangle == null && b.FillRectangle == null) || (a.FillRectangle != null && b.FillRectangle != null));
        }
    }
}