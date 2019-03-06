using DocumentFormat.OpenXml.Drawing;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Drawing
{
    public class ExtentsComparer : OpenXmlElementComparer<Extents>
    {
        public ExtentsComparer(Extents a, Extents b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            var answer = a.CompareNullElements(b, t => (t.Cx == null || t.Cx == 0L) && (t.Cy == null || t.Cy == 0L));
            if (answer != null)
            {
                return answer.Value;
            }

            var aCx = a.Cx ?? 0;
            var aCy = a.Cy ?? 0;
            var bCx = b.Cx ?? 0;
            var bCy = b.Cy ?? 0;
            return Equals(aCx, bCx) && Equals(aCy, bCy);
        }
    }
}