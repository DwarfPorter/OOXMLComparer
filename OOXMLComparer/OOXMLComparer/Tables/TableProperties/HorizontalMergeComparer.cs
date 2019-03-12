using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Tables.TableProperties
{
    public class HorizontalMergeComparer : OpenXmlElementComparer<HorizontalMerge>
    {
        public HorizontalMergeComparer(HorizontalMerge a, HorizontalMerge b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareNullElements(b) ?? Equals(a.Val, b.Val);
        }
    }
}
