namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x915BFEDA04841F14, NameHash = 0x60EEF97D074917CD)]
    public class GcMissionGalacticFeature : NMSTemplate
    {
        // size: 0x3
        public enum GalacticFeatureEnum {
            Anomaly,
            Atlas,
            BlackHole
        }
        /* 0x0 */ public GalacticFeatureEnum GalacticFeature;
    }
}
