using DocumentFormat.OpenXml.Drawing;
using System;
using System.Collections.Generic;
using System.Text;

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