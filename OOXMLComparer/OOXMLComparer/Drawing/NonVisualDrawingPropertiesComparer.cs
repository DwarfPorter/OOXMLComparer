using DocumentFormat.OpenXml.Drawing;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Drawing
{
    public class NonVisualDrawingPropertiesComparer : OpenXmlElementComparer<NonVisualDrawingProperties>
    {
        public NonVisualDrawingPropertiesComparer(NonVisualDrawingProperties a, NonVisualDrawingProperties b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareNullElements(b, t => !t.Hidden.ToBool()) ?? a.Hidden.EqualBool(b.Hidden);
        }
    }
}