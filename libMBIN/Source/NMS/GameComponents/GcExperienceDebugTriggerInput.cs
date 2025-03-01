using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x19506B3FE77DB5A7, NameHash = 0xBCDA670B36E2534)]
    public class GcExperienceDebugTriggerInput : NMSTemplate
    {
        // size: 0xD
        public enum KeyPressEnum {
            _1,
            _2,
            _3,
            _4,
            _5,
            _6,
            _7,
            _8,
            _9,
            PadUp,
            PadDown,
            PadLeft,
            PadRight
        }
        /* 0x0 */ public KeyPressEnum KeyPress;
        /* 0x8 */ public List<GcExperienceDebugTriggerAction> Actions;
    }
}
