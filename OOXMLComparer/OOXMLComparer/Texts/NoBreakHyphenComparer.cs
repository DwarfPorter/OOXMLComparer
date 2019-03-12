using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Common;

namespace OOXMLComparer.Texts
{
    public class NoBreakHyphenComparer : EmptyTypeComparer
    {
        public NoBreakHyphenComparer(NoBreakHyphen a, NoBreakHyphen b) : base(a, b)
        {
        }
    }
}
