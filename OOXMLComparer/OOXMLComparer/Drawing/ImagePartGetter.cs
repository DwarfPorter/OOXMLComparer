using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Helpers;
using System;
using System.Linq;

namespace OOXMLComparer.Drawing
{
    internal class ImagePartGetter
        {
            private OpenXmlPart root;
            private readonly string id;

            public ImagePartGetter(OpenXmlPart root, string id)
            {
                this.root = root;
                this.id = id;
            }

            public static ImagePartGetter Create(Blip a)
            {
                Header header = a.Ancestors<Header>().FirstOrDefault();
                if (header != null)
                {
                    HeaderPart headerPart = header.HeaderPart;
                    return new ImagePartGetter(headerPart, a.Embed);
                }
                Footer footer = a.Ancestors<Footer>().FirstOrDefault();
                if (footer != null)
                {
                    FooterPart footerPart = footer.FooterPart;
                    return new ImagePartGetter(footerPart, a.Embed);
                }
                Document document = a.Ancestors<Document>().FirstOrDefault();
                if (document != null)
                {
                    MainDocumentPart mainDocument = document.MainDocumentPart;
                    return new ImagePartGetter(mainDocument, a.Embed);
                }
                return new ImagePartGetter(null, a.Embed);
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