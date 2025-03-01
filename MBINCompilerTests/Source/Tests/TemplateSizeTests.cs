﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using MBINCompilerTests;
using Database = MBINCompilerTests.Database;

namespace libMBIN.UnitTests {

    using TemplateSizes = Database.Tables.TemplateSize;

    [TestClass]
    public class TemplateSizeTests {

        //private readonly Dictionary<string, int> templateSizes = new Dictionary<string, int>() {
        //    { "TkCurveType", 0x4 },
        //    { "GcCameraAerialViewData", 0x24 },
        //    { "GcCameraShakeCapturedData", 0x14 },
        //    { "GcCameraShakeMechanicalData", 0x70 },
        //    { "GcCameraShakeData", 0xC0 },
        //    { "GcAISpaceshipRoles", 0x4 },
        //    { "GcGeneratedShipCounts", 0xC },
        //    { "GcAISpaceshipTypes", 0x4 },
        //    { "GcAudio3PointDopplerData", 0xC },
        //    { "GcAudioNPCDoppler", 0x3C },
        //    { "GcAlienRace", 0x4 },
        //    { "GcBiomeType", 0x4 },
        //    { "GcPlanetLife", 0x4 },
        //    { "GcGalaxyStarAnomaly", 0x4 },
        //    { "TkImGuiSettings", 0x190 },
        //    { "GcHeavyAirColourData", 0x20 },
        //    { "GcPlanetHeavyAirData", 0x120 },
        //    { "GcPlanetWaterData", 0x1B0 },
        //    { "GcResourceCollectEffect", 0x34 },
        //    { "GcBoidData", 0x2C },
        //    { "GcPlayerStickData", 0x1C },
        //    { "GcCreatureTypes", 0x4 },
        //    { "GcCreatureAlertData", 0x18 },
        //    { "GcProjectileLineData", 0x28 },
        //    { "GcCameraSpawnSetupData", 0x10 },
        //    { "GcInventoryValueData", 0x1C },
        //    { "GcCameraAnomalySetupData", 0x40 },
        //    { "GcPlayerSpaceshipEngineData", 0x54 },
        //    { "GcPlayerSpaceshipControlData", 0xF0 },
        //    { "GcPlayerSpaceshipAim", 0x18 },
        //    { "GcPlayerSpaceshipWarpData", 0x30 },
        //    { "GcShipAIAttackData", 0x8C },
        //    { "GcSpaceshipTravelData", 0x48 },
        //    { "GcShipAIDeathData", 0x1C },
        //    { "GcShipAIPlanetPatrolData", 0x38 },
        //    { "GcRealitySubstanceCategory", 0x4 },
        //    { "GcRarity", 0x4 },
        //    { "GcMiningSubstanceData", 0xC },
        //    { "GcTerrainOverlayColours", 0xC },
        //    { "TkShearWindOctaveData", 0x14 },
        //    { "TkShearWindData", 0x80 },
        //    { "GcSkyProperties", 0x30 },
        //    { "TkPaletteTexture", 0x8 },
        //    { "GcHeavyAirSettingValues", 0x20 },
        //    { "GcFogProperties", 0xDC },
        //    { "GcSpaceSkyProperties", 0x130 },
        //    { "GcFlyingSnakeData", 0x40 },
        //    { "GcExperienceTimers", 0x20 },
        //    { "GcScanData", 0x14 },
        //    { "GcZoomData", 0x1C },
        //    { "GcScanEffectData", 0x40 },
        //    { "GcBuildingClassification", 0x4 },
        //    { "GcShipHUDTargetIconData", 0x300 },
        //    { "GcShipHUDTargetData", 0x430 },
        //    { "GcTracerData", 0x18 },
        //    { "GcGalaxyMarkerSettings", 0x70 },
        //    { "GcGalaxyRenderAnostreakData", 0x30 },
        //    { "GcGalaxyStarTypes", 0x4 },
        //    { "GcGalaxyStarColours", 0x40 },
        //    { "GcGalaxyCameraData", 0x58 },
        //    { "GcAudioWwiseEvents", 0x4 },
        //    { "GcAudioWwiseRTPCs", 0x4 },
        //    { "GcGalaxyAudioSetupData", 0x44 },
        //    { "GcGalaxyRenderSetupData", 0x1F0 },
        //    { "GcGalaxyGenerationSetupData", 0x170 },
        //    { "TkNGuiRectanglePulseEffect", 0x14 },
        //    { "TkCameraWanderData", 0xC },
        //    { "TkModelRendererCameraData", 0x40 },
        //    { "TkModelRendererData", 0x70 },
        //    { "GcModelViewCollection", 0x5B0 },
        //    { "GcSpaceMapObjectData", 0x30 },
        //    { "GcDiscoveryHelperTimings", 0xC },
        //    { "GcHUDStartup", 0x8 },
        //    { "GcHUDStartupTable", 0x80 },
        //    { "GcInventorySlotActionData", 0x1C },
        //    { "GcRobotLaserData", 0x50 },
        //    { "GcDroneControlData", 0x2C },
        //    { "GcDroneData", 0x1C0 },
        //    { "GcDiscoveryOwner", 0xC4 },
        //    { "GcGalacticAddressData", 0x14 },
        //    { "GcUniverseAddressData", 0x18 },
        //    { "GcDiscoveryTypes", 0x4 },
        //    { "GcAtlasDiscoveryData", 0x48 },
        //    { "GcAtlasDiscoveryMetadata", 0x80 },
        //    { "GcAtlasDiscovery", 0x1F0 },
        //    { "GcAtlasRecvBasic", 0x10 },
        //    { "GcAtlasRecvBlob", 0x40 },
        //    { "GcAtlasRecvDiscoveryExact", 0x200 },
        //    { "GcAtlasRecvDiscoveryList", 0xC1D0 },
        //    { "GcAtlasRecvVoxel", 0x50 },
        //    { "GcAtlasSendReport", 0xA8 },
        //    { "GcAtlasSendRequestBlob", 0x70 },
        //    { "GcAtlasSendRequestDiscoveryAllOnPlanet", 0x20 },
        //    { "GcAtlasSendRequestDiscoveryCategory", 0x28 },
        //    { "GcAtlasSendRequestDiscoveryExact", 0x50 },
        //    { "GcAtlasSendRequestVoxel", 0x20 },
        //    { "GcAtlasSendSubmitDiscoveryExact", 0xD0 },
        //    { "GcAudioPulseDemo", 0x2C },
        //    { "GcEntitlementRewardData", 0x70 },
        //    { "GcEntitlementRewardsTable", 0x10 },
        //    { "GcDistanceScaleComponentData", 0x18 },
        //    { "GcInteractionActivationCost", 0x28 },
        //    { "GcLandingHelperComponentData", 0xC },
        //    { "GcLootComponentData", 0x20 },
        //    { "GcObjectPlacementComponentData", 0x34 },
        //    { "GcSizeIndicator", 0x4 },
        //    { "GcSimpleInteractionComponentData", 0x88 },
        //    { "GcTurretComponentData", 0x4 },
        //    { "GcInventoryType", 0x4 },
        //    { "GcInventoryIndex", 0x8 },
        //    { "GcInventoryElement", 0x30 },
        //    { "GcInventoryContainer", 0x20 },
        //    { "GcInventoryLayout", 0x20 },
        //    { "TkProceduralTextureChosenOption", 0x50 },
        //    { "TkProceduralTextureChosenOptionSampler", 0x10 },
        //    { "TkProceduralTextureChosenOptionList", 0x10 },
        //    { "GcResourceElement", 0x2A8 },
        //    { "GcExactResource", 0x90 },
        //    { "GcWordKnowledge", 0x18 },
        //    { "GcPlayerMissionProgress", 0x18 },
        //    { "GcScanEventSave", 0x50 },
        //    { "GcStatValueData", 0xC },
        //    { "GcPlayerStat", 0x20 },
        //    { "GcPlayerStatsGroup", 0x28 },
        //    { "GcInteractionBufferType", 0x4 },
        //    { "GcInteractionData", 0x20 },
        //    { "GcInteractionBuffer", 0x7D10 },
        //    { "GcPlayerHazardType", 0x4 },
        //    { "GcInteractionType", 0x4 },
        //    { "GcSavedInteractionRaceData", 0x18 },
        //    { "GcSavedEntitlement", 0x100 },
        //    { "GcPlayerStateData", 0x396E0 },
        //    { "GcPlayerSpawnStateData", 0x50 },
        //    { "GcDefaultSaveData", 0x39730 },
        //    { "GcPlayerMissionProgressMapEntry", 0x20 },
        //    { "GcPlayerMissionProgressMapTable", 0x10 },
        //    { "GcJourneyMilestoneData", 0x38 },
        //    { "GcJourneyMilestoneTable", 0x10 },
        //    { "TkTextureResource", 0x84 },
        //    { "GcStatLevelData", 0x40 },
        //    { "GcLeveledStatData", 0x3B8 },
        //    { "GcLeveledStatTable", 0x10 },
        //    { "GcStatType", 0x4 },
        //    { "GcStatTrackType", 0x4 },
        //    { "GcStatDisplayType", 0x4 },
        //    { "GcStatDefinition", 0x28 },
        //    { "GcStatDefinitionTable", 0x10 },
        //    { "GcStatGroupData", 0x20 },
        //    { "GcStatGroupTable", 0x10 },
        //    { "GcStatsAchievements", 0x4 },
        //    { "GcStatsOneShotTypes", 0x4 },
        //    { "GcStatsValueTypes", 0x4 },
        //    { "GcColourModifier", 0x30 },
        //    { "GcColourPaletteData", 0x50 },
        //    { "GcPaletteData", 0x410 },
        //    { "GcPaletteList", 0x9A60 },
        //    { "GcBootLogoData", 0x410 },
        //    { "GcFontTypesEnum", 0x4 },
        //    { "GcTextPreset", 0x70 },
        //    { "GcHUDManagerData", 0x1D0 },
        //    { "GcTexturePrefetchData", 0x10 },
        //    { "GcHUDMarkerData", 0x180 },
        //    { "GcFontData", 0x84 },
        //    { "GcFontTable", 0x420 },
        //    { "GcGenericIconTypes", 0x4 },
        //    { "GcHUDComponent", 0x28 },
        //    { "GcHUDImageData", 0xC0 },
        //    { "GcHUDLayerData", 0x38 },
        //    { "GcHUDTextData", 0x120 },
        //    { "GcScannerBuildingIconTypes", 0x4 },
        //    { "GcScannerIconTypes", 0x4 },
        //    { "GcScannerIcons", 0x39E0 },
        //    { "GcTextPresetTable", 0x10 },
        //    { "GcTextStyleOutline", 0x20 },
        //    { "GcTextStyleShadow", 0x20 },
        //    { "GcNGuiActionData", 0x98 },
        //    { "TkNGuiAlignment", 0x8 },
        //    { "GcNGuiLayoutData", 0x2C },
        //    { "GcNGuiElementData", 0x58 },
        //    { "GcNGuiFileBrowserRecents", 0xA00 },
        //    { "TkNGuiGraphicStyleData", 0x80 },
        //    { "TkNGuiGraphicStyle", 0x1B0 },
        //    { "GcNGuiGraphicData", 0x290 },
        //    { "GcNGuiLayerData", 0x320 },
        //    { "GcNGuiPresetGraphic", 0x270 },
        //    { "TkNGuiTextStyleData", 0x40 },
        //    { "TkNGuiTextStyle", 0xC0 },
        //    { "GcNGuiPresetText", 0x330 },
        //    { "GcNGuiPreset", 0x5150 },
        //    { "GcNGuiSpacingData", 0x58 },
        //    { "GcNGuiSpecialTextImageData", 0xA0 },
        //    { "GcNGuiSpecialTextImages", 0x10 },
        //    { "GcNGuiStyleAnimationKeyframeData", 0x18 },
        //    { "GcNGuiStyleAnimationData", 0x18 },
        //    { "GcNGuiSpecialTextStyleData", 0x38 },
        //    { "GcNGuiSpecialTextStyles", 0x10 },
        //    { "GcNGuiTextData", 0x560 },
        //    { "GcStyleProp_Colour", 0x10 },
        //    { "GcStyleProp_Size", 0x4 },
        //    { "GcMessageCrime", 0x30 },
        //    { "GcMessageProjectileImpact", 0x20 },
        //    { "GcMessageShipWarp", 0xC },
        //    { "GcMessageSubstanceMined", 0x18 },
        //    { "GcMessageTrackTargetAlert", 0x20 },
        //    { "GcPerformanceFlyby", 0x18 },
        //    { "GcPerformanceGuard", 0x4 },
        //    { "TkInputEnum", 0x4 },
        //    { "GcShipAIPerformanceArray", 0x10 },
        //    { "GcAIShipSpawnData", 0xA8 },
        //    { "GcExperienceSpawnTable", 0xC0 },
        //    { "GcAlienPuzzleOption", 0x248 },
        //    { "GcAlienPuzzleEntry", 0x430 },
        //    { "GcAlienPuzzleTable", 0x10 },
        //    { "GcAlienSpeechEntry", 0x40 },
        //    { "GcAlienSpeechTable", 0x10 },
        //    { "GcCostJourneyMilestone", 0x10 },
        //    { "GcCostJourneyStatLevel", 0x18 },
        //    { "GcCostProduct", 0x18 },
        //    { "GcCostStanding", 0x8 },
        //    { "GcCostSubstance", 0x18 },
        //    { "GcCostTableEntry", 0x58 },
        //    { "GcCostTable", 0x20 },
        //    { "GcDeathQuote", 0x120 },
        //    { "GcDeathStateData", 0x160 },
        //    { "GcDiscoveryWorth", 0x14 },
        //    { "GcRewardTableItem", 0x90 },
        //    { "GcRewardTableItemList", 0x38 },
        //    { "GcGenericRewardTableEntry", 0x48 },
        //    { "GcInventoryTableEntry", 0x20 },
        //    { "GcInventoryTable", 0x10 },
        //    { "GcItemPriceModifiers", 0x14 },
        //    { "GcLegality", 0x4 },
        //    { "GcNameGeneratorSectorTypes", 0x4 },
        //    { "GcNameGeneratorTypes", 0x4 },
        //    { "GcPlayerDamageData", 0x128 },
        //    { "GcPlayerDamageTable", 0x10 },
        //    { "GcProductCategory", 0x4 },
        //    { "TkModelResource", 0x84 },
        //    { "GcTechnologyRequirement", 0x18 },
        //    { "GcProductData", 0x2C0 },
        //    { "GcProductTable", 0x10 },
        //    { "GcRealityCommonFactions", 0x4 },
        //    { "GcRealitySubstanceCraftingMix", 0x18 },
        //    { "GcRealityCraftingRecipeData", 0x58 },
        //    { "GcRealityFactionData", 0x90 },
        //    { "GcRealityIconTable", 0x120C },
        //    { "GcStatsTypes", 0x4 },
        //    { "GcStatsEntry", 0x30 },
        //    { "GcStatsGroup", 0xA8 },
        //    { "GcStats", 0x2A0 },
        //    { "GcTradeData", 0x50 },
        //    { "GcTradeSettings", 0xA0 },
        //    { "GcRealityManagerData", 0x47F0 },
        //    { "GcRealitySubstanceData", 0x1F0 },
        //    { "GcRewardChangeGlobalMission", 0x4 },
        //    { "GcRewardDamage", 0x10 },
        //    { "GcTechnologyCategory", 0x4 },
        //    { "GcRewardDamageTech", 0x4 },
        //    { "GcRewardHazard", 0x8 },
        //    { "GcRewardHealth", 0x8 },
        //    { "GcRewardMoney", 0x8 },
        //    { "GcRewardMultiSpecificProducts", 0x10 },
        //    { "GcRewardProduct", 0x18 },
        //    { "GcRewardProductRecipe", 0x14 },
        //    { "GcRewardRepairTech", 0x4 },
        //    { "GcRewardScan", 0x14 },
        //    { "GcRewardShield", 0x8 },
        //    { "GcRewardSignalScan", 0x4 },
        //    { "GcRewardSpecificProduct", 0x18 },
        //    { "GcRewardSpecificProductRecipe", 0x10 },
        //    { "GcRewardSpecificShip", 0x2E8 },
        //    { "GcRewardSpecificTech", 0x10 },
        //    { "GcRewardSpecificTechFromList", 0x18 },
        //    { "GcRewardSpecificWeapon", 0xD0 },
        //    { "GcRewardStanding", 0xC },
        //    { "GcRewardSubstance", 0x14 },
        //    { "GcRewardTableCategory", 0xA8 },
        //    { "GcRewardTableEntry", 0x208 },
        //    { "GcRewardTable", 0x60 },
        //    { "GcRewardTeachWord", 0xC },
        //    { "GcRewardTechRecipe", 0x18 },
        //    { "GcRewardWeapon", 0x10 },
        //    { "GcSubstanceTable", 0x20 },
        //    { "GcTechnologyRarity", 0x4 },
        //    { "GcStatsBonus", 0xC },
        //    { "GcTechnology", 0x2B0 },
        //    { "GcTechnologyTable", 0x10 },
        //    { "GcTechnologyTypes", 0x10 },
        //    { "GcRewardDestructEntry", 0x4 },
        //    { "GcRewardDestructTable", 0x3C },
        //    { "GcStatIconTable", 0x2300 },
        //    { "GcAudioAreaTriggerComponentData", 0x10 },
        //    { "GcEncounterComponentData", 0x10 },
        //    { "GcInteractionComponentData", 0x130 },
        //    { "GcNPCComponentData", 0x4 },
        //    { "GcMiningComponentData", 0x8 },
        //    { "GcOutpostLSystemPair", 0x320 },
        //    { "GcOutpostComponentData", 0x48 },
        //    { "GcEncyclopediaComponentData", 0x4 },
        //    { "GcScannableComponentData", 0x34 },
        //    { "GcActionTrigger", 0x58 },
        //    { "GcActionTriggerState", 0x20 },
        //    { "GcCameraShakeTriggerData", 0x38 },
        //    { "GcCameraShakeComponentData", 0x18 },
        //    { "GcChainComponentData", 0x20 },
        //    { "GcInventoryTechProbability", 0x18 },
        //    { "GcCustomInventoryComponentData", 0x28 },
        //    { "GcDecorationComponentData", 0x8 },
        //    { "GcMarkerComponentData", 0x10 },
        //    { "GcMetaBallComponentData", 0xD0 },
        //    { "GcTriggerActionComponentData", 0x30 },
        //    { "GcCameraShakeAction", 0x18 },
        //    { "GcDisplayText", 0x304 },
        //    { "GcGoToStateAction", 0x18 },
        //    { "GcNodeActivationAction", 0x84 },
        //    { "GcPainAction", 0x18 },
        //    { "GcParticleAction", 0x38 },
        //    { "GcPlayAnimAction", 0x10 },
        //    { "GcPlayAudioAction", 0x80 },
        //    { "GcRewardAction", 0x10 },
        //    { "GcScareCreaturesAction", 0x8 },
        //    { "GcSpawnAction", 0x10 },
        //    { "GcWarpAction", 0x4 },
        //    { "GcAnimFrameEvent", 0x18 },
        //    { "GcBeenShotEvent", 0xC },
        //    { "GcCreatureNearbyEvent", 0x18 },
        //    { "GcPlayerNearbyEvent", 0x24 },
        //    { "GcStateTimeEvent", 0x4 },
        //    { "GcCreatureIkType", 0x4 },
        //    { "GcPrimaryAxis", 0x4 },
        //    { "GcBirdData", 0x90 },
        //    { "GcCreatureFootParticleSingleData", 0x20 },
        //    { "GcCreatureFootParticleData", 0x10 },
        //    { "GcCreatureHealthData", 0x50 },
        //    { "GcCreatureMoveAnimData", 0x40 },
        //    { "GcCreatureMovementData", 0x28 },
        //    { "GcCreatureSwarmData", 0x40 },
        //    { "GcCreatureVocalSoundData", 0x28 },
        //    { "GcCreatureVocalData", 0xA8 },
        //    { "GcCreatureAudioTable", 0x10 },
        //    { "GcCreatureData", 0x58 },
        //    { "GcCreatureDataTable", 0x10 },
        //    { "GcCreatureFilename", 0x90 },
        //    { "GcCreatureFilenameTable", 0x10 },
        //    { "GcCreatureIkData", 0x104 },
        //    { "GcCreatureFullBodyIKComponentData", 0x18 },
        //    { "GcCreatureInfo", 0x418 },
        //    { "GcCreatureStupidName", 0x28 },
        //    { "GcCreatureStupidNameTable", 0x90 },
        //    { "GcCreatureVocalTestData", 0x38 },
        //    { "GcCreatureBaitComponentData", 0x20 },
        //    { "GcCreatureComponentData", 0x18 },
        //    { "GcCreatureGroupDescription", 0x20 },
        //    { "GcCreatureGroupProbability", 0x18 },
        //    { "GcCreatureGroups", 0x4 },
        //    { "GcCreatureRoles", 0x4 },
        //    { "GcCreatureRoleDescription", 0x40 },
        //    { "GcTerrainTileType", 0x4 },
        //    { "GcCreatureRoleData", 0x490 },
        //    { "GcCreatureRoleDataTable", 0x10 },
        //    { "GcCreatureRoleDescriptionTable", 0x20 },
        //    { "GcCreatureRoleFilename", 0x90 },
        //    { "GcCreatureRoleFilenameList", 0x10 },
        //    { "GcCreatureRoleFilenameTable", 0xE0 },
        //    { "GcSpawnComponentOption", 0x2C8 },
        //    { "GcCreatureSpawnComponentData", 0x390 },
        //    { "GcCreatureSpawnData", 0x598 },
        //    { "GcCreatureSpawnEnum", 0x4 },
        //    { "GcEcosystemCreatureData", 0x20 },
        //    { "GcEcosystemSpawnData", 0x18 },
        //    { "GcFoliageComponentData", 0x4 },
        //    { "GcBuildingClusterPlacement", 0x4 },
        //    { "GcBuildingDensityLevels", 0x4 },
        //    { "GcBuildingDefinitionData", 0x48 },
        //    { "GcBuildingDensity", 0x14 },
        //    { "GcBuildingFilename", 0x200 },
        //    { "GcBuildingFilenameList", 0x2C00 },
        //    { "GcBuildingDefinitionTable", 0x10EA8 },
        //    { "GcBuildingDistribution", 0x18 },
        //    { "GcBuildingSpawnData", 0x5D0 },
        //    { "GcCloudProperties", 0x30 },
        //    { "GcObjectSpawnData", 0x378 },
        //    { "GcSelectableObjectSpawnData", 0x2A8 },
        //    { "GcSelectableObjectSpawnList", 0x20 },
        //    { "GcEnvironmentSpawnData", 0x50 },
        //    { "GcExternalObjectListOptions", 0x220 },
        //    { "GcLightProperties", 0x30 },
        //    { "GcObjectDefinitionData", 0x9C },
        //    { "GcObjectSpawnDataArray", 0x18 },
        //    { "GcPlanetBuildingData", 0x18 },
        //    { "GcResourceOrigin", 0x4 },
        //    { "GcSubstanceAmount", 0x20 },
        //    { "GcTileTypeOptions", 0x10 },
        //    { "GcObjectPlacementCategory", 0x4 },
        //    { "GcSelectableObjectData", 0x80 },
        //    { "GcSelectableObjectList", 0x28 },
        //    { "GcSelectableObjectTable", 0x10 },
        //    { "GcHazardValues", 0x8 },
        //    { "GcHazardValueTypes", 0x4 },
        //    { "GcWeatherColourModifiers", 0x270 },
        //    { "GcWeatherOptions", 0x4 },
        //    { "GcWeatherProperties", 0x900 },
        //    { "GcWeatherTable", 0x3F8 },
        //    { "GcGalaxyMarkerTypes", 0x4 },
        //    { "GcPlanetSize", 0x4 },
        //    { "GcGalaxyStarAttributesData", 0x190 },
        //    { "GcGalaxyVoxelAttributesData", 0x84 },
        //    { "GcGalaxyWaypointTypes", 0x4 },
        //    { "GcGalaxyWaypoint", 0x20 },
        //    { "GcPhysicsCollisionGroups", 0x4 },
        //    { "GcScanEventData", 0xD0 },
        //    { "GcScanEventTable", 0x10 },
        //    { "GcSceneSettings", 0x4B0 },
        //    { "GcSpaceshipClasses", 0x4 },
        //    { "GcDebrisData", 0x98 },
        //    { "GcExplosionData", 0xC0 },
        //    { "GcExplosionDataTable", 0x10 },
        //    { "GcPlayerHazardData", 0x58 },
        //    { "GcPlayerHazardTable", 0x210 },
        //    { "GcDestructableComponentData", 0x120 },
        //    { "GcProjectileImpactType", 0x4 },
        //    { "GcProjectileImpactData", 0x18 },
        //    { "GcLaserBeamData", 0x1A0 },
        //    { "GcProjectileData", 0x340 },
        //    { "GcProjectileDataTable", 0x20 },
        //    { "GcShootableComponentData", 0x30 },
        //    { "GcDroneComponentData", 0x68 },
        //    { "GcButtonSpawnOffset", 0x20 },
        //    { "GcButtonSpawn", 0x28 },
        //    { "GcButtonSpawnTable", 0x10 },
        //    { "GcSolarSystemLocatorTypes", 0x4 },
        //    { "GcSolarSystemLocatorChoice", 0x2C },
        //    { "GcAsteroidGeneratorAssignment", 0x48 },
        //    { "GcAsteroidGeneratorRing", 0x80 },
        //    { "GcAsteroidGeneratorSlab", 0x80 },
        //    { "GcAsteroidGeneratorSurround", 0x60 },
        //    { "GcSolarSystemEventWarpIn", 0xA0 },
        //    { "GcSolarSystemEventWarpOut", 0x2C },
        //    { "GcSolarSystemEventWarpPlayer", 0x30 },
        //    { "GcAtmosphereList", 0x10 },
        //    { "GcBiomeList", 0x24 },
        //    { "GcBiomeListPerStarType", 0xA0 },
        //    { "GcSolarSystemClass", 0x4 },
        //    { "GcPlanetClass", 0x4 },
        //    { "GcPlanetGenerationInputData", 0x40 },
        //    { "GcSpaceStationSpawnData", 0x140 },
        //    { "GcSolarSystemTraderSpawnData", 0x14 },
        //    { "GcSolarSystemLocator", 0x60 },
        //    { "GcAISpaceshipPreloadCacheData", 0x118 },
        //    { "GcAISpaceshipPreloadCacheDataTable", 0x10 },
        //    { "GcSolarSystemData", 0x1360 },
        //    { "GcTerrainControls", 0x70 },
        //    { "GcBiomeData", 0x410 },
        //    { "GcExternalObjectFileList", 0x38 },
        //    { "GcBiomeFileList", 0x4A0 },
        //    { "GcExternalObjectList", 0x50 },
        //    { "GcHeavyAirList", 0x10 },
        //    { "GcPlanetHazardData", 0x78 },
        //    { "GcPlanetWeatherColourData", 0xB0 },
        //    { "GcPlanetWeatherData", 0x200 },
        //    { "GcPlanetGenerationIntermediateData", 0x3C8 },
        //    { "GcPlanetInfo", 0x382 },
        //    { "GcPlanetSentinelData", 0x8 },
        //    { "GcPlanetData", 0x2EA0 },
        //    { "GcSpawnDensity", 0x20 },
        //    { "GcSpawnDensityList", 0x10 },
        //    { "GcWeatherColourSettingList", 0x10 },
        //    { "GcAISpaceshipComponentData", 0x20 },
        //    { "GcAISpaceshipInstanceData", 0x80 },
        //    { "GcAISpaceshipMappingData", 0x180 },
        //    { "GcAISpaceshipManagerData", 0x900 },
        //    { "GcAISpaceshipPreloadList", 0x18 },
        //    { "GcSpaceshipComponentData", 0x98 },
        //    { "GcDoShipFlybyClose", 0xC },
        //    { "GcDoShipFlybyIntercept", 0x8 },
        //    { "GcDoShipFlybyOverhead", 0x8 },
        //    { "GcWaypointComponentData", 0x84 },
        //    { "GcUserSettingsData", 0x18 },
        //    { "GcTestMetadata", 0x6B0 },
        //    { "TkAnimationData", 0xE0 },
        //    { "TkAnimationDataTable", 0x10 },
        //    { "TkAnimPoseCorrelationData", 0x28 },
        //    { "TkAnimPoseData", 0x18 },
        //    { "TkAnimPoseExampleElement", 0x18 },
        //    { "TkAnimPoseExampleData", 0x10 },
        //    { "TkAttachmentData", 0x10 },
        //    { "TkAnimationComponentData", 0xF0 },
        //    { "TkAnimPoseComponentData", 0xC8 },
        //    { "TkAudioAnimTrigger", 0x98 },
        //    { "TkAudioComponentData", 0x98 },
        //    { "TkDynamicChainComponentData", 0x48 },
        //    { "TkInstanceWindComponentData", 0x20 },
        //    { "TkPhysicsComponentData", 0x60 },
        //    { "TkResourceDescriptorData", 0xB8 },
        //    { "TkResourceDescriptorList", 0x20 },
        //    { "TkModelDescriptorList", 0x10 },
        //    { "TkProceduralInstanceData", 0x18 },
        //    { "TkProceduralModelComponentData", 0x10 },
        //    { "TkProceduralModelList", 0x20 },
        //    { "TkReferenceComponentData", 0x100 },
        //    { "TkRotationComponentData", 0x20 },
        //    { "TkEngineSettingTypes", 0x4 },
        //    { "TkEngineSettingsMapping", 0x30 },
        //    { "GcInputActions", 0x4 },
        //    { "GcInputActionMapping", 0x8 },
        //    { "TkGameSettings", 0xFC },
        //    { "TkGraphicsSettings", 0x44 },
        //    { "TkEntitlementList", 0x10 },
        //    { "TkNGuiWindowLayoutData", 0x198 },
        //    { "TkNGuiEditorLayout", 0x19800 },
        //    { "TkNGuiEditorStyleData", 0x110 },
        //    { "TkNGuiLayoutListData", 0x180 },
        //    { "TkNGuiLayoutList", 0x10 },
        //    { "TkRagdollData", 0x28 },
        //    { "TkAnimNodeData", 0x20 },
        //    { "TkAnimNodeFrameData", 0x30 },
        //    { "TkAnimMetadata", 0x58 },
        //    { "TkJointBindingData", 0x68 },
        //    { "TkJointExtentData", 0x30 },
        //    { "TkJointMirrorAxis", 0x2C },
        //    { "TkGeometryData", 0x120 },
        //    { "TkMaterialAlternative", 0x98 },
        //    { "TkMaterialFlags", 0x4 },
        //    { "TkMaterialUniform", 0x40 },
        //    { "TkMaterialData", 0x1D8 },
        //    { "TkSceneBoneRemapping", 0x100 },
        //    { "TkSceneBoneRemappingTable", 0x10 },
        //    { "TkSceneNodeAttributeData", 0x120 },
        //    { "TkTransformData", 0x24 },
        //    { "TkSceneNodeData", 0xD8 },
        //    { "TkBoundingBoxData", 0x20 },
        //    { "TkLanguageFontTableEntry", 0x184 },
        //    { "TkLanguageFontTable", 0x10 },
        //    { "TkLanguagesAllowedData", 0x18 },
        //    { "TkMetadataFilenameList", 0x10 },
        //    { "TkProbability", 0x4 },
        //    { "TkProceduralTexture", 0x1C0 },
        //    { "TkProceduralTextureLayer", 0x40 },
        //    { "TkProceduralTextureList", 0x200 },
        //    { "TkTrophyEntry", 0x58 },
        //    { "TkTrophyData", 0x10 },
        //    { "TkTrophyEnum", 0x4 },
        //    { "TkEmitterData", 0x80 },
        //    { "TkFoliageData", 0xB0 },
        //    { "TkHeavyAirData", 0x140 },
        //    { "TkHeavyAirCollection", 0x10 },
        //    { "TkHeavyAirSystem", 0x130 },
        //    { "TkIdSceneFilename", 0x90 },
        //    { "TkInputFrame", 0x1C },
        //    { "TkInputFrameArray", 0x88B80 },
        //    { "TkLSystemRestrictionData", 0x8 },
        //    { "TkLSystemGlobalRestriction", 0xB0 },
        //    { "TkLSystemGlobalVariation", 0xA4 },
        //    { "TkLSystemLocatorEntry", 0x98 },
        //    { "TkLSystemInnerRule", 0x38 },
        //    { "TkLSystemRule", 0xB8 },
        //    { "TkLSystemRuleTemplate", 0xA0 },
        //    { "TkLSystemRulesData", 0x40 },
        //    { "TkMaterialMetaData", 0x2A0 },
        //    { "TkParticleData", 0xC0 },
        //    { "TkPostProcessData", 0x28 },
        //    { "TkSpeedLineData", 0xE0 },
        //    { "TkTrailData", 0x40 },
        //    { "TkImGuiWindowData", 0xA8 },
        //    { "TkImGuiData", 0x59B8 },
        //    { "TkPlatformButtonPair", 0x28 },
        //    { "TkActionButtonMap", 0x28 },
        //    { "TkActionButtonLookup", 0x10 },
        //    { "TkButtonPathMapping", 0x90 },
        //    { "TkButtonImageLookup", 0x10 },
        //    { "TkControllerButtonLookup", 0x90 },
        //    { "TkControllerList", 0x10 },
        //    { "TkControllerSpecification", 0x20 },
        //    { "TkNoiseFlattenFixedPosition", 0x40 },
        //    { "TkVoxelGeneratorSettingsElement", 0x26A0 },
        //    { "TkVoxelGeneratorSettingsArray", 0x18240 },
        //    { "TkUserServiceAuthProvider", 0x4 },
        //    { "TkPhysicsData", 0x18 },
        //    { "TkNoiseVoxelTypeEnum", 0x4 },
        //    { "TkNoiseLayersEnum", 0x4 },
        //    { "TkNoiseUberData", 0x28 },
        //    { "TkNoiseOffsetEnum", 0x4 },
        //    { "TkNoiseUberLayerData", 0x68 },
        //    { "TkGridLayersEnum", 0x4 },
        //    { "TkNoiseSuperFormulaData", 0x10 },
        //    { "TkNoiseSuperPrimitiveData", 0x1C },
        //    { "TkNoiseGridData", 0x184 },
        //    { "TkFeaturesEnum", 0x4 },
        //    { "TkNoiseFeatureData", 0x40 },
        //    { "TkCavesEnum", 0x4 },
        //    { "TkNoiseCaveData", 0x84 },
        //    { "TkNoiseFlattenOptions", 0x8 },
        //    { "TkNoiseFlattenPoint", 0x28 },
        //    { "TkVoxelGeneratorRegionData", 0x50 },
        //    { "TkVoxelGeneratorData", 0x1350 },
        //    { "TkNoiseLayerData", 0x30 },
        //    { "TkLocalisationEntry", 0x120 },
        //    { "TkLocalisationTable", 0x10 },
        //    { "TkLanguages", 0x4 },
        //    { "TkMaterialSampler", 0xC8 },
        //    { "TkVertexElement", 0x20 },
        //    { "TkVertexLayout", 0x20 },
        //    { "GcDestroyAction", 0x1 },
        //    { "GcEngineComponentData", 0x4 },
        //    { "GcPlanetColourData", 0xBE0 },
        //    { "GcShieldComponentData", 0x4 },
        //    { "GcCostHealth", 0x4 },
        //    { "GcCostMoney", 0x4 },
        //    { "GcStyleProp_Font", 0x4 },
        //    { "GcTextStylePlain", 0x1 },
        //    { "GcRewardDestructRarities", 0xC },
        //    { "GcRewardTimeWarp", 0x1 },
        //    { "GcRewardEnergy", 0x4 },
        //    { "GcRewardShowBlackHoles", 0x1 },
        //    { "TkEngineSettings", 0x8 },
        //    { "GcHeavyAirSetting", 0xA0 },

