using DocumentFormat.OpenXml.Wordprocessing;

namespace OOXMLComparer
{
    public class ItalicComparer : OnOffComparer, IOpenXmlElementComparer<Italic>
    {
        public bool Compare(Italic a, Italic b)
        {
            return base.Compare((OnOffType)a, (OnOffType)b);
        }
    }
}
