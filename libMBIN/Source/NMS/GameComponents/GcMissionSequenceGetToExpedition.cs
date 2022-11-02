namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD058E92A7D001B6B, NameHash = 0xB3C5F69D62F6CA73)]
    public class GcMissionSequenceGetToExpedition : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 Message;
        /* 0x080 */ public NMSString0x80 GalaxyMapMessage;
        /* 0x100 */ public NMSString0x20A Event;
        /* 0x120 */ public float CompletionDistance;
        /* 0x124 */ public NMSString0x80 DebugText;
    }
}
