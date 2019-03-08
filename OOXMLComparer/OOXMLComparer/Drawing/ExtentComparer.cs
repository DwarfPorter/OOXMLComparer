using DocumentFormat.OpenXml.Drawing.Wordprocessing;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Drawing
{
    public class ExtentComparer : OpenXmlElementComparer<Extent>
    {
        public ExtentComparer(Extent a, Extent b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareNullElements(b, t => t.Cx.ToInt64() == 0L && t.Cy.ToInt64() == 0L)
                ?? a.Cx.ToInt64() == b.Cx.ToInt64() && a.Cy.ToInt64() == b.Cy.ToInt64();
        }
    }
    
}