using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xCB3BD3AB3B27C3A5, NameHash = 0x26AACC9ACEE360C5)]
    public class TkLSystemGlobalRestriction : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20 Name;
        /* 0x20 */ public NMSString0x80 Model;
        /* 0xA0 */ public List<TkLSystemRestrictionData> Restrictions;
    }
}
