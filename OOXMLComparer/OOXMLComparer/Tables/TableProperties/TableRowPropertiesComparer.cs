using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Helpers;
using System;

namespace OOXMLComparer.Tables.TableProperties
{
    public class TableRowPropertiesComparer : OpenXmlElementComparer<TableRowProperties>
    {
        public TableRowPropertiesComparer(TableRowProperties a, TableRowProperties b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareChildren2(b);
        }
    }
}
