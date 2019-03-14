using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Tables.TableProperties
{
    public class TableLookComparer : OpenXmlElementComparer<TableLook>
    {
        public TableLookComparer(TableLook a, TableLook b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareNullElements(b)
                ?? Equals(a.FirstColumn, b.FirstColumn)
                && Equals(a.FirstRow, b.FirstRow)
                && Equals(a.LastColumn, b.LastColumn)
                && Equals(a.LastRow, b.LastRow)
                && Equals(a.NoHorizontalBand, b.NoHorizontalBand)
                && Equals(a.NoVerticalBand, b.NoVerticalBand)
                && Equals(a.Val, b.Val);
        }
    }
}
