using DocumentFormat.OpenXml.Wordprocessing;

namespace OOXMLComparer.Properties
{
    public class BoldComparer : OnOffComparer, IOpenXmlElementComparer<Bold>
    {
        public bool Compare(Bold a, Bold b)
        {
            return base.Compare((OnOffType)a, (OnOffType)b);
        }
    }
}
