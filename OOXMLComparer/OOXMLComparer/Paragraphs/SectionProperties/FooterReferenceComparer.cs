using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Helpers;
using OOXMLComparer.Roots;
using System.Linq;

namespace OOXMLComparer.Paragraphs.SectionProperties
{
    public class FooterReferenceComparer : OpenXmlElementComparer<FooterReference>
    {
        public FooterReferenceComparer(FooterReference a, FooterReference b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            if (!(a.CompareNullElements(b) ?? Equals(a.Type, b.Type)))
            {
                return false;
            }
            FooterPart aFooterPart = GetFooterPart(a);
            FooterPart bFooterPart = GetFooterPart(b);
            if (aFooterPart == null && bFooterPart == null)
            {
                return true;
            }
            if (aFooterPart == null)
            {
                return false;
            }
            var FooterPartComparer = new FooterPartComparer(aFooterPart, bFooterPart);
            return FooterPartComparer.Compare();
        }

        private FooterPart GetFooterPart(FooterReference a)
        {
            FooterPart footerPart = null;
            Document document = a.Ancestors<Document>().FirstOrDefault();
            if (document != null)
            {
                MainDocumentPart mainDocument = document.MainDocumentPart;
                footerPart = (FooterPart)mainDocument.GetPartById(a.Id);
            }
            return footerPart;
        }
    }
}
