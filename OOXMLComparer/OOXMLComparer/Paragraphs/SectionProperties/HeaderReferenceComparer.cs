using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Helpers;
using OOXMLComparer.Roots;
using System.Linq;

namespace OOXMLComparer.Paragraphs.SectionProperties
{
    public class HeaderReferenceComparer : OpenXmlElementComparer<HeaderReference>
    {
        public HeaderReferenceComparer(HeaderReference a, HeaderReference b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            if (!(a.CompareNullElements(b) ?? Equals(a.Type, b.Type)))
            {
                return false;
            }
            HeaderPart aHeaderPart = GetHeaderPart(a);
            HeaderPart bHeaderPart = GetHeaderPart(b);
            if (aHeaderPart == null && bHeaderPart == null)
            {
                return true;
            }
            if (aHeaderPart == null)
            {
                return false;
            }
            var headerPartComparer = new HeaderPartComparer(aHeaderPart, bHeaderPart);
            return headerPartComparer.Compare();
        }

        private HeaderPart GetHeaderPart(HeaderReference a)
        {
            HeaderPart headerPart = null;
            Document document = a.Ancestors<Document>().FirstOrDefault();
            if (document != null)
            {
                MainDocumentPart mainDocument = document.MainDocumentPart;
                headerPart = (HeaderPart)mainDocument.GetPartById(a.Id);
            }
            return headerPart;
        }
    }
}
