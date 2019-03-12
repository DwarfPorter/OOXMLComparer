using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Paragraphs.ParaProperties
{
    public class ParagraphBordersComparer : OpenXmlElementComparer<ParagraphBorders>
    {
        public ParagraphBordersComparer(ParagraphBorders a, ParagraphBorders b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareChildren2(b);
        }
    }
}
