namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3A2B65EAA71EF899, NameHash = 0x9166CF1D0ED63522)]
    public class GcMissionSequencePirates : NMSTemplate
    {
        /* 0x00 */ public bool ScanCargo;
        /* 0x04 */ public int NumSquads;
        /* 0x08 */ public NMSString0x10 AttackDefinition;
        /* 0x18 */ public NMSString0x20A RewardMessageOverride;
        /* 0x38 */ public bool Silent;
        /* 0x3C */ public float DistanceOverride;
        /* 0x40 */ public bool ForceSpawn;
        /* 0x41 */ public NMSString0x80 DebugText;
    }
}
