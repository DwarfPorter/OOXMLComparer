using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Helpers;
using System;
using System.Collections;
using System.Linq;

namespace OOXMLComparer.Drawing
{
    public class BlipComparer : OpenXmlElementComparer<Blip>
    {
        public BlipComparer(Blip a, Blip b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            var answer = a.CompareNullElements(b);
            if (answer != null)
            {
                return answer.Value;
            }

            var partA = PartStrategy.Create(a);
            var partB = PartStrategy.Create(b);

            if (partA.GetTypeOfRoot() != partB.GetTypeOfRoot())
            {
                return false;
            }
            return PartStrategy.BytesComparer(partA.GetImage(), partB.GetImage());
        }

        private class PartStrategy
        {
            private OpenXmlPart root;
            private readonly string id;

            public PartStrategy(OpenXmlPart root, string id)
            {
                this.root = root;
                this.id = id;
            }

            public static PartStrategy Create(Blip a)
            {
                Header header = a.Ancestors<Header>().FirstOrDefault();
                if (header != null)
                {
                    HeaderPart headerPart = header.HeaderPart;
                    return new PartStrategy(headerPart, a.Embed);
                }
                Footer footer = a.Ancestors<Footer>().FirstOrDefault();
                if (footer != null)
                {
                    FooterPart footerPart = footer.FooterPart;
                    return new PartStrategy(footerPart, a.Embed);
                }
                Document document = a.Ancestors<Document>().FirstOrDefault();
                if (document != null)
                {
                    MainDocumentPart mainDocument = document.MainDocumentPart;
                    return new PartStrategy(mainDocument, a.Embed);
                }
                return new PartStrategy(null, a.Embed);
            }

            public Type GetTypeOfRoot()
            {
                if (root == null)
                {
                    return typeof(object);
                }
                return root.GetType();
            }

            public byte[] GetImage()
            {
                if (root == null)
                {
                    return new byte[] { };
                }
                ImagePart imagePart = (ImagePart)root.GetPartById(id);
                byte[] img;
                using (var stream = imagePart.GetStream())
                {
                    img = stream.GetArrayFromStream();
                }
                return img;
            }

            public static bool BytesComparer(ReadOnlySpan<byte> a1, ReadOnlySpan<byte> a2)
            {
                return a1.SequenceEqual(a2);
            }
        }
    }
}