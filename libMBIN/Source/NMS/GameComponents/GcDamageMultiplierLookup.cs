using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC58EEDC101824AA7, NameHash = 0x792FD0F5EBBA55E9)]
    public class GcDamageMultiplierLookup : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public float Default;
        /* 0x18 */ public List<GcDamageMultiplier> Multipliers;
    }
}
