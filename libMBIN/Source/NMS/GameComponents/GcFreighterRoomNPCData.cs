namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA94A8731592D781, NameHash = 0xBCA190142B227B20)]
    public class GcFreighterRoomNPCData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 RoomID;
        [NMS(Size = 0x5, EnumType = typeof(GcFreighterNPCType.FreighterNPCTypeEnum))]
        /* 0x10 */ public float[] SpawnCapacity;
        [NMS(Size = 0x5, EnumType = typeof(GcFreighterNPCType.FreighterNPCTypeEnum))]
        /* 0x24 */ public float[] POISelectionWeight;
    }
}
