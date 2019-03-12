using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOXMLComparer.Tables.TableProperties
{
    public class TableJustificationComparer : OpenXmlElementComparer<TableJustification>
    {
        public TableJustificationComparer(TableJustification a, TableJustification b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareNullElements(b) ?? Equals(a.Val, b.Val);
        }
    }
}
