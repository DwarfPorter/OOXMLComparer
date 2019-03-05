using DocumentFormat.OpenXml.Wordprocessing;
using System;

namespace OOXMLComparer
{
    public class TextComparer : OpenXmlElementComparer<Text>
    {
        public TextComparer(Text a, Text b) : base(a, b) { }

        public override bool Compare()
        {
            if (a == null && b == null)
            {
                return true;
            }
            if (a == null || b == null)
            {
                return false;
            }
            return a.Text == b.Text;
        }
    }
}
