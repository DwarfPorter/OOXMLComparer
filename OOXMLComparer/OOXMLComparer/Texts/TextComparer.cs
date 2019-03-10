using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Helpers;
using System;

namespace OOXMLComparer.Texts
{
    public class TextComparer : OpenXmlElementComparer<Text>
    {
        public TextComparer(Text a, Text b) : base(a, b) { }

        public override bool Compare()
        {
            return a.CompareNullElements(b) ?? a.Text == b.Text;
        }
    }
}
