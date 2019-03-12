using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Tables.TableProperties
{
    public class TableCellBordersComparer : OpenXmlElementComparer<TableCellBorders>
    {
        public TableCellBordersComparer(TableCellBorders a, TableCellBorders b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareChildren2(b);
        }
    }
    public class TableBordersComparer : OpenXmlElementComparer<TableBorders>
    {
        public TableCellBordersComparer(TableBorders a, TableBorders b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareChildren2(b);
        }
    }
}
