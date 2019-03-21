using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Paragraphs.ParagraphProperties
{
    public class ParagraphStyleIdComparer : OpenXmlElementComparer<ParagraphStyleId>
    {
        public ParagraphStyleIdComparer(ParagraphStyleId a, ParagraphStyleId b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareNullElements(b) ?? Equals(a.Val, b.Val);
        }
    }
}
