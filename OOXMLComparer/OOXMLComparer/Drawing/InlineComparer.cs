using DocumentFormat.OpenXml.Drawing.Wordprocessing;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Drawing
{
    public class InlineComparer : OpenXmlElementComparer<Inline>
    {
        public InlineComparer(Inline a, Inline b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareNullElements(b, t => t.DistanceFromTop.ToUInt32() == 0 
                    && t.DistanceFromBottom.ToUInt32() == 0 
                    && t.DistanceFromLeft.ToUInt32() == 0
                    && t.DistanceFromRight.ToUInt32() == 0)
                ?? a.DistanceFromTop.ToUInt32() == b.DistanceFromTop.ToUInt32() 
                    && a.DistanceFromBottom.ToUInt32() == b.DistanceFromBottom.ToUInt32()
                    && a.DistanceFromLeft.ToUInt32() == b.DistanceFromLeft.ToUInt32()
                    && a.DistanceFromRight.ToUInt32() == b.DistanceFromRight.ToUInt32()
                && a.CompareChildren2(b);
        }
    }
    
}