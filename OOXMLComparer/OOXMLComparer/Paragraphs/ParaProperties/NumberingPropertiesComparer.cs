using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Paragraphs.ParaProperties
{
    public class NumberingPropertiesComparer : OpenXmlElementComparer<NumberingProperties>
    {
        public NumberingPropertiesComparer(NumberingProperties a, NumberingProperties b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            var answer = a.CompareNullElements(b);
            if (answer != null)
            {
                return answer.Value;
            }
            var numberingIdComparer = new NumberingIdComparer(a.NumberingId, b.NumberingId);
            var numberingLevelReferenceComparer = new NumberingLevelReferenceComparer(a.NumberingLevelReference, b.NumberingLevelReference);
            return numberingIdComparer.Compare() && numberingLevelReferenceComparer.Compare();
        }
    }
}