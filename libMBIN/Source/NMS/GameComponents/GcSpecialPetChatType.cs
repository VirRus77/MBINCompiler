namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4CB2E1CB51B9AEB5, NameHash = 0x3748852F6280E90F)]
    public class GcSpecialPetChatType : NMSTemplate
    {
        // size: 0x2
        public enum SpecialPetChatTypeEnum {
            Monster,
            Quad
        }
        /* 0x0 */ public SpecialPetChatTypeEnum SpecialPetChatType;
    }
}
