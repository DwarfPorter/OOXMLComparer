using DocumentFormat.OpenXml.Wordprocessing;
using System;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Roots
{
    public class BodyComparer : OpenXmlElementComparer<Body>
    {
        public BodyComparer(Body a, Body b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareOrderedChildren(b);
        }
    }
}
