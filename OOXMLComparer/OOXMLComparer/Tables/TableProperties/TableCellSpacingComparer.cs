using DocumentFormat.OpenXml.Wordprocessing;

namespace OOXMLComparer.Tables.TableProperties
{
    public class TableCellSpacingComparer : TableWidthTypeComparer
    {
        public TableCellSpacingComparer(TableCellSpacing a, TableCellSpacing b) : base(a, b)
        {
        }
    }
}
