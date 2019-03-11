using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Paragraphs.SectionProperties
{
    public class PageBordersComparer : OpenXmlElementComparer<PageBorders>
    {
        public PageBordersComparer(PageBorders a, PageBorders b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareChildren2(b);
        }
    }
}
