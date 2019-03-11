using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Paragraphs
{
    public class BottomBorderComparer : BorderTypeComparer
    {
        public BottomBorderComparer(BottomBorder a, BottomBorder b) : base(a, b) { }
    }
}
