using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x17E4E61BE53C7749, NameHash = 0x9904F7D363A81377)]
    public class GcCharacterGlobals : NMSTemplate
    {
        /* 0x000 */ public float PitchTest;
        /* 0x004 */ public float RollTest;
        /* 0x008 */ public float WaterEffectHeightOffset;
        /* 0x00C */ public float WaterEffectHeightRange;
        /* 0x010 */ public float WaterEffectFadeSpring;
        /* 0x014 */ public float WaterEffectSpeedFade;
        /* 0x018 */ public float WaterEffectSpeedFadeMin;
        /* 0x01C */ public float WaterEffectSpeedOffset;
        /* 0x020 */ public float WaterEffectMinScale;
        /* 0x024 */ public float WaterEffectSideOffset;
        /* 0x028 */ public float WaterEffectRearOffset;
        /* 0x02C */ public float WaterEffectRearBackOffset;
        /* 0x030 */ public float CharacterRotationOffsetY;
        /* 0x034 */ public float CharacterRoughHeadHeight;
        /* 0x038 */ public NMSString0x80 CharacterFile;
        /* 0x0B8 */ public GcSeed CharacterSeedOverride;
        /* 0x0C8 */ public float DontShowCharacterWithinCameraDistance;
        /* 0x0CC */ public float CharacterTurnSpeed;
        /* 0x0D0 */ public float CharacterRunTurnSpeed;
        /* 0x0D4 */ public float CharacterJetpackTurnSpeed;
        /* 0x0D8 */ public float CharacterJetpackTurnAimSpeed;
        /* 0x0DC */ public float CharacterTurnAimSpeed;
        /* 0x0E0 */ public float CharacterSwimmingTurnSpeed;
        /* 0x0E4 */ public float CharacterSwimmingTurnAimSpeed;
        /* 0x0E8 */ public float RocketBootsLandedTurnSpeed;
        /* 0x0EC */ public float RocketBootsTurnSpeed;
        /* 0x0F0 */ public float FeetShiftOnTurnSpeed;
        /* 0x0F4 */ public float FeetShiftOnTurnMaxSpeed;
        /* 0x0F8 */ public float MinTurnAngle;
        /* 0x0FC */ public float YawPullSpeed;
        /* 0x100 */ public float GunRotationSpeed;
        /* 0x104 */ public float AimPitchAnimScale;
        /* 0x108 */ public float AimYawAnimScale;
        /* 0x10C */ public float AimPitchInterpSpeed;
        /* 0x110 */ public float MinSwimmingPitchRotation;
        /* 0x114 */ public float MaxSwimmingPitchRotation;
        /* 0x118 */ public float JetpackSwimmingPitchRotation;
        /* 0x11C */ public float MinSwimmingRollRotation;
        /* 0x120 */ public float MaxSwimmingRollRotation;
        /* 0x124 */ public float SwimmingSmoothTime;
        /* 0x128 */ public float SwimmingSmoothTimeWithWeapon;
        /* 0x12C */ public float SwimmingRollSmoothTime;
        /* 0x130 */ public float SwimmingRollSmoothTimeWithWeapon;
        /* 0x134 */ public float LadderDistanceToAutoMount;
        /* 0x138 */ public float LadderCooldownAfterBeforeAutoClimb;
        /* 0x140 */ public NMSString0x10 LadderClimbIdle;
        /* 0x150 */ public NMSString0x10 LadderClimbUp;
        /* 0x160 */ public NMSString0x10 LadderClimbDown;
        /* 0x170 */ public NMSString0x10 LadderMountBottom;
        /* 0x180 */ public NMSString0x10 LadderDismountBottom;
        /* 0x190 */ public NMSString0x10 LadderMountTop;
        /* 0x1A0 */ public NMSString0x10 LadderDismountTop;
        /* 0x1B0 */ public float SlopeAngleForUphillClimb;
        /* 0x1B4 */ public float SlopeAngleForDownhillClimb;
        /* 0x1B8 */ public float SlidingBrake;
        /* 0x1BC */ public float SlopeAngleForSlide;
        /* 0x1C0 */ public float UphillSpeedMultiplier;
        /* 0x1C4 */ public float TrudgeUphillSpeed;
        /* 0x1C8 */ public float MaxAnkleRotationAngle;
        /* 0x1CC */ public float RotateToFaceSlopeSpeed;
        /* 0x1D0 */ public float TimeNotOnGroundToBeConsideredInAir;
        /* 0x1D4 */ public float TimeNotOnGroundToUseFallingCamera;
        /* 0x1D8 */ public float TimeFallingUntilPanic;
        /* 0x1DC */ public float BankingMinimumSpeed;
        /* 0x1E0 */ public float BankingMaxStrength;
        /* 0x1E4 */ public float BankingSpeedForMaxStrength;
        /* 0x1E8 */ public float MinimumIdleToJogAnimSpeed;
        /* 0x1EC */ public float RootedAnimInterpolationTime;
        /* 0x1F0 */ public float IKLegStretchStrength;
        /* 0x1F4 */ public float IkBlendStrengthSpeed;
        /* 0x1F8 */ public float FootPlantedTolerance;
        /* 0x1FC */ public float FootPlantSpring;
        /* 0x200 */ public float BlendToNewFeetSpeed;
        /* 0x204 */ public float TimeAfterDeathRagdollIsEnabledForward;
        /* 0x208 */ public float TimeAfterDeathRagdollIsEnabledBackward;
        /* 0x20C */ public float TimeAfterDeathRagdollIsEnabledWhenBlocked;
        /* 0x210 */ public float RagdollTau;
        /* 0x214 */ public float RagdollDamping;
        /* 0x218 */ public float RagdollConeLimit;
        /* 0x21C */ public float RagdollTwistLimit;
        /* 0x220 */ public float RagdollMotorFadeStart;
        /* 0x224 */ public float RagdollMotorFadeEnd;
        /* 0x228 */ public float MinStickForIntoJogAnim;
        /* 0x22C */ public float SmoothVelocitySpeed;
        /* 0x230 */ public float TimeToShowSplashEffect;
        /* 0x234 */ public float UnderwaterToAirTolerance;
        /* 0x238 */ public float WaterBottomSmoothPushUp;
        /* 0x23C */ public float WaterBottomSmoothPushUpDepth;
        /* 0x240 */ public float SitPostureChangeTimeMin;
        /* 0x244 */ public float SitPostureChangeTimeMax;
        /* 0x248 */ public bool NPCUseBehaviourTree;
        /* 0x249 */ public bool NPCLightsAlwaysOn;
        /* 0x24C */ public GcNPCPropType NPCForceProp;
        /* 0x250 */ public float NPCPropScaleTime;
        /* 0x254 */ public float NPCReactionChance;
        /* 0x258 */ public float NPCReactCooldown;
        /* 0x25C */ public float NPCIKBodyWeightNormalGek;
        /* 0x260 */ public float NPCIKBodyWeightNormal;
        /* 0x264 */ public float NPCIKBodyWeightSeated;
        /* 0x268 */ public float NPCSpineAdjustGek;
        /* 0x26C */ public float NPCSpineAdjustVykeen;
        /* 0x270 */ public float NPCAnimSpeedMin;
        /* 0x274 */ public float NPCAnimSpeedMax;
        /* 0x278 */ public float NPCBehaviourTimeModifier;
        /* 0x27C */ public bool NPCBehaviourInfo;
        /* 0x280 */ public float NPCStaticDistance;
        /* 0x284 */ public float NPCStaticTimeUntilFail;
        /* 0x288 */ public float NPCPermittedNavigationDelayFactor;
        /* 0x28C */ public int NPCNumNavFailuresUntilNoPhysFallback;
        /* 0x290 */ public float NPCWalkSpeedMech;
        /* 0x294 */ public float NPCWalkSpeed;
        /* 0x298 */ public float NPCWalkSpeedGek;
        /* 0x29C */ public float NPCRunSpeed;
        /* 0x2A0 */ public float NPCRunSpeedGek;
        /* 0x2A4 */ public float NPCArriveDist;
        /* 0x2A8 */ public float NPCIncreasedSteeringDist;
        /* 0x2AC */ public float NPCMinTurnSpeed;
        /* 0x2B0 */ public float NPCMaxTurnSpeed;
        /* 0x2B4 */ public float NPCMinTurnSpeedMech;
        /* 0x2B8 */ public float NPCDecelerateStrength;
        /* 0x2BC */ public float NPCStaticTurnTime;
        /* 0x2C0 */ public float NPCTeleportEffectTime;
        /* 0x2C4 */ public float NPCMinStaticTurnAngle;
        /* 0x2C8 */ public float NPCFastStaticTurnAngle;
        /* 0x2CC */ public float NPCSlowStaticTurnAngle;
        /* 0x2D0 */ public float NPCMaxStaticTurnSpeed;
        /* 0x2D4 */ public float NPCActiveListenChance;
        /* 0x2D8 */ public float NPCLookAtThingChance;
        /* 0x2DC */ public float NPCLookAtThingTimeMin;
        /* 0x2E0 */ public float NPCLookAtThingTimeMax;
        /* 0x2E4 */ public float NPCLookAwayTimeMin;
        /* 0x2E8 */ public float NPCLookAwayTimeMax;
        /* 0x2EC */ public float NPCMaxLookAtAngleMoving;
        /* 0x2F0 */ public float NPCMaxLookAtAngleStatic;
        /* 0x2F4 */ public float NPCLookAtTerminateAngle;
        /* 0x2F8 */ public float NPCSeatedLookAtLateralReduction;
        /* 0x2FC */ public float NPCMinInteractionSearchDist;
        /* 0x300 */ public float NPCMaxInteractionSearchDist;
        /* 0x304 */ public float NPCMaxFreighterInteractionSearchDist;
        /* 0x308 */ public float NPCMaxSettlementInteractionSearchDist;
        /* 0x30C */ public float NPCSteeringSpringTime;
        /* 0x310 */ public float NPCPerceptionRadius;
        /* 0x314 */ public float NPCSteeringObstacleAvoidStrength;
        /* 0x318 */ public float NPCSteeringFollowStrength;
        /* 0x31C */ public float NPCSteeringAvoidStrength;
        /* 0x320 */ public float NPCSteeringRadius;
        /* 0x324 */ public float NPCSteeringRepelDist;
        /* 0x328 */ public float NPCSteeringComingTowardsDegrees;
        /* 0x32C */ public float NPCSteeringCollisionAvoidAngle;
        /* 0x330 */ public float NPCSteeringCollisionAvoidStrength;
        /* 0x334 */ public float NPCSteeringRaySpread;
        /* 0x338 */ public float NPCSteeringRayLength;
        /* 0x33C */ public float NPCSteeringRaySphereSize;
        /* 0x340 */ public float NPCMaxRandomNavPathMinIndoorOffset;
        /* 0x344 */ public float NPCMaxRandomNavPathMaxIndoorOffset;
        /* 0x348 */ public float NPCMaxRandomNavPathMinOutdoorOffset;
        /* 0x34C */ public float NPCMaxRandomNavPathMaxOutdoorOffset;
        /* 0x350 */ public float NPCBlockedDestRadius;
        /* 0x354 */ public float NPCFlavourIdleTimeMin;
        /* 0x358 */ public float NPCFlavourIdleTimeMax;
        /* 0x35C */ public float NPCMoodIdleDelayChance;
        /* 0x360 */ public float NPCMoodIdleLowIntensityChance;
        /* 0x364 */ public float NPCReactToPlayerPresenceDist;
        /* 0x368 */ public float NPCReactToPlayerPresenceIndividualCooldown;
        /* 0x36C */ public float NPCReactToPlayerPresenceGloablCooldown;
        /* 0x370 */ public float NPCReactToPlayerPresenceStaticTimer;
        /* 0x374 */ public float NPCDisplayThoughtsMaxDuration;
        /* 0x378 */ public float NPCDisplayThoughtsMaxDistance;
        /* 0x37C */ public float NPCDisplayThoughtsRefreshInterval;
        /* 0x380 */ public float NPCDisplayThoughtsProbability;
        /* 0x384 */ public float NPCPOISelectionNearbyNPCBaseMultiplier;
    }
}
