using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOXMLComparer.Tables.TableProperties
{
    public class TableCellPropertiesComparer : OpenXmlElementComparer<TableCellProperties>
    {
        public TableCellPropertiesComparer(TableCellProperties a, TableCellProperties b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareChildren2(b);
        }
    }
}
