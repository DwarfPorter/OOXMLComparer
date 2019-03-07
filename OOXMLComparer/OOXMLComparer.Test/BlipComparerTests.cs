using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using NUnit.Framework;
using OOXMLComparer.Drawing;
using System.IO;
using System.Linq;
using Run = DocumentFormat.OpenXml.Wordprocessing.Run;

namespace OOXMLComparer.Test
{
    public class BlipComparerTests
    {

        WordprocessingDocument word1;
        WordprocessingDocument word2;
        WordprocessingDocument word3;

        MainDocumentPart doc1;
        MainDocumentPart doc2;
        MainDocumentPart doc3;


        byte[] data1Png = new byte[]
        {
            0x89, 0x50, 0x4E, 0x47, 0x0D, 0x0A, 0x1A, 0x0A, 0x00, 0x00, 0x00, 0x0D, 0x49, 0x48, 0x44, 0x52, 0x00, 0x00, 0x00, 0x07, 0x00, 0x00, 0x00, 0x05, 0x08,
            0x02, 0x00, 0x00, 0x00, 0x06, 0xF8, 0x61, 0x8F, 0x00, 0x00, 0x00, 0x01, 0x73, 0x52, 0x47, 0x42, 0x00, 0xAE, 0xCE, 0x1C, 0xE9, 0x00, 0x00, 0x00, 0x04,
            0x67, 0x41, 0x4D, 0x41, 0x00, 0x00, 0xB1, 0x8F, 0x0B, 0xFC, 0x61, 0x05, 0x00, 0x00, 0x00, 0x09, 0x70, 0x48, 0x59, 0x73, 0x00, 0x00, 0x0E, 0xC3, 0x00,
            0x00, 0x0E, 0xC3, 0x01, 0xC7, 0x6F, 0xA8, 0x64, 0x00, 0x00, 0x00, 0x18, 0x74, 0x45, 0x58, 0x74, 0x53, 0x6F, 0x66, 0x74, 0x77, 0x61, 0x72, 0x65, 0x00,
            0x70, 0x61, 0x69, 0x6E, 0x74, 0x2E, 0x6E, 0x65, 0x74, 0x20, 0x34, 0x2E, 0x31, 0x2E, 0x34, 0x13, 0x40, 0x68, 0xC4, 0x00, 0x00, 0x00, 0x1F, 0x49, 0x44,
            0x41, 0x54, 0x18, 0x57, 0x63, 0xF8, 0x8F, 0x0D, 0x80, 0x44, 0x19, 0x60, 0x00, 0x22, 0x04, 0x04, 0x50, 0x16, 0xB2, 0x10, 0x10, 0xE0, 0x15, 0x45, 0x01,
            0xFF, 0xFF, 0x03, 0x00, 0x93, 0xD7, 0x59, 0xA7, 0x13, 0xEC, 0x30, 0xE5, 0x00, 0x00, 0x00, 0x00, 0x49, 0x45, 0x4E, 0x44, 0xAE, 0x42, 0x60, 0x82
        };

        byte[] data2Png = new byte[]
        {
            0x89, 0x50, 0x4E, 0x47, 0x0D, 0x0A, 0x1A, 0x0A, 0x00, 0x00, 0x00, 0x0D, 0x49, 0x48, 0x44, 0x52, 0x00, 0x00, 0x00, 0x05, 0x00, 0x00, 0x00, 0x04, 0x08,
            0x02, 0x00, 0x00, 0x00, 0xC9, 0x51, 0x62, 0x17, 0x00, 0x00, 0x00, 0x01, 0x73, 0x52, 0x47, 0x42, 0x00, 0xAE, 0xCE, 0x1C, 0xE9, 0x00, 0x00, 0x00, 0x04,
            0x67, 0x41, 0x4D, 0x41, 0x00, 0x00, 0xB1, 0x8F, 0x0B, 0xFC, 0x61, 0x05, 0x00, 0x00, 0x00, 0x09, 0x70, 0x48, 0x59, 0x73, 0x00, 0x00, 0x0E, 0xC3, 0x00,
            0x00, 0x0E, 0xC3, 0x01, 0xC7, 0x6F, 0xA8, 0x64, 0x00, 0x00, 0x00, 0x18, 0x74, 0x45, 0x58, 0x74, 0x53, 0x6F, 0x66, 0x74, 0x77, 0x61, 0x72, 0x65, 0x00,
            0x70, 0x61, 0x69, 0x6E, 0x74, 0x2E, 0x6E, 0x65, 0x74, 0x20, 0x34, 0x2E, 0x31, 0x2E, 0x34, 0x13, 0x40, 0x68, 0xC4, 0x00, 0x00, 0x00, 0x41, 0x49, 0x44,
            0x41, 0x54, 0x18, 0x57, 0x2D, 0xCA, 0xB1, 0x09, 0x00, 0x41, 0x08, 0x05, 0xD1, 0xEB, 0x77, 0x0B, 0xB1, 0x23, 0x8B, 0x30, 0x10, 0x6C, 0xC0, 0xC4, 0x0A,
            0x8C, 0xE4, 0x23, 0xE8, 0xDD, 0xC2, 0x85, 0x8F, 0x99, 0x67, 0x77, 0x67, 0xA6, 0xAA, 0x22, 0xA2, 0xBB, 0xAF, 0x01, 0x88, 0x08, 0x11, 0xB9, 0xFB, 0xF5,
            0x17, 0x99, 0xF9, 0x9C, 0xA3, 0xAA, 0xFF, 0x9F, 0x99, 0x66, 0x06, 0xE0, 0x05, 0xB8, 0x48, 0x34, 0xC3, 0x4C, 0xB2, 0xF9, 0x9B, 0x00, 0x00, 0x00, 0x00,
            0x49, 0x45, 0x4E, 0x44, 0xAE, 0x42, 0x60, 0x82
        };

