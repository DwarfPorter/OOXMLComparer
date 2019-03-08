using DocumentFormat.OpenXml.Drawing;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Drawing
{
    public class NonVisualPictureDrawingPropertiesComparer : OpenXmlElementComparer<NonVisualPictureDrawingProperties>
    {
        public NonVisualPictureDrawingPropertiesComparer(NonVisualPictureDrawingProperties a, NonVisualPictureDrawingProperties b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareNullElements(b, t => !t.PreferRelativeResize.ToBool()) ?? a.PreferRelativeResize.EqualBool(b.PreferRelativeResize) && a.CompareChildren2(b);
        }
    }
}