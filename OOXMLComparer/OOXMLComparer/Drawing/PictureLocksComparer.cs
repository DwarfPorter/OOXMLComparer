using DocumentFormat.OpenXml.Drawing;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Drawing
{
    public class PictureLocksComparer : OpenXmlElementComparer<PictureLocks>
    {
        public PictureLocksComparer(PictureLocks a, PictureLocks b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareNullElements(b, t => !t.NoAdjustHandles.ToBool()
                    && !t.NoChangeArrowheads.ToBool()
                    && !t.NoChangeAspect.ToBool()
                    && !t.NoChangeShapeType.ToBool()
                    && !t.NoCrop.ToBool()
                    && !t.NoEditPoints.ToBool()
                    && !t.NoGrouping.ToBool()
                    && !t.NoMove.ToBool()
                    && !t.NoResize.ToBool()
                    && !t.NoRotation.ToBool()
                    && !t.NoSelection.ToBool())
                ?? OpenXmlComparerHelper.EqualBool(a.NoAdjustHandles, b.NoAdjustHandles)
                && OpenXmlComparerHelper.EqualBool(a.NoChangeArrowheads, b.NoChangeArrowheads)
                && OpenXmlComparerHelper.EqualBool(a.NoChangeAspect, b.NoChangeAspect)
                && OpenXmlComparerHelper.EqualBool(a.NoChangeShapeType, b.NoChangeShapeType)
                && OpenXmlComparerHelper.EqualBool(a.NoCrop, b.NoCrop)
                && OpenXmlComparerHelper.EqualBool(a.NoEditPoints, b.NoEditPoints)
                && OpenXmlComparerHelper.EqualBool(a.NoGrouping, b.NoGrouping)
                && OpenXmlComparerHelper.EqualBool(a.NoMove, b.NoMove)
                && OpenXmlComparerHelper.EqualBool(a.NoResize, b.NoResize)
                && OpenXmlComparerHelper.EqualBool(a.NoRotation, b.NoRotation)
                && OpenXmlComparerHelper.EqualBool(a.NoSelection, b.NoSelection);
        }
    }
}