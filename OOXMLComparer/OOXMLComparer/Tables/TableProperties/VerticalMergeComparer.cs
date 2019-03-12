using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Tables.TableProperties
{
    public class VerticalMergeComparer : OpenXmlElementComparer<VerticalMerge>
    {
        public VerticalMergeComparer(VerticalMerge a, VerticalMerge b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareNullElements(b) ?? Equals(a.Val, b.Val);
        }
    }
}
