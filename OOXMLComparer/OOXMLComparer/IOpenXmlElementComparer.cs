using DocumentFormat.OpenXml;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOXMLComparer
{
    public interface IOpenXmlComparer
    {
        bool Compare();
    }
}
