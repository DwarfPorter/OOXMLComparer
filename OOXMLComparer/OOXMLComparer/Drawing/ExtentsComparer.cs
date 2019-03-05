using DocumentFormat.OpenXml.Drawing;

namespace OOXMLComparer.Drawing
{
    public class ExtentsComparer : OpenXmlElementComparer<Extents>
    {
        public ExtentsComparer(Extents a, Extents b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            if (a == null && b == null)
            {
                return true;
            }
            if (a == null && (b.Cx == null || b.Cx == 0L) && (b.Cy == null || b.Cy == 0L))
            {
                return true;
            }
            if (b == null && (a.Cx == null || a.Cx == 0L) && (a.Cy == null || a.Cy == 0L))
            {
                return true;
            }
            if (a == null || b == null)
            {
                return false;
            }
            var aCx = a.Cx ?? 0;
            var aCy = a.Cy ?? 0;
            var bCx = b.Cx ?? 0;
            var bCy = b.Cy ?? 0;
            return Equals(aCx, bCx) && Equals(aCy, bCy);
        }
    }
}