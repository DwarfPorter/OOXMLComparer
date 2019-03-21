using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Paragraphs.ParagraphProperties
{
    public class TabStopComparer : OpenXmlElementComparer<TabStop>
    {
        public TabStopComparer(TabStop a, TabStop b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareNullElements(b)
                ?? Equals(a.Val, b.Val)
                && Equals(a.Position, b.Position);
        }
    }
}
