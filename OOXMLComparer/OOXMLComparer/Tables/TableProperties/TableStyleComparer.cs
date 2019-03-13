using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Tables.TableProperties
{
    public class TableStyleComparer : OpenXmlElementComparer<TableStyle>
    {
        public TableStyleComparer(TableStyle a, TableStyle b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareNullElements(b) ?? Equals(a.Val, b.Val);
        }
    }
}
