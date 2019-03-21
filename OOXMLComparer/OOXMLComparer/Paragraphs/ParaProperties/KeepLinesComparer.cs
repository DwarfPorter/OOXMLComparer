using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Common;

namespace OOXMLComparer.Paragraphs.ParagraphProperties
{
    public class KeepLinesComparer : OnOffComparer
    {
        public KeepLinesComparer(KeepLines a, KeepLines b) : base(a, b)
        {
        }
    }
}
