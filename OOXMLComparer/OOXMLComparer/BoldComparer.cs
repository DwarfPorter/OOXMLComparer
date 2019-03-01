﻿using DocumentFormat.OpenXml.Wordprocessing;

namespace OOXMLComparer
{
    public class BoldComparer : OnOffComparer, IOpenXmlElementComparer<Bold>
    {
        public bool Compare(Bold a, Bold b)
        {
            return base.Compare((OnOffType)a, (OnOffType)b);
        }
    }
}
