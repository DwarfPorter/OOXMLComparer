﻿using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Reflection;
using OOXMLComparer.Common;
using OOXMLComparer.Drawing;
using DocumentFormat.OpenXml.Drawing;
using OOXMLComparer.Paragraphs.ParagraphProperties;
using OOXMLComparer.Paragraphs.SectionProperties;
using OOXMLComparer.Paragraphs;
using OOXMLComparer.Roots;
using OOXMLComparer.Properties;
using OOXMLComparer.Tables.TableProperties;
using OOXMLComparer.Tables;
using OOXMLComparer.Texts;

namespace OOXMLComparer
{
    public class ComparerFactory
    {
        public static IOpenXmlComparer Create(OpenXmlElement a, OpenXmlElement b)
        {
            Type type = a.GetType();
            if (type == typeof(BarBorder)) return new BarBorderComparer((BarBorder)a, (BarBorder)b);
            if (type == typeof(BetweenBorder)) return new BetweenBorderComparer((BetweenBorder)a, (BetweenBorder)b);
            if (type == typeof(DocumentFormat.OpenXml.Wordprocessing.BottomBorder)) return new BottomBorderComparer((DocumentFormat.OpenXml.Wordprocessing.BottomBorder)a, (DocumentFormat.OpenXml.Wordprocessing.BottomBorder)b);
            if (type == typeof(EndBorder)) return new EndBorderComparer((EndBorder)a, (EndBorder)b);
            if (type == typeof(DocumentFormat.OpenXml.Wordprocessing.InsideHorizontalBorder)) return new InsideHorizontalBorderComparer((DocumentFormat.OpenXml.Wordprocessing.InsideHorizontalBorder)a, (DocumentFormat.OpenXml.Wordprocessing.InsideHorizontalBorder)b);
            if (type == typeof(DocumentFormat.OpenXml.Wordprocessing.InsideVerticalBorder)) return new InsideVerticalBorderComparer((DocumentFormat.OpenXml.Wordprocessing.InsideVerticalBorder)a, (DocumentFormat.OpenXml.Wordprocessing.InsideVerticalBorder)b);
            if (type == typeof(DocumentFormat.OpenXml.Wordprocessing.LeftBorder)) return new LeftBorderComparer((DocumentFormat.OpenXml.Wordprocessing.LeftBorder)a, (DocumentFormat.OpenXml.Wordprocessing.LeftBorder)b);
            if (type == typeof(DocumentFormat.OpenXml.Wordprocessing.RightBorder)) return new RightBorderComparer((DocumentFormat.OpenXml.Wordprocessing.RightBorder)a, (DocumentFormat.OpenXml.Wordprocessing.RightBorder)b);
            if (type == typeof(Shading)) return new ShadingComparer((Shading)a, (Shading)b);
            if (type == typeof(StartBorder)) return new StartBorderComparer((StartBorder)a, (StartBorder)b);
            if (type == typeof(DocumentFormat.OpenXml.Wordprocessing.TopBorder)) return new TopBorderComparer((DocumentFormat.OpenXml.Wordprocessing.TopBorder)a, (DocumentFormat.OpenXml.Wordprocessing.TopBorder)b);
            if (type == typeof(Blip)) return new BlipComparer((Blip)a, (Blip)b);
            if (type == typeof(DocumentFormat.OpenXml.Drawing.BlipFill)) return new BlipFillComparer((DocumentFormat.OpenXml.Drawing.BlipFill)a, (DocumentFormat.OpenXml.Drawing.BlipFill)b);
            if (type == typeof(DocumentFormat.OpenXml.Drawing.Wordprocessing.DocProperties)) return new DocPropertiesComparer((DocumentFormat.OpenXml.Drawing.Wordprocessing.DocProperties)a, (DocumentFormat.OpenXml.Drawing.Wordprocessing.DocProperties)b);
            if (type == typeof(DocumentFormat.OpenXml.Wordprocessing.Drawing)) return new DrawingComparer((DocumentFormat.OpenXml.Wordprocessing.Drawing)a, (DocumentFormat.OpenXml.Wordprocessing.Drawing)b);
            if (type == typeof(DocumentFormat.OpenXml.Drawing.Wordprocessing.EffectExtent)) return new EffectExtentComparer((DocumentFormat.OpenXml.Drawing.Wordprocessing.EffectExtent)a, (DocumentFormat.OpenXml.Drawing.Wordprocessing.EffectExtent)b);
            if (type == typeof(DocumentFormat.OpenXml.Drawing.Wordprocessing.Extent)) return new ExtentComparer((DocumentFormat.OpenXml.Drawing.Wordprocessing.Extent)a, (DocumentFormat.OpenXml.Drawing.Wordprocessing.Extent)b);
            if (type == typeof(Extents)) return new ExtentsComparer((Extents)a, (Extents)b);
            if (type == typeof(Graphic)) return new GraphicComparer((Graphic)a, (Graphic)b);
            if (type == typeof(GraphicData)) return new GraphicDataComparer((GraphicData)a, (GraphicData)b);
            if (type == typeof(GraphicFrameLocks)) return new GraphicFrameLocksComparer((GraphicFrameLocks)a, (GraphicFrameLocks)b);
            if (type == typeof(DocumentFormat.OpenXml.Drawing.Wordprocessing.Inline)) return new InlineComparer((DocumentFormat.OpenXml.Drawing.Wordprocessing.Inline)a, (DocumentFormat.OpenXml.Drawing.Wordprocessing.Inline)b);
            if (type == typeof(DocumentFormat.OpenXml.Drawing.Pictures.NonVisualDrawingProperties)) return new NonVisualDrawingPropertiesComparer((DocumentFormat.OpenXml.Drawing.Pictures.NonVisualDrawingProperties)a, (DocumentFormat.OpenXml.Drawing.Pictures.NonVisualDrawingProperties)b);
            if (type == typeof(DocumentFormat.OpenXml.Drawing.Wordprocessing.NonVisualGraphicFrameDrawingProperties)) return new NonVisualGraphicFrameDrawingPropertiesComparer((DocumentFormat.OpenXml.Drawing.Wordprocessing.NonVisualGraphicFrameDrawingProperties)a, (DocumentFormat.OpenXml.Drawing.Wordprocessing.NonVisualGraphicFrameDrawingProperties)b);
            if (type == typeof(DocumentFormat.OpenXml.Drawing.Pictures.NonVisualPictureDrawingProperties)) return new NonVisualPictureDrawingPropertiesComparer((DocumentFormat.OpenXml.Drawing.Pictures.NonVisualPictureDrawingProperties)a, (DocumentFormat.OpenXml.Drawing.Pictures.NonVisualPictureDrawingProperties)b);
            if (type == typeof(DocumentFormat.OpenXml.Drawing.Pictures.NonVisualPictureProperties)) return new NonVisualPicturePropertiesComparer((DocumentFormat.OpenXml.Drawing.Pictures.NonVisualPictureProperties)a, (DocumentFormat.OpenXml.Drawing.Pictures.NonVisualPictureProperties)b);
            if (type == typeof(Offset)) return new OffsetComparer((Offset)a, (Offset)b);
            if (type == typeof(DocumentFormat.OpenXml.Drawing.Pictures.Picture)) return new PictureComparer((DocumentFormat.OpenXml.Drawing.Pictures.Picture)a, (DocumentFormat.OpenXml.Drawing.Pictures.Picture)b);
            if (type == typeof(PictureLocks)) return new PictureLocksComparer((PictureLocks)a, (PictureLocks)b);
            if (type == typeof(PresetGeometry)) return new PresetGeometryComparer((PresetGeometry)a, (PresetGeometry)b);
            if (type == typeof(DocumentFormat.OpenXml.Drawing.Pictures.ShapeProperties)) return new ShapePropertiesComparer((DocumentFormat.OpenXml.Drawing.Pictures.ShapeProperties)a, (DocumentFormat.OpenXml.Drawing.Pictures.ShapeProperties)b);
            if (type == typeof(Stretch)) return new StretchComparer((Stretch)a, (Stretch)b);
            if (type == typeof(Transform2D)) return new Transform2DComparer((Transform2D)a, (Transform2D)b);
            if (type == typeof(ContextualSpacing)) return new ContextualSpacingComparer((ContextualSpacing)a, (ContextualSpacing)b);
            if (type == typeof(FrameProperties)) return new FramePropertiesComparer((FrameProperties)a, (FrameProperties)b);
            if (type == typeof(Indentation)) return new IndentationComparer((Indentation)a, (Indentation)b);
            if (type == typeof(Justification)) return new JustificationComparer((Justification)a, (Justification)b);
            if (type == typeof(KeepLines)) return new KeepLinesComparer((KeepLines)a, (KeepLines)b);
            if (type == typeof(KeepNext)) return new KeepNextComparer((KeepNext)a, (KeepNext)b);
            if (type == typeof(NumberingId)) return new NumberingIdComparer((NumberingId)a, (NumberingId)b);
            if (type == typeof(NumberingLevelReference)) return new NumberingLevelReferenceComparer((NumberingLevelReference)a, (NumberingLevelReference)b);
            if (type == typeof(NumberingProperties)) return new NumberingPropertiesComparer((NumberingProperties)a, (NumberingProperties)b);
            if (type == typeof(ParagraphBorders)) return new ParagraphBordersComparer((ParagraphBorders)a, (ParagraphBorders)b);
            if (type == typeof(ParagraphMarkRunProperties)) return new ParagraphMarkRunPropertiesComparer((ParagraphMarkRunProperties)a, (ParagraphMarkRunProperties)b);
            if (type == typeof(DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties)) return new ParagraphPropertiesComparer((DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties)a, (DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties)b);
            if (type == typeof(ParagraphStyleId)) return new ParagraphStyleIdComparer((ParagraphStyleId)a, (ParagraphStyleId)b);
            if (type == typeof(SpacingBetweenLines)) return new SpacingBetweenLinesComparer((SpacingBetweenLines)a, (SpacingBetweenLines)b);
            if (type == typeof(Tabs)) return new TabsComparer((Tabs)a, (Tabs)b);
            if (type == typeof(DocumentFormat.OpenXml.Wordprocessing.TabStop)) return new TabStopComparer((DocumentFormat.OpenXml.Wordprocessing.TabStop)a, (DocumentFormat.OpenXml.Wordprocessing.TabStop)b);
            if (type == typeof(TextAlignment)) return new TextAlignmentComparer((TextAlignment)a, (TextAlignment)b);
            if (type == typeof(TextBoxTightWrap)) return new TextBoxTightWrapComparer((TextBoxTightWrap)a, (TextBoxTightWrap)b);
            if (type == typeof(TextDirection)) return new TextDirectionComparer((TextDirection)a, (TextDirection)b);
            if (type == typeof(Column)) return new ColumnComparer((Column)a, (Column)b);
            if (type == typeof(Columns)) return new ColumnsComparer((Columns)a, (Columns)b);
            if (type == typeof(PageBorders)) return new PageBordersComparer((PageBorders)a, (PageBorders)b);
            if (type == typeof(PageMargin)) return new PageMarginComparer((PageMargin)a, (PageMargin)b);
            if (type == typeof(DocumentFormat.OpenXml.Wordprocessing.SectionProperties)) return new SectionPropertiesComparer((DocumentFormat.OpenXml.Wordprocessing.SectionProperties)a, (DocumentFormat.OpenXml.Wordprocessing.SectionProperties)b);
            if (type == typeof(DocumentFormat.OpenXml.Wordprocessing.Paragraph)) return new ParagraphComparer((DocumentFormat.OpenXml.Wordprocessing.Paragraph)a, (DocumentFormat.OpenXml.Wordprocessing.Paragraph)b);
            if (type == typeof(Body)) return new BodyComparer((Body)a, (Body)b);
            if (type == typeof(Document)) return new DocumentComparer((Document)a, (Document)b);
            if (type == typeof(Footer)) return new FooterComparer((Footer)a, (Footer)b);
            if (type == typeof(Header)) return new HeaderComparer((Header)a, (Header)b);
            if (type == typeof(Bold)) return new BoldComparer((Bold)a, (Bold)b);
            if (type == typeof(Border)) return new BorderComparer((Border)a, (Border)b);
            if (type == typeof(FontSize)) return new FontSizeComparer((FontSize)a, (FontSize)b);
            if (type == typeof(Italic)) return new ItalicComparer((Italic)a, (Italic)b);
            if (type == typeof(RunFonts)) return new RunFontsComparer((RunFonts)a, (RunFonts)b);
            if (type == typeof(DocumentFormat.OpenXml.Wordprocessing.RunProperties)) return new RunPropertiesComparer((DocumentFormat.OpenXml.Wordprocessing.RunProperties)a, (DocumentFormat.OpenXml.Wordprocessing.RunProperties)b);
            if (type == typeof(DocumentFormat.OpenXml.Wordprocessing.Underline)) return new UnderlineComparer((DocumentFormat.OpenXml.Wordprocessing.Underline)a, (DocumentFormat.OpenXml.Wordprocessing.Underline)b);
            if (type == typeof(BottomMargin)) return new BottomMarginComparer((BottomMargin)a, (BottomMargin)b);
            if (type == typeof(CantSplit)) return new CantSplitComparer((CantSplit)a, (CantSplit)b);
            if (type == typeof(EndMargin)) return new EndMarginComparer((EndMargin)a, (EndMargin)b);
            if (type == typeof(GridSpan)) return new GridSpanComparer((GridSpan)a, (GridSpan)b);
            if (type == typeof(HorizontalMerge)) return new HorizontalMergeComparer((HorizontalMerge)a, (HorizontalMerge)b);
            if (type == typeof(LeftMargin)) return new LeftMarginComparer((LeftMargin)a, (LeftMargin)b);
            if (type == typeof(NoWrap)) return new NoWrapComparer((NoWrap)a, (NoWrap)b);
            if (type == typeof(RightMargin)) return new RightMarginComparer((RightMargin)a, (RightMargin)b);
            if (type == typeof(StartMargin)) return new StartMarginComparer((StartMargin)a, (StartMargin)b);
            if (type == typeof(TableBorders)) return new TableBordersComparer((TableBorders)a, (TableBorders)b);
            if (type == typeof(TableCaption)) return new TableCaptionComparer((TableCaption)a, (TableCaption)b);
            if (type == typeof(DocumentFormat.OpenXml.Wordprocessing.TableCellBorders)) return new TableCellBordersComparer((DocumentFormat.OpenXml.Wordprocessing.TableCellBorders)a, (DocumentFormat.OpenXml.Wordprocessing.TableCellBorders)b);
            if (type == typeof(TableCellFitText)) return new TableCellFitTextComparer((TableCellFitText)a, (TableCellFitText)b);
            if (type == typeof(TableCellMargin)) return new TableCellMarginComparer((TableCellMargin)a, (TableCellMargin)b);
            if (type == typeof(DocumentFormat.OpenXml.Wordprocessing.TableCellProperties)) return new TableCellPropertiesComparer((DocumentFormat.OpenXml.Wordprocessing.TableCellProperties)a, (DocumentFormat.OpenXml.Wordprocessing.TableCellProperties)b);
            if (type == typeof(TableCellSpacing)) return new TableCellSpacingComparer((TableCellSpacing)a, (TableCellSpacing)b);
            if (type == typeof(TableCellVerticalAlignment)) return new TableCellVerticalAlignmentComparer((TableCellVerticalAlignment)a, (TableCellVerticalAlignment)b);
            if (type == typeof(TableCellWidth)) return new TableCellWidthComparer((TableCellWidth)a, (TableCellWidth)b);
            if (type == typeof(TableHeader)) return new TableHeaderComparer((TableHeader)a, (TableHeader)b);
            if (type == typeof(TableIndentation)) return new TableIndentationComparer((TableIndentation)a, (TableIndentation)b);
            if (type == typeof(TableJustification)) return new TableJustificationComparer((TableJustification)a, (TableJustification)b);
            if (type == typeof(TableLayout)) return new TableLayoutComparer((TableLayout)a, (TableLayout)b);
            if (type == typeof(TableLook)) return new TableLookComparer((TableLook)a, (TableLook)b);
            if (type == typeof(TablePositionProperties)) return new TablePositionPropertiesComparer((TablePositionProperties)a, (TablePositionProperties)b);
            if (type == typeof(DocumentFormat.OpenXml.Wordprocessing.TableProperties)) return new TablePropertiesComparer((DocumentFormat.OpenXml.Wordprocessing.TableProperties)a, (DocumentFormat.OpenXml.Wordprocessing.TableProperties)b);
            if (type == typeof(TableRowHeight)) return new TableRowHeightComparer((TableRowHeight)a, (TableRowHeight)b);
            if (type == typeof(TableRowProperties)) return new TableRowPropertiesComparer((TableRowProperties)a, (TableRowProperties)b);
            if (type == typeof(DocumentFormat.OpenXml.Wordprocessing.TableStyle)) return new TableStyleComparer((DocumentFormat.OpenXml.Wordprocessing.TableStyle)a, (DocumentFormat.OpenXml.Wordprocessing.TableStyle)b);
            if (type == typeof(TableWidth)) return new TableWidthComparer((TableWidth)a, (TableWidth)b);
            if (type == typeof(TopMargin)) return new TopMarginComparer((TopMargin)a, (TopMargin)b);
            if (type == typeof(VerticalMerge)) return new VerticalMergeComparer((VerticalMerge)a, (VerticalMerge)b);
            if (type == typeof(DocumentFormat.OpenXml.Wordprocessing.GridColumn)) return new GridColumnComparer((DocumentFormat.OpenXml.Wordprocessing.GridColumn)a, (DocumentFormat.OpenXml.Wordprocessing.GridColumn)b);
            if (type == typeof(DocumentFormat.OpenXml.Wordprocessing.TableCell)) return new TableCellComparer((DocumentFormat.OpenXml.Wordprocessing.TableCell)a, (DocumentFormat.OpenXml.Wordprocessing.TableCell)b);
            if (type == typeof(DocumentFormat.OpenXml.Wordprocessing.Table)) return new TableComparer((DocumentFormat.OpenXml.Wordprocessing.Table)a, (DocumentFormat.OpenXml.Wordprocessing.Table)b);
            if (type == typeof(DocumentFormat.OpenXml.Wordprocessing.TableGrid)) return new TableGridComparer((DocumentFormat.OpenXml.Wordprocessing.TableGrid)a, (DocumentFormat.OpenXml.Wordprocessing.TableGrid)b);
            if (type == typeof(DocumentFormat.OpenXml.Wordprocessing.TableRow)) return new TableRowComparer((DocumentFormat.OpenXml.Wordprocessing.TableRow)a, (DocumentFormat.OpenXml.Wordprocessing.TableRow)b);
            if (type == typeof(DocumentFormat.OpenXml.Wordprocessing.Break)) return new BreakComparer((DocumentFormat.OpenXml.Wordprocessing.Break)a, (DocumentFormat.OpenXml.Wordprocessing.Break)b);
            if (type == typeof(CarriageReturn)) return new CarriageReturnComparer((CarriageReturn)a, (CarriageReturn)b);
            if (type == typeof(NoBreakHyphen)) return new NoBreakHyphenComparer((NoBreakHyphen)a, (NoBreakHyphen)b);
            if (type == typeof(DocumentFormat.OpenXml.Wordprocessing.Run)) return new RunComparer((DocumentFormat.OpenXml.Wordprocessing.Run)a, (DocumentFormat.OpenXml.Wordprocessing.Run)b);
            if (type == typeof(SoftHyphen)) return new SoftHyphenComparer((SoftHyphen)a, (SoftHyphen)b);
            if (type == typeof(SymbolChar)) return new SymbolCharComparer((SymbolChar)a, (SymbolChar)b);
            if (type == typeof(TabChar)) return new TabCharComparer((TabChar)a, (TabChar)b);
            if (type == typeof(DocumentFormat.OpenXml.Wordprocessing.Text)) return new TextComparer((DocumentFormat.OpenXml.Wordprocessing.Text)a, (DocumentFormat.OpenXml.Wordprocessing.Text)b);
            if (type == typeof(HeaderReference)) return new HeaderReferenceComparer((HeaderReference)a, (HeaderReference)b);
            if (type == typeof(FooterReference)) return new FooterReferenceComparer((FooterReference)a, (FooterReference)b);

            return new OpenXmlElementComparer(a, b);
        }
    }
}