        byte[] data1Bmp = new byte[]
        {
            0x42, 0x4D, 0x76, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x36, 0x00, 0x00, 0x00, 0x28, 0x00, 0x00, 0x00, 0x05, 0x00, 0x00, 0x00, 0x04, 0x00, 0x00,
            0x00, 0x01, 0x00, 0x18, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xC4, 0x0E, 0x00, 0x00, 0xC4, 0x0E, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0xFF, 0xFF, 0xFF, 0xFE, 0xFE, 0xFE, 0xF1, 0xF1, 0xF1, 0xD1, 0xD1, 0xD1, 0xF9, 0xF9, 0xF9, 0xFF, 0xFF, 0xFF, 0xFF, 0xF7, 0xF7,
            0xF7, 0xB6, 0xB6, 0xB6, 0x6B, 0x6B, 0x6B, 0xCE, 0xCE, 0xCE, 0xFF, 0xFF, 0xFF, 0xFF, 0xF9, 0xF9, 0xF9, 0xCA, 0xCA, 0xCA, 0x87, 0x87, 0x87, 0xDE, 0xDE,
            0xDE, 0xFF, 0xFF, 0xFF, 0xFF, 0xFE, 0xFE, 0xFE, 0xF7, 0xF7, 0xF7, 0xE3, 0xE3, 0xE3, 0xFB, 0xFB, 0xFB, 0xFF
        };

        [SetUp]
        public void CreateWordDocs()
        {
            word1 = CreateWordDocument("doc1", ImagePartType.Png, data1Png, ImagePartType.Png, data2Png, ImagePartType.Bmp, data1Bmp);
            word2 = CreateWordDocument("doc2", ImagePartType.Png, data1Png, ImagePartType.Png, data2Png, ImagePartType.Bmp, data1Bmp);
            word3 = CreateWordDocument("doc3", ImagePartType.Bmp, data1Bmp, ImagePartType.Png, data1Png, ImagePartType.Png, data2Png);
            doc1 = word1.MainDocumentPart;
            doc2 = word2.MainDocumentPart;
            doc3 = word3.MainDocumentPart;
        }

        [TearDown]
        public void DisposeWordDocs()
        {
            word1.Dispose();
            word2.Dispose();
            word3.Dispose();
        }

        [Test]
        public void BlipComparerTest()
        {
            var a = new Blip();
            var b = new Blip();
            Assert.IsTrue(new BlipComparer(a, b).Compare());
        }

        [Test]
        public void BlipComparerComplexTest()
        {
            var a = doc1.Document.Descendants<Blip>().First();
            var b = doc2.Document.Descendants<Blip>().First();
            Assert.IsTrue(new BlipComparer(a, b).Compare());
        }

        [Test]
        public void BlipComparerHeaderComplexTest()
        {
            var a = doc1.HeaderParts.First().Header.Descendants<Blip>().First();
            var b = doc2.HeaderParts.First().Header.Descendants<Blip>().First();
            Assert.IsTrue(new BlipComparer(a, b).Compare());
        }

        [Test]
        public void BlipComparerFooterComplexTest()
        {
            var a = doc1.FooterParts.First().Footer.Descendants<Blip>().First();
            var b = doc2.FooterParts.First().Footer.Descendants<Blip>().First();
            Assert.IsTrue(new BlipComparer(a, b).Compare());
            Assert.IsFalse(true);
        }

        [Test]
        public void BlipComparerComplexWrongTest()
        {
            var a = doc1.Document.Descendants<Blip>().First();
            var b = doc3.Document.Descendants<Blip>().First();
            Assert.IsFalse(new BlipComparer(a, b).Compare());
        }

