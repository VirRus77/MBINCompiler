using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9A47FF150A81B25, NameHash = 0x6B3A62EF81161171)]
    public class GcUnlockableItemTree : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A Title;
        /* 0x20 */ public NMSString0x10 CostTypeID;
        /* 0x30 */ public GcUnlockableItemTreeNode Root;
    }
}
