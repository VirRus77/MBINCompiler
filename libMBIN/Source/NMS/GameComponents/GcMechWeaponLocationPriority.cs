using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x241AEC36ABCA7A5, NameHash = 0x3FADB12F28965B24)]
    public class GcMechWeaponLocationPriority : NMSTemplate
    {
        /* 0x0 */ public List<GcMechWeaponLocation> MechWeaponLocationPriority;
    }
}
