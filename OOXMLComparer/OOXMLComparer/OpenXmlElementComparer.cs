using DocumentFormat.OpenXml;

namespace OOXMLComparer
{
    public class OpenXmlElementComparer : OpenXmlElementComparer<OpenXmlElement>
    {
        public OpenXmlElementComparer(OpenXmlElement a, OpenXmlElement b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return true;
        }
    }
}
