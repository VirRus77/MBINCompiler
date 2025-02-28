using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x87C57E9FF7067A, NameHash = 0x3BC94060600296E8)]
    public class GcGalaxyGlobals : NMSTemplate
    {
        /* 0x0000 */ public bool NewStyleLookAtCamera;
        /* 0x0001 */ public bool GizmoOnHand;
        /* 0x0004 */ public Vector2f ClickToSelectIconOffset;
        /* 0x000C */ public float ClickToSelectIconScale;
        /* 0x0010 */ public float MenuRotateHmd;
        /* 0x0014 */ public float MenuOffsetHmd;
        /* 0x0018 */ public float MenuSideOffsetHmd;
        /* 0x001C */ public float MenuScaleHmd;
        /* 0x0020 */ public float MenuCursorRadiusHmd;
        /* 0x0024 */ public float HexStackOffsetX;
        /* 0x0028 */ public float HexStackOffsetXOdd;
        /* 0x002C */ public float HexStackOffsetY;
        /* 0x0030 */ public float HexMarkerWidth;
        /* 0x0034 */ public float HexMarkerRadius;
        /* 0x0038 */ public float HexMarkerRotation;
        /* 0x003C */ public float HexMarkerOuterWidth;
        /* 0x0040 */ public NMSString0x80 MarkerDefaultHex;
        /* 0x00C0 */ public float PathToTargetLineTimeFactor;
        /* 0x00C4 */ public float PathToTargetIndicatorTimeFactor;
        /* 0x00C8 */ public float PathUISelectionMultiplierPad;
        /* 0x00CC */ public float PathUISelectionMultiplierMouse;
        /* 0x00D0 */ public float PathUIConfirmSelectionMultiplier;
        /* 0x00D4 */ public float PathUISelectionMultiplierPushing;
        /* 0x00D8 */ public float PathUISelectionGenerosity;
        /* 0x00DC */ public float PathUISelectionMouseSmoothRate;
        /* 0x00E0 */ public float PathUISelectionMouseDeadZone;
        /* 0x00E4 */ public float PathUISelectionHandLineSelectAngle;
        /* 0x00E8 */ public float PathUISelectionHandSystemSelectAngle;
        /* 0x00EC */ public float PathUISelectionHandInvalidLength;
        /* 0x00F0 */ public int SolarInfoPanelWidth;
        /* 0x00F4 */ public int SolarInfoPanelHeight;
        /* 0x00F8 */ public float HandControlRotateSpeed;
        /* 0x00FC */ public float HandControlPitchSpeed;
        /* 0x0100 */ public float HandControlMoveSpeed;
        /* 0x0104 */ public float HandControlPointerLength;
        /* 0x0108 */ public float HandControlPointerLengthMini;
        /* 0x010C */ public float HandControlGizmoScale;
        /* 0x0110 */ public float HandControlMaxOffset;
        /* 0x0114 */ public float HandControlMoveBlendRate;
        /* 0x0118 */ public float HandControlRotateBlendRate;
        /* 0x011C */ public float HandControlFreeMoveMaxOffset;
        /* 0x0120 */ public float HandControlFreeMoveAngleOffset;
        /* 0x0124 */ public float HandControlDefaultOffset;
        /* 0x0128 */ public float HandControlWarpSelectAngle;
        /* 0x012C */ public float HandControlMinLockDistance;
        /* 0x0130 */ public float HandControlMaxLockDistance;
        /* 0x0134 */ public float HandTurnFactorMin;
        /* 0x0138 */ public float HandTurnFactorRange;
        /* 0x013C */ public float HandPitchFactorMin;
        /* 0x0140 */ public float HandPitchFactorRange;
        /* 0x0144 */ public float HandPitchMaxDistance;
        /* 0x0148 */ public float HandZoomFactorMin;
        /* 0x014C */ public float HandZoomFactorRange;
        /* 0x0150 */ public float HandControlZoomSpeed;
        /* 0x0160 */ public Colour HandGizmoColourAt;
        /* 0x0170 */ public Colour HandGizmoColourRight;
        /* 0x0180 */ public Colour HandGizmoColourUp;
        /* 0x0190 */ public Vector3f HandGizmoHeadOffset;
        /* 0x01A0 */ public float HandGizmoMinAlpha;
        /* 0x01A4 */ public float HandGizmoRadius;
        /* 0x01A8 */ public float HandGizmoLineThickness;
        /* 0x01AC */ public float HandGizmoInnerRadius;
        /* 0x01B0 */ public float HandGizmoInnerThickness;
        /* 0x01C0 */ public Colour HandGizmoColourInner;
        /* 0x01D0 */ public GcInWorldUIScreenData HandMenuOffset;
        /* 0x0200 */ public Vector2f SolarInfoPanelOffset;
        /* 0x0208 */ public Vector2f SolarInfoPanelLineOffset;
        /* 0x0210 */ public Vector2f SolarInfoPanelOffsetVR;
        /* 0x0218 */ public Vector2f SolarInfoPanelAlignment;
        /* 0x0220 */ public Vector2f SolarMarkerAlignmentVR;
        /* 0x0228 */ public Vector2f IntroLabelAlignmentVR;
        /* 0x0230 */ public Vector2f SolarMarkerOriginOffsetVR;
        /* 0x0238 */ public float SolarMarkerPanelScaleVR;
        /* 0x023C */ public float SolarInfoPanelScaleVR;
        /* 0x0240 */ public float SolarLabelScaleDistanceVR;
        /* 0x0244 */ public float PathUIWidth;
        /* 0x0248 */ public float StarPathUIWidth;
        /* 0x024C */ public float FadeGameOutTimeCentreJourney;
        /* 0x0250 */ public float FadeMapInTimeCentreJourney;
        /* 0x0254 */ public float PathUIAlpha;
        /* 0x0258 */ public float PathUIDotLength;
        /* 0x025C */ public float PathUIGapLength;
        /* 0x0260 */ public float PathUIHeight;
        /* 0x0264 */ public float PathUIXOffset;
        /* 0x0268 */ public float PathUIYOffset;
        /* 0x026C */ public float PathUISlotSpacing;
        /* 0x0270 */ public float PathUISlotRadiusInner;
        /* 0x0274 */ public float PathUISlotRadiusOuter;
        /* 0x0278 */ public float PathUISlotRadiusRing;
        /* 0x027C */ public float PathUISlotWidthRing;
        /* 0x0280 */ public float MarkerDropShadowSize;
        /* 0x0284 */ public float MarkerDropShadowMult;
        /* 0x0288 */ public float PlanetUIIconLargeScale;
        /* 0x028C */ public float PlanetUIIconMediumScale;
        /* 0x0290 */ public float PlanetUIIconSmallScale;
        /* 0x0294 */ public float ShowPopupAtCameraMinDistance;
        /* 0x0298 */ public float GalacticPathMaximumJumpDistanceLightyears;
        /* 0x029C */ public float GalacticPathPreferGuideStarsTillJump;
        /* 0x02A0 */ public float ShowUIHelpDuration;
        /* 0x02A4 */ public float SystemInfoPanelGeneralAlpha;
        /* 0x02A8 */ public TkCurveType MarkerPulseStartCurve;
        /* 0x02AC */ public TkCurveType MarkerPulseEndCurve;
        [NMS(Size = 0x7)]
        /* 0x02B0 */ public Colour[] GalacticWaypointDefaultColours;
        [NMS(Size = 0x7)]
        /* 0x0320 */ public Colour[] GalacticWaypointProtanopiaColours;
        [NMS(Size = 0x7)]
        /* 0x0390 */ public Colour[] GalacticWaypointDeuteranopiaColours;
        [NMS(Size = 0x7)]
        /* 0x0400 */ public Colour[] GalacticWaypointTritanopiaColours;
        [NMS(Size = 0x8)]
        /* 0x0470 */ public Colour[] RaceFilterDefaultColours;
        [NMS(Size = 0x8)]
        /* 0x04F0 */ public Colour[] RaceFilterProtanopiaColours;
        [NMS(Size = 0x8)]
        /* 0x0570 */ public Colour[] RaceFilterDeuteranopiaColours;
        [NMS(Size = 0x8)]
        /* 0x05F0 */ public Colour[] RaceFilterTritanopiaColours;
        [NMS(Size = 0x7)]
        /* 0x0670 */ public Colour[] EconomyFilterDefaultColours;
        [NMS(Size = 0x7)]
        /* 0x06E0 */ public Colour[] EconomyFilterProtanopiaColours;
        [NMS(Size = 0x7)]
        /* 0x0750 */ public Colour[] EconomyFilterDeuteranopiaColours;
        [NMS(Size = 0x7)]
        /* 0x07C0 */ public Colour[] EconomyFilterTritanopiaColours;
        [NMS(Size = 0x4)]
        /* 0x0830 */ public Colour[] ConflictFilterDefaultColours;
        [NMS(Size = 0x4)]
        /* 0x0870 */ public Colour[] ConflictFilterProtanopiaColours;
        [NMS(Size = 0x4)]
        /* 0x08B0 */ public Colour[] ConflictFilterDeuteranopiaColours;
        [NMS(Size = 0x4)]
        /* 0x08F0 */ public Colour[] ConflictFilterTritanopiaColours;
        [NMS(Size = 0x10)]
        /* 0x0930 */ public GcGalaxyMarkerSettings[] MarkerSettings;
        /* 0x1B30 */ public float IntroFadeInRate;
        /* 0x1B34 */ public float IntroTitleFadeTrigger;
        /* 0x1B38 */ public float IntroTitleHoldTime;
        /* 0x1B3C */ public float IntroFadeOutRate;
        /* 0x1B40 */ public float IntroCameraLookSmoothRate;
        /* 0x1B44 */ public float IntroTitleTextureScale;
        /* 0x1B48 */ public float TransitionTime;
        /* 0x1B4C */ public TkCurveType TransitionOutCurve;
        /* 0x1B50 */ public float FinalHoldTime;
        /* 0x1B54 */ public float FinalFadedTime;
        /* 0x1B58 */ public float FinalHoldTowardsCenterTime;
        /* 0x1B5C */ public float FinalFadeInRate;
        /* 0x1B60 */ public float FinalFadeOutRate;
        /* 0x1B64 */ public float FinalTransitionMaxSpeed;
        /* 0x1B68 */ public float FinalTransitionAcceleration;
        /* 0x1B6C */ public float FinalTransitionInterpolationValue;
        /* 0x1B70 */ public float EarlyStageMultiplier;
        /* 0x1B74 */ public float OffWorldDistance;
        /* 0x1B78 */ public float DistanceComputerScale;
        /* 0x1B7C */ public float PathRenderingSelectedStartAlpha;
        /* 0x1B80 */ public float PathRenderingSelectedEndAlpha;
        /* 0x1B84 */ public float PathRenderingSelectedStepAlpha;
        /* 0x1B88 */ public float PathRenderingUnselectedStartAlpha;
        /* 0x1B8C */ public float PathRenderingUnselectedEndAlpha;
        /* 0x1B90 */ public float PathRenderingUnselectedStepAlpha;
        /* 0x1B94 */ public float StarBlurMaxDistanceFromCamera;
        /* 0x1B98 */ public float StarBlurMaxBlurLength;
        /* 0x1B9C */ public float StarBlurSizeMultiplier;
        /* 0x1BA0 */ public float StarBlurLineWidth;
        /* 0x1BA4 */ public float StarBlurIntroMultiplier;
        /* 0x1BA8 */ public float AnostreakAlpha;
        /* 0x1BAC */ public TkCurveType AnostreakAlphaCurve;
        /* 0x1BB0 */ public TkCurveType AnostreakValueCurve;
        /* 0x1BC0 */ public GcGalaxyRenderAnostreakData AnostreakAway;
        /* 0x1BF0 */ public GcGalaxyRenderAnostreakData AnostreakFacing;
        /* 0x1C20 */ public float SelectionTreeAlpha;
        /* 0x1C30 */ public Colour SelectionTreeColour;
        /* 0x1C40 */ public Vector2f GoalDistanceRange;
        /* 0x1C50 */ public GcGalaxyStarColours BaseStarDefaultColours;
        /* 0x1C90 */ public GcGalaxyStarColours BaseStarProtanopiaColours;
        /* 0x1CD0 */ public GcGalaxyStarColours BaseStarDeuteranopiaColours;
        /* 0x1D10 */ public GcGalaxyStarColours BaseStarTritanopiaColours;
        /* 0x1D50 */ public GcGalaxyCameraData Camera;
        /* 0x1DBC */ public GcGalaxyAudioSetupData Audio;
        /* 0x1E00 */ public float FadeGameOutTime;
        /* 0x1E04 */ public float FadeMapInTime;
        /* 0x1E08 */ public float FadeMapOutTime;
        /* 0x1E0C */ public float FadeGameInTime;
        /* 0x1E10 */ public float LargeAreaColourScale;
        /* 0x1E20 */ public GcGalaxyRenderSetupData DefaultRenderSetup;
        /* 0x2170 */ public GcGalaxyGenerationSetupData DefaultGeneration;
        /* 0x22F0 */ public GcGalaxyRenderSetupData FinalAnimationRenderSetup;
        /* 0x2640 */ public GcGalaxyGenerationSetupData FinalAnimationGeneration;
        /* 0x27C0 */ public GcGalaxySolarSystemParams SolarSystemParameters;
    }
}
