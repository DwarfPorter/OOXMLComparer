using DocumentFormat.OpenXml.Drawing.Wordprocessing;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Drawing
{
    public class EffectExtentComparer : OpenXmlElementComparer<EffectExtent>
    {
        public EffectExtentComparer(EffectExtent a, EffectExtent b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareNullElements(b, t =>t.TopEdge.ToInt64() == 0L 
                    && t.RightEdge.ToInt64() == 0L 
                    && t.LeftEdge.ToInt64() == 0 
                    && t.BottomEdge.ToInt64() == 0)
                ?? a.TopEdge.ToInt64() == b.TopEdge.ToInt64()
                    && a.BottomEdge.ToInt64() == b.BottomEdge.ToInt64()
                    && a.LeftEdge.ToInt64() == b.LeftEdge.ToInt64()
                    && a.RightEdge.ToInt64() == b.RightEdge.ToInt64();
        }
    }
}