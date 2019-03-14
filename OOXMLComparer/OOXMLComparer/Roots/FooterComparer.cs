using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Roots
{
    public class FooterComparer : OpenXmlElementComparer<Footer>
    {
        public FooterComparer(Footer a, Footer b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareNullElements(b) ?? a.CompareOrderedChildren(b);
        }
    }
}
