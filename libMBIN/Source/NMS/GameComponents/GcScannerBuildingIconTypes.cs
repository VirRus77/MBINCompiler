namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE33556428B006E46, NameHash = 0x894C8A7A0498F6C5)]
    public class GcScannerBuildingIconTypes : NMSTemplate
    {
        // size: 0x21
        public enum ScanBuildingIconTypeEnum {
            None,
            Generic,
            Shelter,
            Relic,
            Factory,
            Unknown,
            Distress,
            Beacon,
            Waypoint,
            SpaceStation,
            TechResource,
            FuelResource,
            MineralResource,
            SpaceAnomaly,
            SpaceAtlas,
            ExternalBase,
            PlanetBaseTerminal,
            Nexus,
            AbandonedFreighter,
            Telescope,
            Outpost,
            UpgradePod,
            Cog,
            Ruins,
            Portal,
            Library,
            Abandoned,
            SmallBuilding,
            StoryGlitch,
            GraveInCave,
            HoloHub,
            Settlement,
            DroneHive
        }
        /* 0x0 */ public ScanBuildingIconTypeEnum ScanBuildingIconType;
    }
}
