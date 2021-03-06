﻿using DocumentFormat.OpenXml;
using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Reflection;

namespace OOXMLComparer
{
    public class CreatorComparer
    {
        private static ConcurrentDictionary<Type, ConstructorInfo> cacheTypes = new ConcurrentDictionary<Type, ConstructorInfo>();

        public IOpenXmlComparer Create(OpenXmlElement a, OpenXmlElement b)
        {
            if (a == null && b == null)
            {
                return new OpenXmlElementComparer(a, b);
            }
            Type type = GetType(a, b);
            ConstructorInfo comparerConstructor = null;
            if (!cacheTypes.TryGetValue(type, out comparerConstructor))
            {
                foreach(Type classType in System.Reflection.Assembly.GetExecutingAssembly().GetTypes().Where(t => t.GetInterfaces().Contains(typeof(IOpenXmlComparer))))
                {
                    var constructor = classType.GetConstructors().Where(c => c.GetParameters().Count(p => p.ParameterType == type) == 2).FirstOrDefault();
                    if (constructor != null)
                    {
                        comparerConstructor = constructor;
                        cacheTypes.TryAdd(type, constructor);
                        break;
                    }
                }
                if (comparerConstructor == null)
                {
                    comparerConstructor = typeof(OpenXmlElementComparer).GetConstructors().First();
                }
            }

            var answer = comparerConstructor.Invoke(new object[] { a, b });
            IOpenXmlComparer result = answer as IOpenXmlComparer;
            return result;
        }

        private static Type GetType(OpenXmlElement a, OpenXmlElement b)
        {
            return a != null ? a.GetType() : b.GetType();
        }
    }
}
