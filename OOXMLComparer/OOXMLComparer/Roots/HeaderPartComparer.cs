using DocumentFormat.OpenXml.Packaging;

namespace OOXMLComparer.Roots
{
    public class HeaderPartComparer : OpenXmlPartComparer<HeaderPart>
    {
        public HeaderPartComparer(HeaderPart a, HeaderPart b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            var docComparer = new HeaderComparer(a.Header, b.Header);
            return docComparer.Compare();
        }
    }

}
