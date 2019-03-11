using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Paragraphs
{
    public abstract class BorderTypeComparer : OpenXmlElementComparer<BorderType>
    {
        protected BorderTypeComparer(BorderType a, BorderType b) : base(a, b)
        {
        }
        public override bool Compare()
        {
            return a.CompareNullElements(b) ?? Equals(a.Val, b.Val) && Equals(a.Size.ToUInt32(), b.Size.ToUInt32()) && Equals(a.Space.ToUInt32(), b.Space.ToUInt32()) && Equals(a.Color, b.Color);
        }
    }
}
