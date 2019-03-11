using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Paragraphs
{
    public class TopBorderComparer : BorderTypeComparer
    {
        public TopBorderComparer(TopBorder a, TopBorder b) : base(a, b) { }
    }
}
