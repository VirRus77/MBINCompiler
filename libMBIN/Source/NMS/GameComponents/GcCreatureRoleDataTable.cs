using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7F0F4E1DE53C32F9, NameHash = 0xF460B1FDC0499CEA)]
    public class GcCreatureRoleDataTable : NMSTemplate
    {
        /* 0x00 */ public List<GcCreatureRoleData> AvailableRoles;
        /* 0x10 */ public float MaxProportionFlying;
        /* 0x14 */ public bool HasSandWorms;
        /* 0x18 */ public float SandWormFrequency;
    }
}
