using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA8E639DB66F59336, NameHash = 0x562052A8272CC4A3)]
    public class GcGalaxyWaypoint : NMSTemplate
    {
        /* 0x00 */ public GcGalacticAddressData Address;
        /* 0x14 */ public GcGalaxyWaypointTypes Type;
        /* 0x18 */ public NMSString0x20A EventId;
    }
}
