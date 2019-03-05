using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Drawing;
using OOXMLComparer.Properties;

namespace OOXMLComparer
{
    public class CreatorComparer
    {
        public IOpenXmlElementComparer Create(OpenXmlElement a, OpenXmlElement b)
        {
            if (CheckType<DocumentFormat.OpenXml.Wordprocessing.Text>(a, b))
            {
                return new TextComparer((DocumentFormat.OpenXml.Wordprocessing.Text) a, (DocumentFormat.OpenXml.Wordprocessing.Text)b);
            }
            if (CheckType<DocumentFormat.OpenXml.Wordprocessing.Underline>(a, b))
            {
                return new UnderlineComparer((DocumentFormat.OpenXml.Wordprocessing.Underline)a, (DocumentFormat.OpenXml.Wordprocessing.Underline)b);
            }
            if(CheckType<DocumentFormat.OpenXml.Wordprocessing.RunProperties>(a, b))
            {
                return new RunPropertiesComparer((DocumentFormat.OpenXml.Wordprocessing.RunProperties)a, (DocumentFormat.OpenXml.Wordprocessing.RunProperties)b);
            }
            if(CheckType<RunFonts>(a, b))
            {
                return new RunFontsComparer((RunFonts)a, (RunFonts)b);
            }
            if(CheckType<Italic>(a, b))
            {
                return new ItalicComparer((Italic)a, (Italic)b);
            }
            if (CheckType<FontSize>(a, b))
            {
                return new FontSizeComparer((FontSize)a, (FontSize)b);
            }
            if (CheckType<Border>(a, b))
            {
                return new BorderComparer((Border)a, (Border)b);
            }
            if (CheckType<Bold>(a, b))
            {
                return new BoldComparer((Bold)a, (Bold)b);
            }
            if (CheckType<Extents>(a, b))
            {
                return new ExtentsComparer((Extents)a, (Extents)b);
            }
            if (CheckType<Offset>(a, b))
            {
                return new OffsetComparer((Offset)a, (Offset)b);
            }
            if (CheckType<PresetGeometry>(a, b))
            {
                return new PresetGeometryComparer((PresetGeometry)a, (PresetGeometry)b);
            }
            if (CheckType<Transform2D>(a, b))
            {
                return new Transform2DComparer((Transform2D)a, (Transform2D)b);
            }

            return new OpenXmlElementComparer(a, b);
        }

        private static bool CheckType<T>(OpenXmlElement a, OpenXmlElement b) where T :OpenXmlElement 
        {
            return (a?.GetType() == typeof(T)) || (b?.GetType() == typeof(T));
        }
    }
}
