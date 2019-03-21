using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Common;

namespace OOXMLComparer.Paragraphs.ParagraphProperties
{
    public class ContextualSpacingComparer : OnOffComparer
    {
        public ContextualSpacingComparer(ContextualSpacing a, ContextualSpacing b) : base(a, b)
        {
        }
    }
}