        [Test]
        public void BlipComparerHeaderComplexWrongTest()
        {
            var a = doc1.HeaderParts.First().Header.Descendants<Blip>().First();
            var b = doc3.HeaderParts.First().Header.Descendants<Blip>().First();
            Assert.IsFalse(new BlipComparer(a, b).Compare());
        }

        [Test]
        public void BlipComparerFooterComplexWrongTest()
        {
            var a = doc1.FooterParts.First().Footer.Descendants<Blip>().First();
            var b = doc3.FooterParts.First().Footer.Descendants<Blip>().First();
            Assert.IsFalse(new BlipComparer(a, b).Compare());
        }

        [Test]
        public void BlipComparerDiffComplexWrongTest()
        {
            var a = doc1.HeaderParts.First().Header.Descendants<Blip>().First();
            var b = doc3.FooterParts.First().Footer.Descendants<Blip>().First();
            Assert.IsFalse(new BlipComparer(a, b).Compare());
        }

        private WordprocessingDocument CreateWordDocument(string name, ImagePartType imageTypeBody, byte[] dataBody, ImagePartType imageTypeHeader, byte[] dataHeader, ImagePartType imageTypeFooter, byte[] dataFooter)
        {
            var wordProcessing = WordprocessingDocument.Create(name, DocumentFormat.OpenXml.WordprocessingDocumentType.Document);
            var doc = wordProcessing.AddMainDocumentPart();

            ImagePart ipart = doc.AddImagePart(imageTypeBody);
            using (Stream memStream = new MemoryStream(dataBody))
            {
                ipart.FeedData(memStream);
            }
            var imagePartId = doc.GetIdOfPart(ipart);

            doc.Document = new Document(
                new Body(
                    new DocumentFormat.OpenXml.Wordprocessing.Paragraph(
                        new Run(
                            new DocumentFormat.OpenXml.Wordprocessing.Drawing(
                                new DocumentFormat.OpenXml.Drawing.Wordprocessing.Inline(
                                    new DocumentFormat.OpenXml.Drawing.Graphic(
                                        new DocumentFormat.OpenXml.Drawing.GraphicData(
                                            new DocumentFormat.OpenXml.Drawing.Pictures.Picture(
                                                new DocumentFormat.OpenXml.Drawing.Pictures.BlipFill(
                                    new DocumentFormat.OpenXml.Drawing.Blip() { Embed = imagePartId })
                                )))
                                    )
                            )))));

            HeaderPart headerPart = doc.AddNewPart<HeaderPart>();
            string headerPartId = doc.GetIdOfPart(headerPart);

            ImagePart iHeaderpart = headerPart.AddImagePart(imageTypeHeader);
            using (Stream memStream = new MemoryStream(dataHeader))
            {
                iHeaderpart.FeedData(memStream);
            }
            var imagePartHeaderId = headerPart.GetIdOfPart(iHeaderpart);

            var header = new Header(new DocumentFormat.OpenXml.Wordprocessing.Paragraph(
                new Run(
                    new DocumentFormat.OpenXml.Wordprocessing.Drawing(
                        new DocumentFormat.OpenXml.Drawing.Wordprocessing.Inline(
                            new DocumentFormat.OpenXml.Drawing.Graphic(
                                new DocumentFormat.OpenXml.Drawing.GraphicData(
                                    new DocumentFormat.OpenXml.Drawing.Pictures.Picture(
                                        new DocumentFormat.OpenXml.Drawing.Pictures.BlipFill(
                            new DocumentFormat.OpenXml.Drawing.Blip() { Embed = imagePartHeaderId })
                        )))
                            )
                    ))));

            headerPart.Header = header;

            FooterPart footerPart = doc.AddNewPart<FooterPart>();
            string footerPartId = doc.GetIdOfPart(footerPart);

            ImagePart iFooterpart = footerPart.AddImagePart(imageTypeFooter);
            using (Stream memStream = new MemoryStream(dataFooter))
            {
                iFooterpart.FeedData(memStream);
            }
            var imagePartFooterId = footerPart.GetIdOfPart(iFooterpart);

            var footer = new Footer(new DocumentFormat.OpenXml.Wordprocessing.Paragraph(
                new Run(
                    new DocumentFormat.OpenXml.Wordprocessing.Drawing(
                        new DocumentFormat.OpenXml.Drawing.Wordprocessing.Inline(
                            new DocumentFormat.OpenXml.Drawing.Graphic(
                                new DocumentFormat.OpenXml.Drawing.GraphicData(
                                    new DocumentFormat.OpenXml.Drawing.Pictures.Picture(
                                        new DocumentFormat.OpenXml.Drawing.Pictures.BlipFill(
                            new DocumentFormat.OpenXml.Drawing.Blip() { Embed = imagePartFooterId })
                        )))
                            )
                    ))));

            footerPart.Footer = footer;

            return wordProcessing;

        }
    }
}