using OOXMLComparer.Helpers;

namespace OOXMLComparer.Paragraphs.SectionProperties
{
    public class SectionPropertiesComparer : OpenXmlElementComparer<DocumentFormat.OpenXml.Wordprocessing.SectionProperties>
    {
        public SectionPropertiesComparer(DocumentFormat.OpenXml.Wordprocessing.SectionProperties a, DocumentFormat.OpenXml.Wordprocessing.SectionProperties b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareChildren2(b);
        }
    }
}
