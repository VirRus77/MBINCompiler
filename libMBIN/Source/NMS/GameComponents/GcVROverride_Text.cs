namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA797F745E7BEC09A, NameHash = 0x140DDCF57268A02D)]
    public class GcVROverride_Text : NMSTemplate
    {
        // size: 0x2
        public enum VROverride_TextEnum {
            FontHeight,
            FontIndex
        }
        /* 0x0 */ public VROverride_TextEnum VROverride_Text;
        /* 0x4 */ public int IntValue;
        /* 0x8 */ public float FloatValue;
    }
}
