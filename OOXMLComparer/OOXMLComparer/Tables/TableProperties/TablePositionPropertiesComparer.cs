using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Tables.TableProperties
{
    public class TablePositionPropertiesComparer : OpenXmlElementComparer<TablePositionProperties>
    {
        public TablePositionPropertiesComparer(TablePositionProperties a, TablePositionProperties b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareNullElements(b) 
                ?? Equals(a.BottomFromText, b.BottomFromText)
                && Equals(a.HorizontalAnchor, b.HorizontalAnchor)
                && Equals(a.LeftFromText, b.LeftFromText)
                && Equals(a.RightFromText, b.RightFromText)
                && Equals(a.TopFromText, b.TopFromText)
                && Equals(a.VerticalAnchor, b.VerticalAnchor)
                && Equals(a.TablePositionX, b.TablePositionX)
                && Equals(a.TablePositionY, b.TablePositionY)
                && Equals(a.TablePositionYAlignment, b.TablePositionYAlignment)
                && Equals(a.TablePositionXAlignment, b.TablePositionXAlignment);
        }
    }
}
