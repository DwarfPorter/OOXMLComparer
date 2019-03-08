using DocumentFormat.OpenXml.Drawing;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Drawing
{
    public class ShapePropertiesComparer : OpenXmlElementComparer<DocumentFormat.OpenXml.Drawing.Pictures.ShapeProperties>
    {
        public ShapePropertiesComparer(DocumentFormat.OpenXml.Drawing.Pictures.ShapeProperties a, DocumentFormat.OpenXml.Drawing.Pictures.ShapeProperties b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareNullElements(b) ?? (Equals(a.BlackWhiteMode, b.BlackWhiteMode) && a.CompareChildren2(b));
        }
    }
    public class PictureLocksComparer : OpenXmlElementComparer<PictureLocks>
    {
        public PictureLocksComparer(PictureLocks a, PictureLocks b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return true;
        }
    }
}