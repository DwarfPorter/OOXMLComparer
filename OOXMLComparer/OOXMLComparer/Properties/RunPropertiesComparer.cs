using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Linq;

namespace OOXMLComparer.Properties
{
    public class RunPropertiesComparer : OpenXmlElementComparer<RunProperties>
    {
        public RunPropertiesComparer(RunProperties a, RunProperties b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            if (a == null && b == null)
            {
                return true;
            }
            if (a == null && !b.ChildElements.Any())
            {
                return true;
            }
            if (!a.ChildElements.Any() && b == null)
            {
                return true;
            }
            if (a == null || b == null)
            {
                return true;
            }
            var childrenA = a.ChildElements;
            var childrenB = b.ChildElements;
            return CompareChildren(childrenA, childrenB) && CompareChildren(childrenB, childrenA);
        }

        private bool CompareChildren(OpenXmlElementList childrenA, OpenXmlElementList childrenB)
        {
            var creatorComparer = new CreatorComparer();
            foreach (var childA in childrenA)
            {
                Type type = childA.GetType();
                var childB = childrenB.FirstOrDefault(p => p.GetType() == type);
                var childComparer = creatorComparer.Create(childA, childB);
                if (!childComparer.Compare())
                {
                    return false;
                }
            }
            return true;
        }
    }
}
