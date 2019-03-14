using DocumentFormat.OpenXml.Packaging;

namespace OOXMLComparer.Roots
{
    public class FooterPartComparer : OpenXmlPartComparer<FooterPart>
    {
        public FooterPartComparer(FooterPart a, FooterPart b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            var docComparer = new FooterComparer(a.Footer, b.Footer);
            return docComparer.Compare();
        }
    }

}
