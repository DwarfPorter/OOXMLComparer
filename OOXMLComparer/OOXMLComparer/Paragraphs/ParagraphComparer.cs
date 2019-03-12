using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Helpers;
using OOXMLComparer.Paragraphs.ParaProperties;
using System.Linq;

namespace OOXMLComparer.Paragraphs
{
    public class ParagraphComparer : OpenXmlElementComparer<Paragraph>
    {
        public ParagraphComparer(Paragraph a, Paragraph b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            var answer = a.CompareNullElements(b);
            if (answer != null)
            {
                return answer.Value;
            }
            var propComparer = new ParagraphPropertiesComparer(a.ParagraphProperties, b.ParagraphProperties);
            var answer2 = propComparer.Compare();
            if (!answer2)
            {
                return answer2;
            }
            return OpenXmlComparerHelper.CompareOrderedChildren(a.ChildElements.Where(p => p.GetType() != typeof(ParagraphProperties)), b.ChildElements.Where(p => p.GetType() != typeof(ParagraphProperties)));
        }
    }
}
