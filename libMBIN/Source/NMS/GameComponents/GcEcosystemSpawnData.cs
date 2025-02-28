using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCF917E16AFA12B38, NameHash = 0xB2F82AE85A5CD5EE)]
    public class GcEcosystemSpawnData : NMSTemplate
    {
        /* 0x00 */ public List<GcEcosystemCreatureData> Creatures;
        /* 0x10 */ public float CreatureMinNoise;
        /* 0x14 */ public float CreatureMaxNoise;
    }
}
