using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Tables.TableProperties
{
    public class TableLayoutComparer : OpenXmlElementComparer<TableLayout>
    {
        public TableLayoutComparer(TableLayout a, TableLayout b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareNullElements(b, t => t.Type == TableLayoutValues.Autofit) 
                ?? Equals(a.Type ?? TableLayoutValues.Autofit, b.Type ?? TableLayoutValues.Autofit);
        }
    }
}
