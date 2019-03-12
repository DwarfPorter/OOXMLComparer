using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Common;

namespace OOXMLComparer.Tables.TableProperties
{
    public class CantSplitComparer : OnOffOnlyTypeComparer
    {
        public CantSplitComparer(CantSplit a, CantSplit b) : base(a,b)
        {
        }
    }
}
