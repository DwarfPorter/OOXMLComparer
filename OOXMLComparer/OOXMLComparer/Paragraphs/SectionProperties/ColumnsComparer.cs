using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Paragraphs.SectionProperties
{
    public class ColumnsComparer : OpenXmlElementComparer<Columns>
    {
        public ColumnsComparer(Columns a, Columns b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareNullElements(b) 
                ?? Equals(a.EqualWidth, b.EqualWidth) 
                && Equals(a.Space, b.Space) 
                && Equals(a.ColumnCount, b.ColumnCount)
                && Equals(a.Separator, b.Separator)
                && a.ChildElements.CompareOrderedChildren(b.ChildElements);
        }
    }
}
