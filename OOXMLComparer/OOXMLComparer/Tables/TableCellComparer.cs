using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Tables
{
    public class TableCellComparer : OpenXmlElementComparer<TableCell>
    {
        public TableCellComparer(TableCell a, TableCell b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareOrderedChildren(b);
        }
    }
}
