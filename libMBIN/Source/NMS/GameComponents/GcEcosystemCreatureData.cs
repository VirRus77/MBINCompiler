using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x192B7E78FFECB082, NameHash = 0x3DFA2A5571B31ADB)]
    public class GcEcosystemCreatureData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Creature;
        /* 0x10 */ public GcTerrainTileType TileType;
        /* 0x14 */ public float MinHeight;
        /* 0x18 */ public float MaxHeight;
        /* 0x1C */ public float Rarity;
    }
}
