using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Paragraphs
{
    public class NumberingLevelReferenceComparer : OpenXmlElementComparer<NumberingLevelReference>
    {
        public NumberingLevelReferenceComparer(NumberingLevelReference a, NumberingLevelReference b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareNullElements(b) ?? Equals(a.Val, b.Val);
        }
    }
}