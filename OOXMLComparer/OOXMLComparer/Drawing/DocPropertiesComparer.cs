using DocumentFormat.OpenXml.Drawing.Wordprocessing;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Drawing
{
    public class DocPropertiesComparer : OpenXmlElementComparer<DocProperties>
    {
        public DocPropertiesComparer(DocProperties a, DocProperties b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareNullElements(b, t => !t.Hidden.ToBool()) ?? a.Hidden.EqualBool(b.Hidden);
        }
    }
}