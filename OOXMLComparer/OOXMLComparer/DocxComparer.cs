using DocumentFormat.OpenXml.Packaging;
using OOXMLComparer.Roots;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace OOXMLComparer
{
    public class DocxComparer : IDocxComparer
    {
        public bool Compare(Stream a, Stream b)
        {
            using (WordprocessingDocument aDoc = WordprocessingDocument.Open(a, false))
            {
                using (WordprocessingDocument bDoc = WordprocessingDocument.Open(b, false))
                {
                    var wordComparer = new MainDocumentPartComparer(aDoc.MainDocumentPart, bDoc.MainDocumentPart);
                    return wordComparer.Compare();
                }
            }
        }
    }
}
