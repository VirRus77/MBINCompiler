namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x94C1091A44FB177F, NameHash = 0x1B40C15E29F0E6FF)]
    public class GcPortalSaveData : NMSTemplate
    {
        /* 0x00 */ public GcSeed PortalSeed;
        /* 0x10 */ public ulong LastPortalUA;
        /* 0x18 */ public bool IsStoryPortal;
    }
}
