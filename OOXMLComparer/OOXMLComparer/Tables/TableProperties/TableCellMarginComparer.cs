using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Tables.TableProperties
{
    public class TableCellMarginComparer : OpenXmlElementComparer<TableCellMargin>
    {
        public TableCellMarginComparer(TableCellMargin a, TableCellMargin b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareChildren2(b);
        }
    }
}
