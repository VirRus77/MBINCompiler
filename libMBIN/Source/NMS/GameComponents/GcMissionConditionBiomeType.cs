using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x196DE04CA76F8A14, NameHash = 0x35BF34FE4907C4BC)]
    public class GcMissionConditionBiomeType : NMSTemplate
    {
        /* 0x0 */ public GcBiomeType Type;
        /* 0x4 */ public bool AnyInfested;
    }
}
