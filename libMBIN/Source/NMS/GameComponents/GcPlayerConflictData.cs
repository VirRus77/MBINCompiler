namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBABD12AA58AADEC2, NameHash = 0xF47FD4328A49A000)]
    public class GcPlayerConflictData : NMSTemplate
    {
        // size: 0x4
        public enum ConflictLevelEnum {
            Low,
            Default,
            High,
            Pirate
        }
        /* 0x0 */ public ConflictLevelEnum ConflictLevel;
    }
}
