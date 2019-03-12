using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Paragraphs.ParaProperties
{
    public class TextDirectionComparer : OpenXmlElementComparer<TextDirection>
    {
        public TextDirectionComparer(TextDirection a, TextDirection b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareNullElements(b) ?? Equals(a.Val, b.Val);
        }
    }
}
