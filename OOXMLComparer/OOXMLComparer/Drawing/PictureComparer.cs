using OOXMLComparer.Helpers;

namespace OOXMLComparer.Drawing
{
    public class PictureComparer : OpenXmlElementComparer<DocumentFormat.OpenXml.Drawing.Pictures.Picture>
    {
        public PictureComparer(DocumentFormat.OpenXml.Drawing.Pictures.Picture a, DocumentFormat.OpenXml.Drawing.Pictures.Picture b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareChildren2(b);
        }
    }
}