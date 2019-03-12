using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Paragraphs.ParaProperties
{
    public class TextBoxTightWrapComparer : OpenXmlElementComparer<TextBoxTightWrap>
    {
        public TextBoxTightWrapComparer(TextBoxTightWrap a, TextBoxTightWrap b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareNullElements(b) ?? Equals(a.Val, b.Val);
        }
    }
}
