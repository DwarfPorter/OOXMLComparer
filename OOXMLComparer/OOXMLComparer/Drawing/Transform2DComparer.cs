using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Drawing.Pictures;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Drawing
{
    public class Transform2DComparer : OpenXmlElementComparer<Transform2D>
    {
        public Transform2DComparer(Transform2D a, Transform2D b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareChildren2(b);
        }
    }
}