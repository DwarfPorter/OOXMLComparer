using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Common;

namespace OOXMLComparer.Tables.TableProperties
{
    public class TableHeaderComparer : OnOffOnlyTypeComparer
    {
        public TableHeaderComparer(TableHeader a, TableHeader b) : base(a, b)
        {
        }
    }
}
