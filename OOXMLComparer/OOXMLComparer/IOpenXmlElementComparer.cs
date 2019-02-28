using DocumentFormat.OpenXml;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOXMLComparer
{
    public interface IOpenXmlElementComparer<T> where T: OpenXmlElement
    {
        bool Compare(T a, T b);
    }
}
