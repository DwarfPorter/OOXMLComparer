using DocumentFormat.OpenXml;
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
            return a.CompareNullElements(b, t => !ToBool(t.NoAdjustHandles)
                    && !ToBool(t.NoChangeArrowheads)
                    && !ToBool(t.NoChangeAspect)
                    && !ToBool(t.NoChangeShapeType)
                    && !ToBool(t.NoCrop)
                    && !ToBool(t.NoEditPoints)
                    && !ToBool(t.NoGrouping)
                    && !ToBool(t.NoMove)
                    && !ToBool(t.NoResize)
                    && !ToBool(t.NoRotation)
                    && !ToBool(t.NoSelection))
                ?? EqualBool(a.NoAdjustHandles, b.NoAdjustHandles)
                && EqualBool(a.NoChangeArrowheads, b.NoChangeArrowheads)
                && EqualBool(a.NoChangeAspect, b.NoChangeAspect)
                && EqualBool(a.NoChangeShapeType, b.NoChangeShapeType)
                && EqualBool(a.NoCrop, b.NoCrop)
                && EqualBool(a.NoEditPoints, b.NoEditPoints)
                && EqualBool(a.NoGrouping, b.NoGrouping)
                && EqualBool(a.NoMove, b.NoMove)
                && EqualBool(a.NoResize, b.NoResize)
                && EqualBool(a.NoRotation, b.NoRotation)
                && EqualBool(a.NoSelection, b.NoSelection);
        }

        private static bool ToBool(BooleanValue a)
        {
            if (a == null)
            {
                return false;
            }
            return BooleanValue.ToBoolean(a);
        }

        private static bool EqualBool(BooleanValue a, BooleanValue b)
        {
            return Equals(ToBool(a), ToBool(b));
        }
    }
}