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
            var childrenA = a.ChildElements.Where(p => p.GetType() != typeof(RunProperties)).ToArray();
            var childrenB = b.ChildElements.Where(p => p.GetType() != typeof(RunProperties)).ToArray();
            if (childrenA.Length != childrenB.Length)
            {
                return false;
            }
            var creatorComparer = new CreatorComparer();
            var cnt = childrenA.Length;
            for (var i = 0; i < cnt; i++)
            {
                if (childrenA[i].GetType() != childrenB[i].GetType())
                {
                    return false;
                }
                IOpenXmlElementComparer comparer = creatorComparer.Create(childrenA[i], childrenB[i]);
                if (!comparer.Compare())
                {
                    return false;
                }
            }
            return true;
        }
    }
}
