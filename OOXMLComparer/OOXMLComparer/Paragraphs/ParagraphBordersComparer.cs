using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOXMLComparer.Paragraphs
{
    public class ParagraphBordersComparer : OpenXmlElementComparer<ParagraphBorders>
    {
        public ParagraphBordersComparer(ParagraphBorders a, ParagraphBorders b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareChildren2(b);
        }
    }
}
