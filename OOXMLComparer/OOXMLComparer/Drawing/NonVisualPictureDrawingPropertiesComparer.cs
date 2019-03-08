using DocumentFormat.OpenXml.Drawing.Pictures;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Drawing
{
    public class NonVisualPictureDrawingPropertiesComparer : OpenXmlElementComparer<DocumentFormat.OpenXml.Drawing.Pictures.NonVisualPictureDrawingProperties>
    {
        public NonVisualPictureDrawingPropertiesComparer(DocumentFormat.OpenXml.Drawing.Pictures.NonVisualPictureDrawingProperties a, DocumentFormat.OpenXml.Drawing.Pictures.NonVisualPictureDrawingProperties b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareNullElements(b, t => !t.PreferRelativeResize.ToBool()) ?? a.PreferRelativeResize.EqualBool(b.PreferRelativeResize) && a.CompareChildren2(b);
        }
    }
}