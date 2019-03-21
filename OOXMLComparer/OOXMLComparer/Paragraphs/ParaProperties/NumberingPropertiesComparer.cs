using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Paragraphs.ParagraphProperties
{
    public class NumberingPropertiesComparer : OpenXmlElementComparer<NumberingProperties>
    {
        public NumberingPropertiesComparer(NumberingProperties a, NumberingProperties b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareChildren2(b);
        }
    }
}