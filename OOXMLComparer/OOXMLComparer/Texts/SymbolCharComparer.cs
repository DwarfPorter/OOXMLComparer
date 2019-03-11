using DocumentFormat.OpenXml.Wordprocessing;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Texts
{
    public class SymbolCharComparer : OpenXmlElementComparer<SymbolChar>
    {
        public SymbolCharComparer(SymbolChar a, SymbolChar b) : base(a, b)
        {
        }

        public override bool Compare()
        {
            return a.CompareNullElements(b) ?? Equals(a.Char, b.Char) && Equals(a.Font, b.Font);
        }
    }
}
