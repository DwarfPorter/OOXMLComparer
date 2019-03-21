using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Helpers;
using System.Linq;

namespace OOXMLComparer.Paragraphs.SectionProperties
{
    public class SectionPropertiesComparer : OpenXmlElementComparer<DocumentFormat.OpenXml.Wordprocessing.SectionProperties>
    {
        public SectionPropertiesComparer(DocumentFormat.OpenXml.Wordprocessing.SectionProperties a, DocumentFormat.OpenXml.Wordprocessing.SectionProperties b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            var aHeaderReferences = a.Descendants<HeaderReference>().OrderBy(t => t.Type.Value);
            var bHeaderReferences = b.Descendants<HeaderReference>().OrderBy(t => t.Type.Value);
            var aFooterReferences = a.Descendants<FooterReference>().OrderBy(t => t.Type.Value);
            var bFooterReferences = b.Descendants<FooterReference>().OrderBy(t => t.Type.Value);
            var aOtherElement = a.ChildElements.Where(t => (t.GetType() != typeof(HeaderReference)) && (t.GetType() != typeof(FooterReference)));
            var bOtherElement = b.ChildElements.Where(t => (t.GetType() != typeof(HeaderReference)) && (t.GetType() != typeof(FooterReference)));

            return a.CompareNullElements(b) 
                ?? aHeaderReferences.CompareOrderedChildren(bHeaderReferences)
                && aFooterReferences.CompareOrderedChildren(bFooterReferences)
                && aOtherElement.CompareChildren2(bOtherElement);
        }
    }
}
