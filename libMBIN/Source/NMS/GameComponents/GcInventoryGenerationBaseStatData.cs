using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCE3267FEB47983B8, NameHash = 0x7A13912B545C6365)]
    public class GcInventoryGenerationBaseStatData : NMSTemplate
    {
        [NMS(Size = 0x4, EnumType = typeof(GcInventoryClass.InventoryClassEnum))]
        /* 0x0 */ public GcInventoryGenerationBaseStatClassData[] BaseStatsPerClass;
    }
}
