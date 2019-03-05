using DocumentFormat.OpenXml.Drawing;

namespace OOXMLComparer.Drawing
{
    public class OffsetComparer : OpenXmlElementComparer<Offset>
    {
        public OffsetComparer(Offset a, Offset b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            if (a == null && b == null)
            {
                return true;
            }
            if (a == null && (b.X == null || b.X == 0L) && (b.Y == null || b.Y == 0L))
            {
                return true;
            }
            if (b == null && (a.X == null || a.X == 0L) && (a.Y == null || a.Y == 0L))
            {
                return true;
            }
            if (a == null || b == null)
            {
                return false;
            }
            return (Equals(a.X, b.X) || (a.X == 0 && b.X == null) || (a.X == null && b.X == 0)) && (Equals(a.Y, b.Y) || (a.Y == 0 && b.Y == null) || (a.Y == null && b.Y == 0));
        }
    }
}