using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x77897888133D3B03, NameHash = 0x9C498422BDBE21FE)]
    public class GcNGuiSpecialTextStyleData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Name;
        /* 0x10 */ public List<NMSTemplate> StyleProperties;
        /* 0x20 */ public GcNGuiStyleAnimationData Animation;
    }
}
