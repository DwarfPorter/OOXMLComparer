using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Tables.TableProperties
{
    public class TableCellVerticalAlignmentComparer : OpenXmlElementComparer<TableCellVerticalAlignment>
    {
        public TableCellVerticalAlignmentComparer(TableCellVerticalAlignment a, TableCellVerticalAlignment b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareNullElements(b) ?? Equals(a.Val, b.Val);
        }
    }
}
