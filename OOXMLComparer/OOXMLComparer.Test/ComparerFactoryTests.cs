using DocumentFormat.OpenXml;
using NUnit.Framework;
using System;
using System.Linq;
using System.Reflection;
using DocumentFormat.OpenXml.Wordprocessing;
using Moq;

namespace OOXMLComparer.Test
{
    [Category("OOXML")]
    public class ComparerFactoryTests
    {
        [Test]
        public void ComparerFactoryTest()
        {
            Assembly comparerAssembly = Assembly.GetAssembly(typeof(IOpenXmlComparer));
            foreach (Type classType in comparerAssembly.GetTypes().Where(t => t.GetInterfaces().Contains(typeof(IOpenXmlComparer)) && !t.IsAbstract))
            {
                var constructor = classType.GetConstructors().First();
                var parameter = constructor.GetParameters().First();
                Type typeParameter = parameter.ParameterType;
                if (typeParameter.IsSubclassOf(typeof(OpenXmlElement)))
                {
                    var typeConstructor = typeParameter.GetConstructor(Type.EmptyTypes);
                    var openXmlParameter = (OpenXmlElement)typeConstructor.Invoke(new object[] { });
                    var comparer = ComparerFactory.Create(openXmlParameter, null);
                    Assert.AreEqual(classType, comparer.GetType(), "No processing type in comparer factory.");
                }
            }
        }

        [Test]
        public void ComparerFactoryCreateDefaultComparerTest()
        {
            var mockOpemXmlElement = new Mock<OpenXmlElement>();
            var comparer = ComparerFactory.Create(mockOpemXmlElement.Object, null);
            Assert.AreEqual(typeof(OpenXmlElementComparer), comparer.GetType());
        }
    }
}
