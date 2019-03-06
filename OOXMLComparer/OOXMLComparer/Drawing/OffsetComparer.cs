using DocumentFormat.OpenXml.Drawing;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Drawing
{
    public class OffsetComparer : OpenXmlElementComparer<Offset>
    {
        public OffsetComparer(Offset a, Offset b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            var answer = a.CompareNullElements(b, t => (t.X == null || t.X == 0L) && (t.Y == null || t.Y == 0L));
            if (answer != null)
            {
                return answer.Value;
            }

            var ax = a.X ?? 0;
            var ay = a.Y ?? 0;
            var bx = b.X ?? 0;
            var by = b.Y ?? 0;
            return Equals(ax, bx) && Equals(ay, by);
        }
    }
}