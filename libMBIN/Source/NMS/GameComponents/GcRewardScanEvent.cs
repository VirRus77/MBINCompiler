namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x71087ADFCE7F1C9, NameHash = 0xD6D2BF5DDCCD9F49)]
    public class GcRewardScanEvent : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A Event;
        // size: 0x6
        public enum ScanEventTableEnum {
            Space,
            Planet,
            Missions,
            Tutorial,
            MissionsCreative,
            NPCPlanetSite
        }
        /* 0x20 */ public ScanEventTableEnum ScanEventTable;
        /* 0x24 */ public bool DoAerialScan;
        /* 0x25 */ public bool UseMissionSeedForEvent;
        /* 0x28 */ public float StartDelay;
        /* 0x2C */ public bool UseStartDelayWhenNoAerialScan;
    }
}
