﻿using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Tables.TableProperties;

namespace OOXMLComparer.Test.Tables.TableProperties
{
    public class VerticalMergeComparerTests
    {
        [Test]
        public void HorizontalMergeComparerTest()
        {
            var a = new VerticalMerge();
            var b = new VerticalMerge();
            Assert.IsTrue(new VerticalMergeComparer(a, b).Compare());
        }

        [Test]
        public void VerticalMergeComparerWrongTest()
        {
            var a = new VerticalMerge() { Val = MergedCellValues.Continue };
            var b = new VerticalMerge() { Val = MergedCellValues.Restart };
            Assert.IsFalse(new VerticalMergeComparer(a, b).Compare());
        }
    }
}
