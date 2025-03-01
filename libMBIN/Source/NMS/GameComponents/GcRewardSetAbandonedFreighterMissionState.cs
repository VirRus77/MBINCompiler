namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x315DC82D18EE19C8, NameHash = 0xDEABEB9DAFEFB3D9)]
    public class GcRewardSetAbandonedFreighterMissionState : NMSTemplate
    {
        // size: 0x6
        public enum AbandonedFreighterMissionStateEnum {
            EndRoomComplete,
            CrewManifestRead,
            CaptainsLogRead,
            HazardOn,
            SlowWalkOn,
            OpenDoors
        }
        /* 0x0 */ public AbandonedFreighterMissionStateEnum AbandonedFreighterMissionState;
        /* 0x4 */ public bool Silent;
    }
}
