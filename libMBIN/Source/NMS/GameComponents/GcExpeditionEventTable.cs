using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x25DAFD58E0264F3C, NameHash = 0xD5BCFB328D8A80A8)]
    public class GcExpeditionEventTable : NMSTemplate
    {
        /* 0x00 */ public List<GcExpeditionEventData> Events;
        /* 0x10 */ public List<GcExpeditionInterventionEventData> InterventionEvents;
    }
}
