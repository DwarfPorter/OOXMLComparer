using DocumentFormat.OpenXml.Drawing;

namespace OOXMLComparer.Drawing
{
    public class PresetGeometryComparer : OpenXmlElementComparer<PresetGeometry>
    {
        public PresetGeometryComparer(PresetGeometry a, PresetGeometry b) : base(a, b)
        {
        }
        public override bool Compare()
        {
            if (a == null && b == null)
            {
                return true;
            }
            if (a == null && b.Preset == null && b.AdjustValueList == null)
            {
                return true;
            }
            if (b == null && a.Preset == null && a.AdjustValueList == null)
            {
                return true;
            }
            if (a == null || b == null)
            {
                return false;
            }
            return Equals(a.Preset, b.Preset) && ((a.AdjustValueList == null && b.AdjustValueList == null)||(a.AdjustValueList != null && b.AdjustValueList != null));
        }
    }
}
/*
 *  return new Drawing(
                new DocumentFormat.OpenXml.Drawing.Wordprocessing.Inline(
                    new DocumentFormat.OpenXml.Drawing.Wordprocessing.Extent() { Cx = widthInEmus, Cy = heightInEmus },
                    new DocumentFormat.OpenXml.Drawing.Wordprocessing.EffectExtent() { LeftEdge = 19050L, TopEdge = 0L, RightEdge = 0L, BottomEdge = 0L },
                    new DocumentFormat.OpenXml.Drawing.Wordprocessing.DocProperties() { Id = drawingObjId, Name = imageName },
                    new DocumentFormat.OpenXml.Drawing.Wordprocessing.NonVisualGraphicFrameDrawingProperties
                    {
                        GraphicFrameLocks = new DocumentFormat.OpenXml.Drawing.GraphicFrameLocks() { NoChangeAspect = true }
                    },
                    new DocumentFormat.OpenXml.Drawing.Graphic(
                        new DocumentFormat.OpenXml.Drawing.GraphicData(
                            new DocumentFormat.OpenXml.Drawing.Pictures.Picture(
                                new DocumentFormat.OpenXml.Drawing.Pictures.NonVisualPictureProperties(
                                    new DocumentFormat.OpenXml.Drawing.Pictures.NonVisualDrawingProperties() { Id = imageObjId, Name = imageName, Description = string.Empty },
                                    new DocumentFormat.OpenXml.Drawing.Pictures.NonVisualPictureDrawingProperties(
                                        new DocumentFormat.OpenXml.Drawing.PictureLocks() { NoChangeAspect = true, NoChangeArrowheads = true })
                                    )
                               ,
                                new DocumentFormat.OpenXml.Drawing.Pictures.BlipFill(
                                    new DocumentFormat.OpenXml.Drawing.Blip() { Embed = imagePartId },
                                    new DocumentFormat.OpenXml.Drawing.SourceRectangle(),
                                    new DocumentFormat.OpenXml.Drawing.Stretch(
                                        new DocumentFormat.OpenXml.Drawing.FillRectangle())),
                                new DocumentFormat.OpenXml.Drawing.Pictures.ShapeProperties(
                                    new DocumentFormat.OpenXml.Drawing.Transform2D(
                                        new DocumentFormat.OpenXml.Drawing.Offset() { X = 0L, Y = 0L },
                                        new DocumentFormat.OpenXml.Drawing.Extents() { Cx = widthInEmus, Cy = heightInEmus }),
                                    new DocumentFormat.OpenXml.Drawing.PresetGeometry(
                                        new DocumentFormat.OpenXml.Drawing.AdjustValueList()
                                    )
                                    { Preset = DocumentFormat.OpenXml.Drawing.ShapeTypeValues.Rectangle }
                                )
                                { BlackWhiteMode = DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues.Auto })
                        )
                        { Uri = "http://schemas.openxmlformats.org/drawingml/2006/picture" })
                )
                { DistanceFromTop = (UInt32Value)0U, DistanceFromBottom = (UInt32Value)0U, DistanceFromLeft = (UInt32Value)0U, DistanceFromRight = (UInt32Value)0U }
            );

    */