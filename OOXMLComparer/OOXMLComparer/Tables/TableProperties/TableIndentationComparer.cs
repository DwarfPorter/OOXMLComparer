using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Tables.TableProperties
{
    public class TableIndentationComparer : OpenXmlElementComparer<TableIndentation>
    {
        public TableIndentationComparer(TableIndentation a, TableIndentation b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareNullElements(b)
                ?? Equals(a.Type, b.Type)
                && Equals(a.Width, b.Width);
        }
    }
}