        //    // taken from the globals MBIN loading funcs, might not be correct if the template contains lists (which seems unlikely as all the global loading funcs expect the file to be a fixed size)
        //    { "GcAISpaceshipGlobals", 0x8C0 },
        //    { "GcAtlasGlobals", 0x10 },
        //    { "GcAudioGlobals", 0xC4 },
        //    { "GcBuildingGlobals", 0x110 },
        //    { "GcCameraGlobals", 0x1500 },
        //    { "GcCreatureGlobals", 0x690 },
        //    { "GcDebugOptions", 0xCC0 },
        //    { "GcEnvironmentGlobals", 0x328 },
        //    { "GcGalaxyGlobals", 0xC10 },
        //    { "GcGameplayGlobals", 0xBD0 },
        //    { "GcGraphicsGlobals", 0x820 },
        //    { "GcPlacementGlobals", 0x30 },
        //    { "GcPlayerGlobals", 0x990 },
        //    { "GcRobotGlobals", 0x360 },
        //    { "GcSceneOptions", 0x2B0 },
        //    { "GcSimulationGlobals", 0x1988 },
        //    { "GcSkyGlobals", 0x890 },
        //    { "GcSmokeTestOptions", 0x28 },
        //    { "GcSolarGenerationGlobals", 0x180 },
        //    { "GcSpaceshipGlobals", 0x770 },
        //    { "GcTerrainGlobals", 0x80 },
        //    { "GcUIGlobals", 0x3DE0 },
        //    { "GcWaterGlobals", 0x1 },

