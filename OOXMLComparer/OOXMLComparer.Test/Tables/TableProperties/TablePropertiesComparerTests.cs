﻿using NUnit.Framework;
using OOXMLComparer.Tables.TableProperties;

namespace OOXMLComparer.Test.Tables.TableProperties
{
    public class TablePropertiesComparerTests
    {
        [Test]
        public void TablePropertiesComparerTest()
        {
            var a = new DocumentFormat.OpenXml.Wordprocessing.TableProperties();
            var b = new DocumentFormat.OpenXml.Wordprocessing.TableProperties();
            Assert.IsTrue(new TablePropertiesComparer(a, b).Compare());
        }
    }
}
