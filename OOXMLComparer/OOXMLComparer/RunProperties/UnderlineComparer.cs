using DocumentFormat.OpenXml.Wordprocessing;

namespace OOXMLComparer.Properties
{
    public class UnderlineComparer : OpenXmlElementComparer<Underline>
    {
        public UnderlineComparer(Underline a, Underline b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            if (a == null && b == null)
            {
                return true;
            }
            if (a == null && b.Val == UnderlineValues.None)
            {
                return true;
            }
            if (b == null && a.Val == UnderlineValues.None)
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
