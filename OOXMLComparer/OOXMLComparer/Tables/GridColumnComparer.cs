using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Tables
{
    public class GridColumnComparer : OpenXmlElementComparer<GridColumn>
    {
        public GridColumnComparer(GridColumn a, GridColumn b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareNullElements(b) ?? Equals(a.Width, b.Width);
        }
    }
}
