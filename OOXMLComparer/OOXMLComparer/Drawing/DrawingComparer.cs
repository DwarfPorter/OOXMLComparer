using OOXMLComparer.Helpers;

namespace OOXMLComparer.Drawing
{
    public class DrawingComparer : OpenXmlElementComparer<DocumentFormat.OpenXml.Wordprocessing.Drawing>
    {
        public DrawingComparer(DocumentFormat.OpenXml.Wordprocessing.Drawing a, DocumentFormat.OpenXml.Wordprocessing.Drawing b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareChildren2(b);
        }
    }
}