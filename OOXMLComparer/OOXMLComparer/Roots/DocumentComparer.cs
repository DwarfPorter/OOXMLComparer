using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Roots
{
    public class DocumentComparer : OpenXmlElementComparer<Document>
    {
        public DocumentComparer(Document a, Document b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareOrderedChildren(b);
        }
    }
}
