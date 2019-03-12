using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Paragraphs.ParaProperties
{
    public class ParagraphPropertiesComparer : OpenXmlElementComparer<ParagraphProperties>
    {
        public ParagraphPropertiesComparer(ParagraphProperties a, ParagraphProperties b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareChildren2(b);
        }
    }
}
