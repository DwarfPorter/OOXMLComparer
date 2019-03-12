﻿using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Paragraphs.ParaProperties
{
    public class JustificationComparer : OpenXmlElementComparer<Justification>
    {
        public JustificationComparer(Justification a, Justification b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareNullElements(b, t => (t.Val == null) || (t.Val == JustificationValues.Left)) ?? Equals(a.Val, b.Val);
        }
    }
}