using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Helpers;
using OOXMLComparer.Paragraphs.ParaProperties;
using System.Linq;

namespace OOXMLComparer.Paragraphs
{
    public class ParagraphComparer : OpenXmlElementComparer<Paragraph>
    {
        public ParagraphComparer(Paragraph a, Paragraph b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareOrderedChildren(b, t => ((Paragraph)t).ParagraphProperties);
        }
    }
}
