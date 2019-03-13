using OOXMLComparer.Helpers;

namespace OOXMLComparer.Tables.TableProperties
{
    public class TablePropertiesComparer : OpenXmlElementComparer<DocumentFormat.OpenXml.Wordprocessing.TableProperties>
    {
        public TablePropertiesComparer(DocumentFormat.OpenXml.Wordprocessing.TableProperties a, DocumentFormat.OpenXml.Wordprocessing.TableProperties b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareChildren2(b);
        }
    }
}
