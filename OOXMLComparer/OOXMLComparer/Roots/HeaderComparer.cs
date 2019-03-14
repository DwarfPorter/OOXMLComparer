using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Roots
{
    public class HeaderComparer : OpenXmlElementComparer<Header>
    {
        public HeaderComparer(Header a, Header b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareOrderedChildren(b);
        }
    }
}
