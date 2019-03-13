using DocumentFormat.OpenXml.Wordprocessing;
using System;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Tables
{
    public class TableGridComparer : OpenXmlElementComparer<TableGrid>
    {
        public TableGridComparer(TableGrid a, TableGrid b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareNullElements(b)
                ?? a.ChildElements.CompareOrderedChildren(b.ChildElements);
        }
    }
}
