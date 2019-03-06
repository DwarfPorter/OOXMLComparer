using DocumentFormat.OpenXml;
using System;
using System.IO;
using System.Linq;

namespace OOXMLComparer.Helpers
{
    public static class OpenXmlComparerHelper
    {
        public static bool CompareChildren(this OpenXmlElementList childrenA, OpenXmlElementList childrenB)
        {
            var creatorComparer = new CreatorComparer();
            foreach (var childA in childrenA)
            {
                Type type = childA.GetType();
                var childB = childrenB.FirstOrDefault(p => p.GetType() == type);
                var childComparer = creatorComparer.Create(childA, childB);
                if (!childComparer.Compare())
                {
                    return false;
                }
            }
            return true;
        }

        public static bool CompareChildren2(this OpenXmlElementList childrenA, OpenXmlElementList childrenB)
        {
            return CompareChildren(childrenA, childrenB) && CompareChildren(childrenB, childrenA);
        }

        public static bool CompareChildren2(this OpenXmlElement a, OpenXmlElement b)
        {

            if (a == null && b == null)
            {
                return true;
            }
            if (a == null && !b.ChildElements.Any())
            {
                return true;
            }
            if (!a.ChildElements.Any() && b == null)
            {
                return true;
            }
            if (a == null || b == null)
            {
                return false;
            }
            var childrenA = a.ChildElements;
            var childrenB = b.ChildElements;
            return CompareChildren2(childrenA, childrenB);
        }

        public static bool? CompareNullElements(this OpenXmlElement a, OpenXmlElement b)
        {
            if (a == null && b == null)
            {
                return true;
            }
            if (a == null || b == null)
            {
                return false;
            }
            return null;
        }

        public static bool? CompareNullElements<T>(this T a, T b, Func<T, bool> checkNull) where T : OpenXmlElement
        {
            if (a == null && b == null)
            {
                return true;
            }
            if (a == null && checkNull(b))
            {
                return true;
            }
            if (b == null && checkNull(a))
            {
                return true;
            }
            if (a == null || b == null)
            {
                return false;
            }
            return null;
        }

        public static byte[] GetArrayFromStream(this Stream stream)
        {
            using (var mem = new MemoryStream())
            {
                stream.CopyTo(mem);
                return mem.ToArray();
            }
        }
    }
}
