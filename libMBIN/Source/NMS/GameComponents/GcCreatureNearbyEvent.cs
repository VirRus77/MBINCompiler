using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB6562D53DE23DB78, NameHash = 0x42869E79D40A84C1)]
    public class GcCreatureNearbyEvent : NMSTemplate
    {
        /* 0x00 */ public List<GcCreatureAlertData> AlertTable;
        /* 0x10 */ public bool Inverse;
    }
}
