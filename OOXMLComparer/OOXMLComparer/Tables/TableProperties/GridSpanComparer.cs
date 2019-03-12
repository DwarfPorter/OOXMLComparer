using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Tables.TableProperties
{
    public class GridSpanComparer : OpenXmlElementComparer<GridSpan>
    {
        public GridSpanComparer(GridSpan a, GridSpan b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareNullElements(b) ?? Equals(a.Val, b.Val);
        }
    }
}
