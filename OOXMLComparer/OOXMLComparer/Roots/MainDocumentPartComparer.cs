using DocumentFormat.OpenXml.Packaging;

namespace OOXMLComparer.Roots
{
    public class MainDocumentPartComparer : IOpenXmlComparer
    {
        private readonly MainDocumentPart a;
        private readonly MainDocumentPart b;

        public MainDocumentPartComparer(MainDocumentPart a, MainDocumentPart b)
        {
            this.a = a;
            this.b = b;
        }

        public bool Compare()
        {
            var docComparer = new DocumentComparer(a.Document, b.Document);
            return docComparer.Compare();
        }
    }
}
