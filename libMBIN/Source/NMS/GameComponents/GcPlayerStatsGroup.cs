using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x95832B03280A90AE, NameHash = 0xEBAB39E2F49FE5F)]
    public class GcPlayerStatsGroup : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 GroupId;
        /* 0x10 */ public ulong Address;
        /* 0x18 */ public List<GcPlayerStat> Stats;
    }
}
