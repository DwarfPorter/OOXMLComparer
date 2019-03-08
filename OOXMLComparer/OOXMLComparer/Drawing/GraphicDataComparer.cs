using DocumentFormat.OpenXml.Drawing;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Drawing
{
    public class GraphicDataComparer : OpenXmlElementComparer<GraphicData>
    {
        public GraphicDataComparer(GraphicData a, GraphicData b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareChildren2(b);
        }
    }
}