        //    // special templates
        //    { "MBINHeader", 0x60 },

        //    { "NMSString0x10", 0x10 },
        //    { "NMSString0x20", 0x20 },
        //    { "NMSString0x80", 0x80 },
        //    { "NMSString0x100", 0x100 },

        //    { "Vector2f", 0x8 },
        //    { "Vector3i", 0xC },
        //    { "Vector4f", 0x10 },
        //    { "Colour", 0x10 },

        //    { "GcSeed", 0x10 },
        //};

        [ClassInitialize]
        public static void Initialize( TestContext context ) {
            RunSettings.Initialize( context );
        }

        private System.Version GetTableVersion() {
            System.Version version = new System.Version();
            foreach (var path in Directory.GetDirectories( Database.Utils.RootDirectory ) ) {
                System.Version v = new System.Version( Path.GetFileName( path ) );
                if ( v > version ) version = v;
            }
            return version;
        }

        private string GetTablePath() {
            return Path.Combine( Database.Utils.RootDirectory, GetTableVersion().ToString(), "TemplateSizes.tsv" );
        }

        [TestMethod, TestProperty( "Time", "Fast" )]
        public void TestTemplateSizes() {
            var table = new TemplateSizes.Table();
            using ( StreamReader streamIn = new StreamReader( GetTablePath() ) ) {
                table.Load( streamIn );
            }

            var doneTemplates = new List<string>();

            foreach (var record in table) {
                if ( !NMSTemplate.NMSTemplateMap.ContainsKey( record.TemplateName ) ) {
                    Debug.WriteLine( $"TestTemplateSizes: size 0x{record.TemplateSize:X} defined for missing template {record.TemplateName}!" );
                    continue;
                }

                int size = NMSTemplate.GetTemplateDataSize( record.TemplateName );
                Assert.AreEqual( record.TemplateSize, size, $"template {record.TemplateName} size 0x{record.TemplateSize:X} != 0x{size:X}" );
                doneTemplates.Add( record.TemplateName );
            }

            foreach (var template in NMSTemplate.NMSTemplateMap) {
                if (!doneTemplates.Contains( template.Key)) {
                    Debug.WriteLine($"TestTemplateSizes: no size defined for template {template.Key}!");
                }
            }
        }
    }
}
