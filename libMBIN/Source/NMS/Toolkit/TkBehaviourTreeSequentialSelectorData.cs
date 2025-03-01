using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x83D37F2262135CE4, NameHash = 0xF3C0FF9D1D7101FA)]
    public class TkBehaviourTreeSequentialSelectorData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Name;
        /* 0x10 */ public bool Looping;
        /* 0x11 */ public bool FailWhenAnyChildFails;
        /* 0x18 */ public List<NMSTemplate> Children;
    }
}
