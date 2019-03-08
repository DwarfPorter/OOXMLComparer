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
            return a.CompareNullElements(b, t => !(t.NoAdjustHandles ?? false)
                    && !(t.NoChangeArrowheads ?? false)
                    && !(t.NoChangeAspect ?? false)
                    && !(t.NoChangeShapeType ?? false)
                    && !(t.NoCrop ?? false)
                    && !(t.NoEditPoints ?? false)
                    && !(t.NoGrouping ?? false)
                    && !(t.NoMove ?? false)
                    && !(t.NoResize ?? false)
                    && !(t.NoRotation ?? false)
                    && !(t.NoSelection ?? false))
                ?? Equals(BooleanValue.ToBoolean(a.NoAdjustHandles), BooleanValue.ToBoolean(b.NoAdjustHandles))
                && Equals(BooleanValue.ToBoolean(a.NoChangeArrowheads), BooleanValue.ToBoolean(b.NoChangeArrowheads))
                && Equals(BooleanValue.ToBoolean(a.NoChangeAspect), BooleanValue.ToBoolean(b.NoChangeAspect))
                && Equals(BooleanValue.ToBoolean(a.NoChangeShapeType), BooleanValue.ToBoolean(b.NoChangeShapeType))
                && Equals(BooleanValue.ToBoolean(a.NoCrop), BooleanValue.ToBoolean(b.NoCrop))
                && Equals(BooleanValue.ToBoolean(a.NoEditPoints), BooleanValue.ToBoolean(b.NoEditPoints))
                && Equals(BooleanValue.ToBoolean(a.NoGrouping), BooleanValue.ToBoolean(b.NoGrouping))
                && Equals(BooleanValue.ToBoolean(a.NoMove), BooleanValue.ToBoolean(b.NoMove))
                && Equals(BooleanValue.ToBoolean(a.NoResize), BooleanValue.ToBoolean(b.NoResize))
                && Equals(BooleanValue.ToBoolean(a.NoRotation), BooleanValue.ToBoolean(b.NoRotation))
                && Equals(BooleanValue.ToBoolean(a.NoSelection), BooleanValue.ToBoolean(b.NoSelection));
        }
    }
}