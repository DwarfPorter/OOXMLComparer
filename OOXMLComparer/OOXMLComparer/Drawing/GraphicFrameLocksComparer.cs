using DocumentFormat.OpenXml.Drawing;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Drawing
{
    public class GraphicFrameLocksComparer : OpenXmlElementComparer<GraphicFrameLocks>
    {
        public GraphicFrameLocksComparer(GraphicFrameLocks a, GraphicFrameLocks b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareNullElements(b, t => !t.NoGrouping.ToBool()
                    && !t.NoDrilldown.ToBool()
                    && !t.NoChangeAspect.ToBool()
                    && !t.NoGrouping.ToBool()
                    && !t.NoMove.ToBool()
                    && !t.NoResize.ToBool()
                    && !t.NoSelection.ToBool())
                ?? OpenXmlComparerHelper.EqualBool(a.NoGrouping, b.NoGrouping)
                && OpenXmlComparerHelper.EqualBool(a.NoDrilldown, b.NoDrilldown)
                && OpenXmlComparerHelper.EqualBool(a.NoChangeAspect, b.NoChangeAspect)
                && OpenXmlComparerHelper.EqualBool(a.NoGrouping, b.NoGrouping)
                && OpenXmlComparerHelper.EqualBool(a.NoMove, b.NoMove)
                && OpenXmlComparerHelper.EqualBool(a.NoResize, b.NoResize)
                && OpenXmlComparerHelper.EqualBool(a.NoSelection, b.NoSelection);
        }
    }
}