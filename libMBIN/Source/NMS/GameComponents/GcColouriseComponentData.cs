namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF603C94E9951BFF1, NameHash = 0x8F7F2EBCF9C0EDF)]
    public class GcColouriseComponentData : NMSTemplate
    {
        /* 0x00 */ public Colour PrimaryColour;
        /* 0x10 */ public Colour SecondaryColour;
        /* 0x20 */ public Colour TernaryColour;
        /* 0x30 */ public Colour QuaternaryColour;
    }
}
