namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x8384897911EE4641, NameHash = 0xD5128E119194249)]
    public class GcAtlasGlobals : NMSTemplate
    {
        /* 0x0 */ public int ChanceOfDisconnect;
        /* 0x4 */ public int TimeoutSecNameResolution;
        /* 0x8 */ public int TimeoutSecConnection;
        /* 0xC */ public int TimeoutSecSendRecv;
    }
}
