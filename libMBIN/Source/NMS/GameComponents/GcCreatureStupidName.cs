using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC0DED532C356B8F3, NameHash = 0x7754E453D7160CA6)]
    public class GcCreatureStupidName : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public int Count;
        /* 0x18 */ public List<NMSString0x80> Names;
    }
}
