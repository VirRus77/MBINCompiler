namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6BE378BBD478B472, NameHash = 0x3B7C404C59D201EF)]
    public class GcSettlementStatStrength : NMSTemplate
    {
        // size: 0x7
        public enum SettlementStatStrengthEnum {
            PositiveWide,
            PositiveLarge,
            PositiveMedium,
            PositiveSmall,
            NegativeSmall,
            NegativeMedium,
            NegativeLarge
        }
        /* 0x0 */ public SettlementStatStrengthEnum SettlementStatStrength;
    }
}
