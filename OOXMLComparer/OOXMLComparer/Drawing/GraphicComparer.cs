using DocumentFormat.OpenXml.Drawing;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Drawing
{
    public class GraphicComparer : OpenXmlElementComparer<Graphic>
    {
        public GraphicComparer(Graphic a, Graphic b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareChildren2(b);
        }
    }
}