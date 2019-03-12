using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Properties
{
    public class RunPropertiesComparer : OpenXmlElementComparer<RunProperties>
    {
        public RunPropertiesComparer(RunProperties a, RunProperties b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareChildren2(b);
        }
    }
}
