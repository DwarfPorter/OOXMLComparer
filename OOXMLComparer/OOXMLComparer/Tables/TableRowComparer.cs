using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Tables
{
    public class TableRowComparer : OpenXmlElementComparer<TableRow>
    {
        public TableRowComparer(TableRow a, TableRow b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareOrderedChildren(b, t => ((TableRow)t).TableRowProperties);
        }
    }
}
