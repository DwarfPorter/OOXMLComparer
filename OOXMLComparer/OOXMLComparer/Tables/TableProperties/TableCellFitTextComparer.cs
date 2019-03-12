using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Common;

namespace OOXMLComparer.Tables.TableProperties
{
    public class TableCellFitTextComparer : OnOffOnlyTypeComparer
    {
        public TableCellFitTextComparer(TableCellFitText a, TableCellFitText b) : base(a, b)
        {
        }
    }
}
