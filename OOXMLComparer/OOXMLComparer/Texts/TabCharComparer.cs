using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Texts
{
    public class TabCharComparer : OpenXmlElementComparer<TabChar>
    {
        public TabCharComparer(TabChar a, TabChar b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareNullElements(b) ?? true;
        }
    }
}
