using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Paragraphs.ParaProperties
{
    public class IndentationComparer : OpenXmlElementComparer<Indentation>
    {
        public IndentationComparer(Indentation a, Indentation b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareNullElements(b)
                ?? Equals(a.Start, b.Start)
                && Equals(a.Left, b.Left)
                && Equals(a.Right, b.Right)
                && Equals(a.End, b.End)
                && Equals(a.StartCharacters, b.StartCharacters)
                && Equals(a.EndCharacters, b.EndCharacters)
                && Equals(a.LeftChars, b.LeftChars)
                && Equals(a.RightChars, b.RightChars);
        }
    }
}
