using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Common;

namespace OOXMLComparer.Paragraphs.ParaProperties
{
    public class KeepLinesComparer : OnOffComparer
    {
        public KeepLinesComparer(KeepLines a, KeepLines b) : base(a, b)
        {
        }
    }
}
