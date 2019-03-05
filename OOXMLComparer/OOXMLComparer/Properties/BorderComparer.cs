using DocumentFormat.OpenXml.Wordprocessing;

namespace OOXMLComparer.Properties
{
    public class BorderComparer : OpenXmlElementComparer<Border>
    {
        public BorderComparer(Border a, Border b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            if (a == null && b == null)
            {
                return true;
            }
            if (a == null && (b.Val == BorderValues.None || b.Val == BorderValues.Nil))
            {
                return true;
            }
            if (b == null && (a.Val == BorderValues.None || a.Val == BorderValues.Nil))
            {
                return true;
            }
            if (a == null || b == null)
            {
                return false;
            }
            return Equals(a.Val, b.Val);
        }
    }
}
