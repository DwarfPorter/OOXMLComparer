using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Paragraphs.ParaProperties
{
    public class TextAlignmentComparer : OpenXmlElementComparer<TextAlignment>
    {
        public TextAlignmentComparer(TextAlignment a, TextAlignment b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareNullElements(b) ?? Equals(a.Val, b.Val);
        }
    }
}
