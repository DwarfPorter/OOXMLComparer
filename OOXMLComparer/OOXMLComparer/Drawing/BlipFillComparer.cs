using DocumentFormat.OpenXml.Drawing;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Drawing
{
    public class BlipFillComparer : OpenXmlElementComparer<BlipFill>
    {
        public BlipFillComparer(BlipFill a, BlipFill b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareNullElements(b) ?? ((a.SourceRectangle == null && b.SourceRectangle == null) || (a.SourceRectangle != null && b.SourceRectangle != null)) && a.CompareChildren2(b);
        }
    }
}