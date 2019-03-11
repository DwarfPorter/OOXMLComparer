using System;
using System.Collections.Generic;
using System.Text;
using DocumentFormat.OpenXml.Wordprocessing;

namespace OOXMLComparer.Paragraphs
{
    public class KeepLinesComparer : OnOffComparer
    {
        public KeepLinesComparer(KeepLines a, KeepLines b) : base(a, b)
        {
        }
    }
}
