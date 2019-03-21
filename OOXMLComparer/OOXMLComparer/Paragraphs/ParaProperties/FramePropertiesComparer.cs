using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Paragraphs.ParagraphProperties
{
    public class FramePropertiesComparer : OpenXmlElementComparer<FrameProperties>
    {
        public FramePropertiesComparer(FrameProperties a, FrameProperties b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareNullElements(b) 
                ?? Equals(a.Width, b.Width) 
                && Equals(a.Height, b.Height) 
                && Equals(a.HeightType, b.HeightType)
                && Equals(a.HorizontalSpace, b.HorizontalSpace)
                && Equals(a.Wrap, b.Wrap)
                && Equals(a.HorizontalPosition, b.HorizontalPosition)
                && Equals(a.VerticalSpace, b.VerticalSpace)
                && Equals(a.VerticalPosition, b.VerticalPosition)
                && Equals(a.AnchorLock, b.AnchorLock)
                && Equals(a.X, b.X)
                && Equals(a.Y, b.Y)
                && Equals(a.XAlign, b.XAlign)
                && Equals(a.YAlign, b.YAlign);
        }
    }
}
