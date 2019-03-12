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
            return a.CompareOrderedChildren(b, t => ((Run)t).RunProperties);
        }
    }
}
