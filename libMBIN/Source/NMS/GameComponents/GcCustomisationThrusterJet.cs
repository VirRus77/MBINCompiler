using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x510651666D3E23EE, NameHash = 0x73B8C106776DC488)]
    public class GcCustomisationThrusterJet : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 LocatorPrefix;
        /* 0x10 */ public NMSString0x10 Effect;
        /* 0x20 */ public TkModelResource JetMesh;
        /* 0xA4 */ public TkModelResource Trail;
    }
}
