using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using System;
using System.IO;
using System.Linq;

namespace Tests
{
    public class Tests
    {
        string currentPath;

        [SetUp]
        public void Setup()
        {
            currentPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestData");
        }

        [Test]
        public void GetImapeMainPartTest()
        {
            var fileDocPath = System.IO.Path.Combine(currentPath, "ImageJpgExpectedResult.docx");

            using (var wordProcessing = WordprocessingDocument.Open(fileDocPath, false))
            {
                var mainPart = wordProcessing.MainDocumentPart;
                var doc = mainPart.Document;

                var blip = doc.Descendants<Blip>().First();
                string id = blip.Embed;

                //We have id of picture; Now we try to get the picture
                var mainDoc = blip.Ancestors<Document>().FirstOrDefault();
                if (mainDoc != null)
                {
                    ImagePart imagePart = (ImagePart) mainDoc.MainDocumentPart.GetPartById(id);
                    byte[] img;
                    using (var stream = imagePart.GetStream())
                    {
                        img = GetArrayFromStream(stream);
                    }
                }
                
            }
        }

        [Test]
        public void GetImapeHeaderPartTest()
        {
            var fileDocPath = System.IO.Path.Combine(currentPath, "ImageHeaderExpectedResult.docx");

            using (var wordProcessing = WordprocessingDocument.Open(fileDocPath, false))
            {
                var hPart = wordProcessing.MainDocumentPart.HeaderParts.First();
                var doc = hPart.Header;

                var blip = doc.Descendants<Blip>().First();
                string id = blip.Embed;

                //We have id of picture; Now we try to get the picture
                var headerDoc = blip.Ancestors<Header>().FirstOrDefault();
                if (headerDoc != null)
                {
                    ImagePart imagePart = (ImagePart) headerDoc.HeaderPart.GetPartById(id);
                    byte[] img;
                    using (var stream = imagePart.GetStream())
                    {
                        img = GetArrayFromStream(stream);
                    }
                }
            }
        }

        [Test]
        public void GetImapeFooterPartTest()
        {
            var fileDocPath = System.IO.Path.Combine(currentPath, "ImageHeaderExpectedResult.docx");

            using (var wordProcessing = WordprocessingDocument.Open(fileDocPath, false))
            {
                var fPart = wordProcessing.MainDocumentPart.FooterParts.First();
                var doc = fPart.Footer;

                var blip = doc.Descendants<Blip>().First();
                string id = blip.Embed;

                //We have id of picture; Now we try to get the picture
                var footerDoc = blip.Ancestors<Footer>().FirstOrDefault();
                if (footerDoc != null)
                {
                    ImagePart imagePart = (ImagePart)footerDoc.FooterPart.GetPartById(id);
                    byte[] img;
                    using (var stream = imagePart.GetStream())
                    {
                        img = GetArrayFromStream(stream);
                    }
                }
            }
        }

        private byte[] GetArrayFromStream(Stream stream)
        {
            using (var mem = new MemoryStream())
            {
                stream.CopyTo(mem);
                return mem.ToArray();
            }
        }
    }
}