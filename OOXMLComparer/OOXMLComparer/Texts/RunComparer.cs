using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Helpers;
using OOXMLComparer.Properties;
using System;
using System.Linq;

namespace OOXMLComparer.Texts
{
    public class RunComparer : OpenXmlElementComparer<Run>
    {
        public RunComparer(Run a, Run b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            var answer = a.CompareNullElements(b);
            if (answer != null)
            {
                return answer.Value;
            }
            RunPropertiesComparer propComparer = new RunPropertiesComparer(a.RunProperties, b.RunProperties);
            var answer2 = propComparer.Compare();
            if (!answer2)
            {
                return answer2;
            }
            return OpenXmlComparerHelper.CompareOrderedChildren(a.ChildElements.Where(p => p.GetType() != typeof(RunProperties)), b.ChildElements.Where(p => p.GetType() != typeof(RunProperties)));
        }
    }
}
