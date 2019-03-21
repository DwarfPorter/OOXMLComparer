using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Helpers;
using System;

namespace OOXMLComparer.Paragraphs.ParagraphProperties
{
    public class TabsComparer : OpenXmlElementComparer<Tabs>
    {
        public TabsComparer(Tabs a, Tabs b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareNullElements(b)
                ?? a.ChildElements.CompareOrderedChildren(b.ChildElements);
        }
    }
}
