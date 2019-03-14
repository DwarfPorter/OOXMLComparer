using DocumentFormat.OpenXml.Packaging;

namespace OOXMLComparer.Roots
{
    public class MainDocumentPartComparer : OpenXmlPartComparer<MainDocumentPart>
    {
        public MainDocumentPartComparer(MainDocumentPart a, MainDocumentPart b):base(a, b)
        {
        }

        public override bool Compare()
        {
            var docComparer = new DocumentComparer(a.Document, b.Document);
            return docComparer.Compare();
        }
    }

}
