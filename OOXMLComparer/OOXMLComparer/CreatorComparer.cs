using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Properties;
using System;

namespace OOXMLComparer
{
    public class CreatorComparer
    {
        public IOpenXmlElementComparer Create(OpenXmlElement a, OpenXmlElement b)
        {
            if (CheckType<Text>(a, b))
            {
                return new TextComparer((Text) a, (Text)b);
            }
            if (CheckType<Underline>(a, b))
            {
                return new UnderlineComparer((Underline)a, (Underline)b);
            }
            if(CheckType<RunProperties>(a, b))
            {
                return new RunPropertiesComparer((RunProperties)a, (RunProperties)b);
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

            return new OpenXmlElementComparer(a, b);
        }

        private static bool CheckType<T>(OpenXmlElement a, OpenXmlElement b) where T :OpenXmlElement 
        {
            return (a != null && a.GetType() == typeof(T)) || (b != null && b.GetType() == typeof(T));
        }
    }
}
