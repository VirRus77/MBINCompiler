namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFB091A9FE7BEEF88, NameHash = 0x7DF5AD147C5460A0)]
    public class GcExperienceTimers : NMSTemplate
    {
        /* 0x00 */ public int HighChance;
        /* 0x04 */ public int LowChance;
        /* 0x08 */ public Vector2f High;
        /* 0x10 */ public Vector2f Normal;
        /* 0x18 */ public Vector2f Low;
    }
}
