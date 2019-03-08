using DocumentFormat.OpenXml.Drawing.Pictures;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Drawing
{
    public class NonVisualPicturePropertiesComparer : OpenXmlElementComparer<NonVisualPictureProperties>
    {
        public NonVisualPicturePropertiesComparer(NonVisualPictureProperties a, NonVisualPictureProperties b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareChildren2(b);
        }
    }
}