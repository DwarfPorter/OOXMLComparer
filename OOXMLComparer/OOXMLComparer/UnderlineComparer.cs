using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOXMLComparer
{
    public class UnderlineComparer : IOpenXmlElementComparer<Underline>
    {
        public bool Compare(Underline a, Underline b)
        {
            return a.Val.Equals(b.Val);
        }
    }
}
