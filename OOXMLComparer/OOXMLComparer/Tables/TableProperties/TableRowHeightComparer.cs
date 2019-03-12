using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Tables.TableProperties
{
    public class TableRowHeightComparer : OpenXmlElementComparer<TableRowHeight>
    {
        public TableRowHeightComparer(TableRowHeight a, TableRowHeight b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareNullElements(b)
                ?? Equals(a.HeightType, b.HeightType)
                && Equals(a.Val, b.Val);
        }
    }
}