using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace OOXMLComparer.Helpers
{
    public static class OpenXmlComparerHelper
    {

        public static bool CompareOrderedChildren(this IEnumerable<OpenXmlElement> childrenAi, IEnumerable<OpenXmlElement> childrenBi)
        {
            var childrenA = childrenAi.Where(t => (t.GetType() != typeof(BookmarkStart)) && (t.GetType() != typeof(BookmarkEnd))).ToArray();
            var childrenB = childrenBi.Where(t => (t.GetType() != typeof(BookmarkStart)) && (t.GetType() != typeof(BookmarkEnd))).ToArray();
            if (childrenA.Length != childrenB.Length)
            {
                return false;
            }
            var cnt = childrenA.Length;
            for (var i = 0; i < cnt; i++)
            {
                if (childrenA[i].GetType() != childrenB[i].GetType())
                {
                    return false;
                }
                IOpenXmlComparer comparer = ComparerFactory.Create(childrenA[i], childrenB[i]);
                if (!comparer.Compare())
                {
                    return false;
                }
            }
            return true;
        }

        public static bool CompareOrderedChildren(this OpenXmlElement a, OpenXmlElement b)
        {
            return a.CompareNullElements(b) ?? CompareOrderedChildren(a.ChildElements, b.ChildElements);
        }

        public static bool CompareChildren(this IEnumerable<OpenXmlElement> childrenA, IEnumerable<OpenXmlElement> childrenB)
        {
            foreach (var childA in childrenA)
            {
                Type type = childA.GetType();
                var childB = childrenB.FirstOrDefault(p => p.GetType() == type);
                var childComparer = ComparerFactory.Create(childA, childB);
                if (!childComparer.Compare())
                {
                    return false;
                }
            }
            return true;
        }

        public static bool CompareChildren2(this IEnumerable<OpenXmlElement> childrenA, IEnumerable<OpenXmlElement> childrenB)
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

        public static bool? CompareNullElements<T>(this T a, T b, Func<T, bool> checkNullorDefault) where T : OpenXmlElement
        {
            if (a == null && b == null)
            {
                return true;
            }
            if (a == null && checkNullorDefault(b))
            {
                return true;
            }
            if (b == null && checkNullorDefault(a))
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

        public static bool ToBool(this BooleanValue a)
        {
            if (a == null)
            {
                return false;
            }
            return BooleanValue.ToBoolean(a);
        }

        public static bool EqualBool(this BooleanValue a, BooleanValue b)
        {
            return Equals(ToBool(a), ToBool(b));
        }

        public static long ToInt64(this Int64Value a)
        {
            if (a == null)
            {
                return 0;
            }
            return Int64Value.ToInt64(a);
        }

        public static uint ToUInt32(this UInt32Value a)
        {
            if (a == null)
            {
                return 0;
            }
            return UInt32Value.ToUInt32(a);
        }
    }
}
