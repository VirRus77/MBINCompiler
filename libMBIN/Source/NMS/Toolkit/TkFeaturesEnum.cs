namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x6B0CCC967FBBBDDD, NameHash = 0x34E815E84B84D42B)]
    public class TkFeaturesEnum : NMSTemplate
    {
        // size: 0x7
        public enum FeatureTypesEnum {
            River,
            Crater,
            Arches,
            ArchesSmall,
            Blobs,
            BlobsSmall,
            Substance
        }
        /* 0x0 */ public FeatureTypesEnum FeatureTypes;
    }
}
