using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Common;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Tables.TableProperties
{
    public class NoWrapComparer : OnOffOnlyTypeComparer
    {
        public NoWrapComparer(NoWrap a, NoWrap b) : base(a, b)
        {
        }
    }
}
