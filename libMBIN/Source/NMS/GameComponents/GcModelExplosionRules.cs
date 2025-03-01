using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF03CD20E14DD74EE, NameHash = 0xD04C1E382833D93A)]
    public class GcModelExplosionRules : NMSTemplate
    {
        /* 0x00 */ public List<GcModelExplosionRule> Rules;
        [NMS(Size = 0x9, EnumType = typeof(GcSpaceshipClasses.ShipClassEnum))]
        /* 0x10 */ public bool[] UseRules;
        [NMS(Size = 0x9, EnumType = typeof(GcSpaceshipClasses.ShipClassEnum))]
        /* 0x1C */ public float[] ShipSalvageDisplayScales;
    }
}
