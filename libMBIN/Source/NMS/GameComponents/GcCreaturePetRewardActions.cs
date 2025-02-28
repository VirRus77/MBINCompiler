namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x200EB1420A5AD3AB, NameHash = 0xA78B3BB0870D4585)]
    public class GcCreaturePetRewardActions : NMSTemplate
    {
        // size: 0x9
        public enum PetActionEnum {
            Tickle,
            Treat,
            Ride,
            Customise,
            Abandon,
            LayEgg,
            Adopt,
            Milk,
            HarvestSpecial
        }
        /* 0x0 */ public PetActionEnum PetAction;
    }
}
