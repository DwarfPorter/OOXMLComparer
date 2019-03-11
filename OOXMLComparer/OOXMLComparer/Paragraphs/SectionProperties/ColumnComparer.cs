using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Paragraphs.SectionProperties
{
    public class ColumnComparer : OpenXmlElementComparer<Column>
    {
        public ColumnComparer(Column a, Column b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareNullElements(b) ?? Equals(a.Width, b.Width) && Equals(a.Space, b.Space);
        }
    }
}
