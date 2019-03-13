using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Tables
{
    public class TableComparer : OpenXmlElementComparer<Table>
    {
        public TableComparer(Table a, Table b) : base(a, b) { }

        public override bool Compare()
        {
            return a.CompareNullElements(b)
                ?? a.ChildElements.CompareOrderedChildren(b.ChildElements);
        }
    }
}
