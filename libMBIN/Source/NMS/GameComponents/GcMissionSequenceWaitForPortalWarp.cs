namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBC28F9C242D90EEF, NameHash = 0x416E9E84AB204114)]
    public class GcMissionSequenceWaitForPortalWarp : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 Message;
        /* 0x080 */ public NMSString0x80 DebugText;
        /* 0x100 */ public bool WarpToSpace;
        /* 0x101 */ public NMSString0x20 OverrideUA;
    }
}
