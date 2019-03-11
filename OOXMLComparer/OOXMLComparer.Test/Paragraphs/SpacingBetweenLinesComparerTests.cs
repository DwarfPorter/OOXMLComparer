using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Paragraphs;

namespace OOXMLComparer.Test.Paragraphs
{
    public class SpacingBetweenLinesComparerTests
    {
        [Test]
        public void SpacingBetweenLinesComparerTest()
        {
            var a = new SpacingBetweenLines();
            var b = new SpacingBetweenLines();
            Assert.IsTrue(new SpacingBetweenLinesComparer(a, b).Compare());
        }

        [Test]
        public void SpacingBetweenLinesComparerHappyTest()
        {
            var a = new SpacingBetweenLines() { After = "4", AfterAutoSpacing = true, AfterLines = 32, Before = "42", BeforeAutoSpacing = true, BeforeLines = 33, Line = "4", LineRule = LineSpacingRuleValues.AtLeast };
            var b = new SpacingBetweenLines() { After = "4", AfterAutoSpacing = true, AfterLines = 32, Before = "42", BeforeAutoSpacing = true, BeforeLines = 33, Line = "4", LineRule = LineSpacingRuleValues.AtLeast };
            Assert.IsTrue(new SpacingBetweenLinesComparer(a, b).Compare());
        }

        [Test]
        public void SpacingBetweenLinesComparerWrongTest()
        {
            var a = new SpacingBetweenLines() { After = "4", AfterAutoSpacing = true, AfterLines = 32, Before = "42", BeforeAutoSpacing = true, BeforeLines = 33, Line = "4", LineRule = LineSpacingRuleValues.AtLeast };
            var b = new SpacingBetweenLines() { After = "4", AfterAutoSpacing = true, AfterLines = 32, Before = "42", BeforeAutoSpacing = true, BeforeLines = 33, Line = "4", LineRule = LineSpacingRuleValues.Auto };
            Assert.IsFalse(new SpacingBetweenLinesComparer(a, b).Compare());
        }
    }
}