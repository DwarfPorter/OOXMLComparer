using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Properties
{
    public class BorderComparer : OpenXmlElementComparer<Border>
    {
        public BorderComparer(Border a, Border b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareNullElements(b, t => (t.Val == BorderValues.None || t.Val == BorderValues.Nil)) ?? Equals(a.Val, b.Val);
        }
    }
}
