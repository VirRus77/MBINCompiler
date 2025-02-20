using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAE88EA2F20A5D6ED, NameHash = 0x2ABA38292ED14515)]
    public class GcModuleOverride : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Module;
        /* 0x10 */ public float ProbabilityMultiplier;
        /* 0x14 */ public float OriginalSceneProbability;
        /* 0x18 */ public List<GcWeightedResource> Scenes;
    }
}
