using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Helpers;
using System;

namespace OOXMLComparer.Tables.TableProperties
{
    public class TableCaptionComparer : OpenXmlElementComparer<TableCaption>
    {
        public TableCaptionComparer(TableCaption a, TableCaption b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareNullElements(b) ?? Equals(a.Val, b.Val);
        }
    }
}
