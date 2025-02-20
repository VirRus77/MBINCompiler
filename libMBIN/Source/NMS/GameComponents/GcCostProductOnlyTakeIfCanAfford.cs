using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB78C87137A36DC0C, NameHash = 0xDEF97AA1BA31BC2A)]
    public class GcCostProductOnlyTakeIfCanAfford : NMSTemplate
    {
        /* 0x00 */ public GcDefaultMissionProductEnum Default;
        /* 0x08 */ public NMSString0x10 Id;
        /* 0x18 */ public int Amount;
        /* 0x20 */ public NMSString0x20A AltCostLocID;
    }
}
