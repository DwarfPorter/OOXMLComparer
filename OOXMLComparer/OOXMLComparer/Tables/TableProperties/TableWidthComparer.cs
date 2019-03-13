using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Tables.TableProperties
{
    public class TableWidthComparer : OpenXmlElementComparer<TableWidth>
    {
        public TableWidthComparer(TableWidth a, TableWidth b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareNullElements(b) ?? Equals(a.Type, b.Type) && Equals(a.Width, b.Width);
        }
    }
}
