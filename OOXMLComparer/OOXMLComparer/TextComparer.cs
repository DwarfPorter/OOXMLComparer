using DocumentFormat.OpenXml.Wordprocessing;
using System;

namespace OOXMLComparer
{
    public class TextComparer : IOpenXmlElementComparer<Text>
    {
        public bool Compare(Text a, Text b)
        {
            return a.Text == b.Text;
        }
    }
}
