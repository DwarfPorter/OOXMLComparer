using DocumentFormat.OpenXml.Drawing.Wordprocessing;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Drawing
{
    public class NonVisualGraphicFrameDrawingPropertiesComparer : OpenXmlElementComparer<NonVisualGraphicFrameDrawingProperties>
    {
        public NonVisualGraphicFrameDrawingPropertiesComparer(NonVisualGraphicFrameDrawingProperties a, NonVisualGraphicFrameDrawingProperties b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareChildren2(b);
        }
    }
}