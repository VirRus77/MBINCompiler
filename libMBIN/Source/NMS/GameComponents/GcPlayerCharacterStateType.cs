namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC9E413E9E584567C, NameHash = 0xDACE1F471447B685)]
    public class GcPlayerCharacterStateType : NMSTemplate
    {
        // size: 0x12
        public enum CharacterStateEnum {
            Idle,
            Jog,
            JogUphill,
            JogDownhill,
            SteepSlope,
            Sliding,
            Run,
            Airborne,
            JetpackBoost,
            RocketBoots,
            Riding,
            Swimming,
            SwimmingJetpack,
            Death,
            FullBodyOverride,
            InSpace,
            LowGWalk,
            LowGRun
        }
        /* 0x0 */ public CharacterStateEnum CharacterState;
    }
}
