using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9D65B4EEA7EC8614, NameHash = 0x543210B019526A44)]
    public class GcBreakTechByStatData : NMSTemplate
    {
        /* 0x0 */ public GcStatsTypes DamageTechWithStat;
        /* 0x4 */ public bool IncludeStatChildren;
    }
}
