using DocumentFormat.OpenXml.Drawing;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Drawing
{
    public class BlipComparer : OpenXmlElementComparer<Blip>
    {
        public BlipComparer(Blip a, Blip b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            var answer = a.CompareNullElements(b);
            if (answer != null)
            {
                return answer.Value;
            }

            var partA = ImagePartGetter.Create(a);
            var partB = ImagePartGetter.Create(b);

            if (partA.GetTypeOfRoot() != partB.GetTypeOfRoot())
            {
                return false;
            }
            return ImagePartGetter.BytesComparer(partA.GetImage(), partB.GetImage());
        }
    }
    
}