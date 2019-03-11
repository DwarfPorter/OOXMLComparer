using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Paragraphs
{
    public class ParagraphMarkRunPropertiesComparer : OpenXmlElementComparer<ParagraphMarkRunProperties>
    {
        public ParagraphMarkRunPropertiesComparer(ParagraphMarkRunProperties a, ParagraphMarkRunProperties b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareChildren2(b);
        }
    }
}
