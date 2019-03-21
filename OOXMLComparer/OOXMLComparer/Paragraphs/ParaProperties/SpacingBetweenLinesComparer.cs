using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Paragraphs.ParagraphProperties
{
    public class SpacingBetweenLinesComparer : OpenXmlElementComparer<SpacingBetweenLines>
    {
        public SpacingBetweenLinesComparer(SpacingBetweenLines a, SpacingBetweenLines b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareNullElements(b)
                ?? Equals(a.After, b.After)
                && Equals(a.AfterAutoSpacing, b.AfterAutoSpacing)
                && Equals(a.AfterLines, b.AfterLines)
                && Equals(a.Before, b.Before)
                && Equals(a.BeforeAutoSpacing, b.BeforeAutoSpacing)
                && Equals(a.BeforeLines, b.BeforeLines)
                && Equals(a.Line, b.Line)
                && Equals(a.LineRule, b.LineRule);
        }
    }
}