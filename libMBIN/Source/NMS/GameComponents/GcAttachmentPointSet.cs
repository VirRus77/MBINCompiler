using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x726FBD0DB3DDF490, NameHash = 0x762F430C6C191529)]
    public class GcAttachmentPointSet : NMSTemplate
    {
        /* 0x00 */ public bool Enabled;
        /* 0x01 */ public NMSString0x40 DebugName;
        /* 0x41 */ public NMSString0x40 BoneName;
        /* 0x88 */ public List<GcAttachmentPointData> FixedPoints;
    }
}
