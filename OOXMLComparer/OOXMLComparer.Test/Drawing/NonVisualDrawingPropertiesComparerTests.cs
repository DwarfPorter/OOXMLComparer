﻿using DocumentFormat.OpenXml.Drawing.Pictures;
using NUnit.Framework;
using OOXMLComparer.Drawing;

namespace OOXMLComparer.Test
{
    [Category("OOXML")]
    public class NonVisualDrawingPropertiesComparerTests
    {
        [Test]
        public void NonVisualDrawingPropertiesComparerTest()
        {
            var a = new NonVisualDrawingProperties();
            var b = new NonVisualDrawingProperties();
            Assert.IsTrue(new NonVisualDrawingPropertiesComparer(a, b).Compare());
            a.Hidden = true;
            b.Hidden = true;
            Assert.IsTrue(new NonVisualDrawingPropertiesComparer(a, b).Compare());
        }

        [Test]
        public void NonVisualDrawingPropertiesComparerNullTest()
        {
            var a = new NonVisualDrawingProperties();
            Assert.IsTrue(new NonVisualDrawingPropertiesComparer(a, null).Compare());
        }

        [Test]
        public void NonVisualDrawingPropertiesComparerWrongTest()
        {
            var a = new NonVisualDrawingProperties() { Hidden = true };
            var b = new NonVisualDrawingProperties();
            Assert.IsFalse(new NonVisualDrawingPropertiesComparer(a, b).Compare());
        }
    }
}
