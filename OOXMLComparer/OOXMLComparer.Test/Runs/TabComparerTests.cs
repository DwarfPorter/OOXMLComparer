﻿using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Texts;

namespace OOXMLComparer.Test.Runs
{
    [Category("OOXML")]
    public class TabCharComparerTests
    {
        [Test]
        public void TabCharComparerTest()
        {
            var a = new TabChar();
            var b = new TabChar();
            Assert.IsTrue(new TabCharComparer(a, b).Compare());
        }

        [Test]
        public void TabCharComparerNullTest()
        {
            var a = new TabChar();
            Assert.IsFalse(new TabCharComparer(a, null).Compare());
        }
    }
}