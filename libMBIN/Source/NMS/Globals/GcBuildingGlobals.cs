using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x229E9AC00C1BF683, NameHash = 0xCFD86CFD7BD870B1)]
    public class GcBuildingGlobals : NMSTemplate
    {
        /* 0x0000 */ public Vector3f BuildingPartPreviewOffset;
        /* 0x0010 */ public float BuildingPlacementEffectInterpRate;
        /* 0x0014 */ public float BuildingPlacementEffectInterpRateSlow;
        /* 0x0018 */ public float BuildingPlacementEffectPreviewInterpTime;
        /* 0x001C */ public float BuildingPlacementEffectPostPreviewInterpTime;
        /* 0x0020 */ public float BuildingPlacementEffectSpringSlow;
        /* 0x0024 */ public float BuildingPlacementEffectSpringFast;
        /* 0x0028 */ public float BuildingPartPreviewRadius;
        /* 0x002C */ public float BuildingPartPreviewPitch;
        /* 0x0030 */ public float BuildingPartPreviewRotateSpeed;
        [NMS(Size = 0x4, EnumType = typeof(TkGraphicsDetailTypes.GraphicDetailEnum))]
        /* 0x0034 */ public TkLODDistances[] ActiveLodDistances;
        [NMS(Size = 0x4, EnumType = typeof(TkGraphicsDetailTypes.GraphicDetailEnum))]
        /* 0x0084 */ public TkLODDistances[] InactiveLodDistances;
        /* 0x00D4 */ public TkTextureResource ScreenSpaceRotationIcon;
        /* 0x0158 */ public TkTextureResource ScreenSpaceRotationGlow;
        [NMS(Size = 0x10, EnumType = typeof(GcBuildMenuOption.BuildMenuOptionEnum))]
        /* 0x01DC */ public GcBuildMenuIconSet[] Icons;
        /* 0x125C */ public float PowerlineSnapDistance;
        /* 0x1260 */ public float HologramDistanceMultiplier;
        /* 0x1264 */ public float HologramDistanceMultiplierAlt;
        /* 0x1268 */ public bool AllowBuildingUsingIntermediates;
        /* 0x126C */ public float BuildingWaterMargin;
        /* 0x1270 */ public float BuildingLineAlphaEnd0;
        /* 0x1274 */ public float BuildingLineAlphaEnd1;
        /* 0x1278 */ public float BuildingLineAlphaStart;
        /* 0x127C */ public float BuildingLineWidth;
        /* 0x1280 */ public float BuildingLineMoveSpeed;
        /* 0x1284 */ public float BuildingLineResetTime;
        /* 0x1288 */ public float BuildingLineOBBShrink;
        /* 0x128C */ public float BuildingLineProjectorWidth;
        /* 0x1290 */ public float BuildingLineProjectorLength;
        /* 0x1294 */ public int BuildingLineCount;
        /* 0x1298 */ public float IconSpringTime;
        /* 0x129C */ public float HoverFadeAlpha;
        /* 0x12A0 */ public float HoverTime;
        /* 0x12A4 */ public float HoverVisibilityTime;
        /* 0x12A8 */ public float HoverFadeTime;
        /* 0x12AC */ public float HoverMinToStayActiveTime;
        /* 0x12B0 */ public float HoverStayActiveTime;
        /* 0x12B4 */ public float HoverLockedInitTime;
        /* 0x12B8 */ public float HoverLockedActiveTime;
        /* 0x12BC */ public float HoverLockedIconScale;
        /* 0x12C0 */ public float HoverInactiveSize;
        /* 0x12C4 */ public float HoverFadeAlphaHmd;
        /* 0x12C8 */ public float HoverTimeHmd;
        /* 0x12CC */ public float HoverVisibilityTimeHmd;
        /* 0x12D0 */ public float HoverFadeTimeHmd;
        /* 0x12D4 */ public float HoverMinToStayActiveTimeHmd;
        /* 0x12D8 */ public float HoverStayActiveTimeHmd;
        /* 0x12DC */ public float HoverLockedInitTimeHmd;
        /* 0x12E0 */ public float HoverLockedActiveTimeHmd;
        /* 0x12E4 */ public float HoverLockedIconScaleHmd;
        /* 0x12E8 */ public float HoverInactiveSizeHmd;
        /* 0x12EC */ public float LineMinDistance;
        /* 0x12F0 */ public float LineDistanceRange;
        /* 0x12F4 */ public float MaxLineLength;
        /* 0x12F8 */ public float MinLineLength;
        /* 0x12FC */ public float MinLineLengthShip;
        /* 0x1300 */ public float HeightDiffLineAdjustMin;
        /* 0x1304 */ public float HeightDiffLineAdjustMax;
        /* 0x1308 */ public float HeightDiffLineAdjustFactor;
        /* 0x130C */ public TkCurveType LineCurve;
        /* 0x1310 */ public float BuildingYOffset;
        /* 0x1314 */ public float InteractMarkerYOffset;
        /* 0x1318 */ public float MinRadius;
        /* 0x131C */ public float RadiusMultiplier_DoNotPlace;
        /* 0x1320 */ public float RadiusMultiplier_DoNotPlaceClose;
        /* 0x1324 */ public float RadiusMultiplier_DoNotPlaceAnywhereNear;
        /* 0x1328 */ public float RadiusMultiplier_OnlyPlaceAround;
        /* 0x132C */ public float ObjectFadeRadius;
        /* 0x1330 */ public float AddToRadius_DoNotPlaceClose;
        /* 0x1334 */ public float Radius_DoNotPlaceAnywhereNear;
        /* 0x1338 */ public float ChanceOfAddingShelter;
        /* 0x133C */ public float SectorMessageReshowDistance;
        /* 0x1340 */ public float SectorMessageCenterDistance;
        /* 0x1344 */ public float SectorMessageMinTime;
        /* 0x1348 */ public float MinTimeBetweenBuildingEntryMessage;
        /* 0x134C */ public float MinTimeBetweenBuildingEntryMessageBase;
        /* 0x1350 */ public float FadeStart;
        /* 0x1354 */ public float FadeDistance;
        /* 0x1358 */ public float NearMinAlpha;
        /* 0x135C */ public float MinAlpha;
        /* 0x1360 */ public float LineScaleFactor;
        /* 0x1364 */ public float BuildingNearDistance;
        /* 0x1368 */ public float BuildingNearArcDistance;
        /* 0x136C */ public float BuildingVisitDistance;
        /* 0x1370 */ public float NearMaxLineLength;
        /* 0x1374 */ public float NearMinLineLength;
        /* 0x1378 */ public float NearLineScaleFactor;
        /* 0x137C */ public float MinElevatedHeight;
        /* 0x1380 */ public float MaxLowHeight;
        /* 0x1384 */ public float TextStringXOffset;
        /* 0x1388 */ public float TextTagXOffset;
        /* 0x138C */ public float TextTagYOffset;
        /* 0x1390 */ public float TextTagWidthOffset;
        /* 0x1394 */ public float DistanceTextXOffset;
        /* 0x1398 */ public float DistanceTagXOffset;
        /* 0x139C */ public float TextTagLength;
        /* 0x13A0 */ public float DistanceForVisited;
        /* 0x13A4 */ public float DistanceForTooltip;
        /* 0x13A8 */ public float SmallIconSize;
        /* 0x13AC */ public float LargeIconSize;
        /* 0x13B0 */ public float LargeIconArrowOffset;
        /* 0x13B4 */ public float CompassIconSize;
        /* 0x13B8 */ public float SmallIconArrowOffset;
        /* 0x13BC */ public float SpaceMarkerOffset;
        /* 0x13C0 */ public float SpaceMarkerOffsetPlanet;
        /* 0x13C4 */ public float SpaceMarkerOffsetSamePlanet;
        /* 0x13C8 */ public float MarkerLineWidth;
        /* 0x13D0 */ public Colour MarkerLineColour;
        /* 0x13E0 */ public float AmountToMoveMarkerRoundSphere;
        /* 0x13E4 */ public float MarkerTransitionDistance;
        /* 0x13E8 */ public float SpaceMarkerMinHeight;
        /* 0x13EC */ public float SpaceMarkerMaxHeight;
        /* 0x13F0 */ public float MaxTimeBetweenEvents;
        /* 0x13F4 */ public float ShowTimeNotDistance;
        /* 0x13F8 */ public float UnknownBuildingRange;
        /* 0x13FC */ public float MaxIconRange;
        /* 0x1400 */ public float MarkerTimeIncrease;
        /* 0x1404 */ public float FlyingBuildingIconTime;
        /* 0x1408 */ public int MinShipScanBuildings;
        /* 0x140C */ public int MaxShipScanBuildings;
        /* 0x1410 */ public float TestDistanceForSettlementBaseBufferAlignment;
        /* 0x1414 */ public float MinRadiusForBases;
        /* 0x1418 */ public float BaseRadiusExtension;
        /* 0x141C */ public float MaxRadiusForPlanetBases;
        /* 0x1420 */ public float MaxRadiusForSpaceBases;
        /* 0x1424 */ public float MinRadiusFromFeaturedBases;
        /* 0x1428 */ public float BuildingPlacementMaxConnectionLength;
        /* 0x142C */ public float BuildingPlacementMaxDistance;
        /* 0x1430 */ public float BuildingPlacementMaxDistanceNoHit;
        /* 0x1434 */ public float BuildingPlacementMaxDistanceNoHitExtra;
        /* 0x1438 */ public float BuildingPlacementMaxDistanceScaleExtraMinSize;
        /* 0x143C */ public float BuildingPlacementMaxDistanceScaleExtraMaxSize;
        /* 0x1440 */ public float BuildingPlacementMaxDistanceScaleExtra;
        /* 0x1444 */ public float BuildingPlacementCursorOffset;
        /* 0x1448 */ public float BuildingPlacementDefaultMinDistance;
        /* 0x144C */ public float BuildingPlacementMinDistanceScaleIncrease;
        /* 0x1450 */ public float BuildingPlacementDefaultMinDistanceVR;
        /* 0x1454 */ public float BuildingPlacementMinDistanceScaleIncreaseVR;
        /* 0x1458 */ public float BuildingPlacementNumGhostsMinOffset;
        /* 0x145C */ public float BuildingPlacementNumGhostsVolume;
        /* 0x1460 */ public float BuildingPlacementGhostHearScaleDistanceMod;
        /* 0x1464 */ public float BuildingPlacementGhostHeartSizeScaleMin;
        /* 0x1468 */ public float BuildingPlacementGhostHeartSizeScale;
        /* 0x146C */ public float BuildingPlacementGhostHeartSizeSelected;
        /* 0x1470 */ public TkCurveType BuildingPlacementGhostHeartSizeCurve;
        /* 0x1474 */ public float BuildingPlacementGhostHeartWiringSizeOtherSnapped;
        /* 0x1478 */ public float BuildingPlacementGhostHeartWiringSizeScaleMin;
        /* 0x147C */ public float BuildingPlacementGhostHeartWiringSizeScale;
        /* 0x1480 */ public float BuildingPlacementTwistScale;
        /* 0x1484 */ public float BuildingPlacementConeStartRadius;
        /* 0x1488 */ public float BuildingPlacementConeEndRadius;
        /* 0x148C */ public float BuildingPlacementConeEndDistance;
        /* 0x1490 */ public float BuildingPlacementConeStartRadiusIndoors;
        /* 0x1494 */ public float BuildingPlacementConeEndRadiusIndoors;
        /* 0x1498 */ public float BuildingPlacementConeEndDistanceIndoors;
        /* 0x149C */ public bool BuildingPlacementEffectEnabled;
        /* 0x14A0 */ public float BuildingPlacementEffectDissolveSpeed;
        /* 0x14A4 */ public float BuildingPlacementEffectFadeWaitTime;
        /* 0x14A8 */ public float BuildingPlacementEffectCrossFadeTime;
        /* 0x14AC */ public float BuildingPlacementEffectHidePlaceholderFadeTime;
        /* 0x14B0 */ public float BuildingPlacementEffectHidePlaceholderDistance;
        /* 0x14B4 */ public Vector2f BuildingPlacementScaleMinMax;
        /* 0x14BC */ public float InactiveVisibleComplexityFactor;
        /* 0x14C0 */ public bool DebugForceShowInactives;
        [NMS(Size = 0x4, EnumType = typeof(TkGraphicsDetailTypes.GraphicDetailEnum))]
        /* 0x14C4 */ public float[] TotalPlanetFrameTimeForComplexity;
        [NMS(Size = 0x4, EnumType = typeof(TkGraphicsDetailTypes.GraphicDetailEnum))]
        /* 0x14D4 */ public float[] TotalSpaceFrameTimeForComplexity;
        /* 0x14E4 */ public float MinPercentageNodesBufferFree;
        /* 0x14E8 */ public float MinLoadingPercentageNodesBufferFree;
        /* 0x14EC */ public float PercentagePhysicsComponentsForComplexity;
        /* 0x14F0 */ public float MaximumComplexityDensity;
        /* 0x14F4 */ public float ComplexityDensityTestRange;
        /* 0x14F8 */ public float ComplexityDensitySigmaSquared;
        /* 0x14FC */ public float StartCrashSiteMinDistance;
        /* 0x1500 */ public float StartCrashSiteMaxDistance;
        /* 0x1504 */ public float StartShelterMinDistance;
        /* 0x1508 */ public float StartShelterMaxDistance;
        /* 0x150C */ public NMSString0x80 FreighterBaseSpawnOverride;
        /* 0x158C */ public bool BaseBuildingTerrainEditBoundsOverride;
        /* 0x1590 */ public float BaseBuildingTerrainEditBaseYOffset;
        /* 0x1594 */ public float BaseBuildingTerrainEditTopYOffset;
        /* 0x1598 */ public float BaseBuildingTerrainEditBoundsScalar;
        /* 0x159C */ public bool BaseBuildingCamEnabled;
        /* 0x15A0 */ public float BaseBuildingWiringSnappingScaleFactorEasy;
        /* 0x15A4 */ public float BaseBuildingWiringSnappingScaleFactorHard;
    }
}
