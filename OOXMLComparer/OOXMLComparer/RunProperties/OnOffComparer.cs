﻿using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Properties
{
    public abstract class OnOffComparer : OpenXmlElementComparer<OnOffType>
    {
        protected OnOffComparer(OnOffType a, OnOffType b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareNullElements(b, t => t.Val == false) ?? Equals(a.Val, b.Val);
        }
    }
}