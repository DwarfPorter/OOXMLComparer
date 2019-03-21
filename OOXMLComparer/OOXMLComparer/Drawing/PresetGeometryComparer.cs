using DocumentFormat.OpenXml.Drawing;
using OOXMLComparer.Helpers;

namespace OOXMLComparer.Drawing
{
    public class PresetGeometryComparer : OpenXmlElementComparer<PresetGeometry>
    {
        public PresetGeometryComparer(PresetGeometry a, PresetGeometry b) : base(a, b)
        {
        }
        public override bool Compare()
        {
            return a.CompareNullElements(b, t => t.Preset == null && t.AdjustValueList == null) ?? (Equals(a.Preset, b.Preset) && ((a.AdjustValueList == null && b.AdjustValueList == null) || (a.AdjustValueList != null && b.AdjustValueList != null)));
        }
    }
}