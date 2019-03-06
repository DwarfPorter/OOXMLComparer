using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Properties
{
    public class RunFontsComparer : OpenXmlElementComparer<RunFonts>
    {
        public RunFontsComparer(RunFonts a, RunFonts b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareNullElements(b) ?? (Equals(a.HighAnsi, b.HighAnsi)
                && Equals(a.Ascii, b.Ascii)
                && Equals(a.ComplexScript, b.ComplexScript)
                && Equals(a.EastAsia, b.EastAsia));
        }
    }
}
