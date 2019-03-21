using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Paragraphs.ParagraphProperties
{
    public class ParagraphPropertiesComparer : OpenXmlElementComparer<DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties>
    {
        public ParagraphPropertiesComparer(DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties a, DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareChildren2(b);
        }
    }
}
