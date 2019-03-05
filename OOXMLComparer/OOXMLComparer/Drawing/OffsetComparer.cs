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
            var ax = a.X ?? 0;
            var ay = a.Y ?? 0;
            var bx = b.X ?? 0;
            var by = b.Y ?? 0;
            return Equals(ax, bx) && Equals(ay, by);
        }
    }
}