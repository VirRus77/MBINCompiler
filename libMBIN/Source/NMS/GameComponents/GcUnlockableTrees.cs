using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB46CBE8C22693D3A, NameHash = 0xDDC3AC505BDF81E2)]
    public class GcUnlockableTrees : NMSTemplate
    {
        [NMS(Size = 0xE, EnumType = typeof(GcUnlockableItemTreeGroups.UnlockableItemTreeEnum))]
        /* 0x000 */ public GcUnlockableItemTrees[] Trees;
        /* 0x2A0 */ public List<GcUnlockableTreeCostType> CostTypes;
    }
}
