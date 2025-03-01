using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x635D3C311425224B, NameHash = 0x379CFCF1CE84CBAA)]
    public class TkAnimationComponentData : NMSTemplate
    {
        /* 0x000 */ public TkAnimationData Idle;
        /* 0x138 */ public List<TkAnimationData> Anims;
        /* 0x148 */ public List<TkAnimBlendTree> Trees;
        /* 0x158 */ public bool NetSyncAnimations;
        /* 0x160 */ public List<TkAnimJointLODData> JointLODOverrides;
    }
}
