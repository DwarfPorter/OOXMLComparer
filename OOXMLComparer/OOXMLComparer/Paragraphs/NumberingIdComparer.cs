using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Paragraphs
{
    public class NumberingIdComparer : OpenXmlElementComparer<NumberingId>
    {
        public NumberingIdComparer(NumberingId a, NumberingId b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareNullElements(b) ?? Equals(a.Val, b.Val);
        }
    }
}