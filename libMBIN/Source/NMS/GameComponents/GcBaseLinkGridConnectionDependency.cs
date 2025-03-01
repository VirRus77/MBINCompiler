using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x906A276E4BAA29A0, NameHash = 0xB9BE8F8A6900C12E)]
    public class GcBaseLinkGridConnectionDependency : NMSTemplate
    {
        /* 0x00 */ public GcBaseLinkGridConnectionData Connection;
        /* 0x38 */ public int DependentRate;
        // size: 0x5
        public enum DependentEffectEnum {
            None,
            EnablesRate,
            DisablesRate,
            EnablesConnection,
            DisablesConnection
        }
        /* 0x3C */ public DependentEffectEnum DependentEffect;
        /* 0x40 */ public bool DisableWhenOffline;
        /* 0x41 */ public bool TransfersConnections;
    }
}
