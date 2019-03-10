using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Properties
{
    public class UnderlineComparer : OpenXmlElementComparer<Underline>
    {
        public UnderlineComparer(Underline a, Underline b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareNullElements(b, t => t.Val == UnderlineValues.None) ?? Equals(a.Val ?? UnderlineValues.None, b.Val ?? UnderlineValues.None);
        }
    }
}
