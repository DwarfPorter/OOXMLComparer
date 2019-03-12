using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Tables.TableProperties
{
    public abstract class TableWidthTypeComparer : OpenXmlElementComparer<TableWidthType>
    {
        protected TableWidthTypeComparer(TableWidthType a, TableWidthType b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareNullElements(b) ?? Equals(a.Width, b.Width) && Equals(a.Type, b.Type);
        }
    }
}
