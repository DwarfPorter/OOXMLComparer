using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Tables.TableProperties;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOXMLComparer.Test.Tables.TableProperties
{
    public class TableLookComparerTests
    {
        [Test]
        public void TableLookComparerTest()
        {
            var a = new TableLook();
            var b = new TableLook();
            Assert.IsTrue(new TableLookComparer(a, b).Compare());
        }

        [Test]
        public void TableLookComparerHappyTest()
        {
            var a = new TableLook() {FirstColumn = true, FirstRow = true, LastColumn = true, LastRow = true, NoHorizontalBand = true, NoVerticalBand = true, Val = "0" };
            var b = new TableLook() { FirstColumn = true, FirstRow = true, LastColumn = true, LastRow = true, NoHorizontalBand = true, NoVerticalBand = true, Val = "0" };
            Assert.IsTrue(new TableLookComparer(a, b).Compare());
        }

        [Test]
        public void TableLookComparerFirstColumnWrongTest()
        {
            var a = new TableLook() { FirstColumn = true };
            var b = new TableLook();
            Assert.IsFalse(new TableLookComparer(a, b).Compare());
        }

        [Test]
        public void TableLookComparerFirstRowWrongTest()
        {
            var a = new TableLook() { FirstRow = true };
            var b = new TableLook();
            Assert.IsFalse(new TableLookComparer(a, b).Compare());
        }

        [Test]
        public void TableLookComparerLastColumnWrongTest()
        {
            var a = new TableLook() { LastColumn = true };
            var b = new TableLook();
            Assert.IsFalse(new TableLookComparer(a, b).Compare());
        }

        [Test]
        public void TableLookComparerLastRowWrongTest()
        {
            var a = new TableLook() { LastRow = true };
            var b = new TableLook();
            Assert.IsFalse(new TableLookComparer(a, b).Compare());
        }

        [Test]
        public void TableLookComparerNoHorizontalBandWrongTest()
        {
            var a = new TableLook() { NoHorizontalBand = true };
            var b = new TableLook();
            Assert.IsFalse(new TableLookComparer(a, b).Compare());
        }

        [Test]
        public void TableLookComparerNoVerticalBandWrongTest()
        {
            var a = new TableLook() { NoVerticalBand = true };
            var b = new TableLook();
            Assert.IsFalse(new TableLookComparer(a, b).Compare());
        }

        [Test]
        public void TableLookComparerValWrongTest()
        {
            var a = new TableLook() { Val = "0" };
            var b = new TableLook();
            Assert.IsFalse(new TableLookComparer(a, b).Compare());
        }
    }
}
