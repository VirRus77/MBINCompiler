using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE8FEB8408ADB28EF, NameHash = 0xE90BC34FB3DEA4D7)]
    public class GcCostProduct : NMSTemplate
    {
        /* 0x00 */ public GcDefaultMissionProductEnum Default;
        /* 0x08 */ public NMSString0x10 Id;
        /* 0x18 */ public int Amount;
    }
}
