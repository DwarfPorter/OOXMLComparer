using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Paragraphs.SectionProperties
{
    public class PageMarginComparer : OpenXmlElementComparer<PageMargin>
    {
        public PageMarginComparer(PageMargin a, PageMargin b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareNullElements(b) 
                ?? Equals(a.Bottom, b.Bottom)
                && Equals(a.Footer, b.Footer)
                && Equals(a.Header, b.Header)
                && Equals(a.Gutter, b.Gutter)
                && Equals(a.Left, b.Left)
                && Equals(a.Right, b.Right)
                && Equals(a.Top, b.Top);
        }
    }
}