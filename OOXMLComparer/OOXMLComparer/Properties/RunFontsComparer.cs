using DocumentFormat.OpenXml.Wordprocessing;

namespace OOXMLComparer.Properties
{
    public class RunFontsComparer : OpenXmlElementComparer<RunFonts>
    {
        public RunFontsComparer(RunFonts a, RunFonts b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            if (a == null && b == null)
            {
                return true;
            }
            if (a == null || b == null)
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
