using DocumentFormat.OpenXml.Wordprocessing;

namespace OOXMLComparer.Properties
{
    public class RunFontsComparer : IOpenXmlElementComparer<RunFonts>
    {
        public bool Compare(RunFonts a, RunFonts b)
        {
            if (a == null && b == null)
            {
                return true;
            }
            if (a == null && b != null)
            {
                return false;
            }
            if (a != null && b == null)
            {
                return false;
            }
            return Equals(a.HighAnsi, b.HighAnsi)
                && Equals(a.Ascii, b.Ascii)
                && Equals(a.ComplexScript, b.ComplexScript)
                && Equals(a.EastAsia, b.EastAsia);
        }
    }
}
