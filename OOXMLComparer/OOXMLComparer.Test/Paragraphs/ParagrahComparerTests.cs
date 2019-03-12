using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Paragraphs;

namespace OOXMLComparer.Test.Paragraphs
{
    public class ParagrahComparerTests
    {
        [Test]
        public void ParagraphComparerTest()
        {
            var a = new Paragraph();
            var b = new Paragraph();
            Assert.IsTrue(new ParagraphComparer(a, b).Compare());
        }

        [Test]
        public void ParagraphComparerContentWrongTest()
        {
            var a = new Paragraph(new ParagraphProperties { Indentation = new Indentation { Left = "40" } }, new Run(new Text("aaa")));
            var b = new Paragraph(new ParagraphProperties { Indentation = new Indentation { Left = "40" } }, new Run(new Text("bbb")));
            Assert.IsFalse(new ParagraphComparer(a, b).Compare());
        }

        [Test]
        public void ParagraphComparerContent2WrongTest()
        {
            var a = new Paragraph(new ParagraphProperties { Indentation = new Indentation { Left = "40" } }, new Run(new Text("bbb")), new Run(new Text("aaa")));
            var b = new Paragraph(new ParagraphProperties { Indentation = new Indentation { Left = "40" } }, new Run(new Text("bbb")));
            Assert.IsFalse(new ParagraphComparer(a, b).Compare());
        }

        [Test]
        public void ParagraphComparerPropertiesWrongTest()
        {
            var a = new Paragraph(new ParagraphProperties { Indentation = new Indentation { Left = "42" } }, new Run(new Text("bbb")));
            var b = new Paragraph(new ParagraphProperties { Indentation = new Indentation { Left = "40" } }, new Run(new Text("bbb")));
            Assert.IsFalse(new ParagraphComparer(a, b).Compare());
        }
    }
}
