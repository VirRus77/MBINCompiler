namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3F84727015F37E6, NameHash = 0x1C73992CC7DA5C9A)]
    public class GcAIShipWeapons : NMSTemplate
    {
        // size: 0x3
        public enum AIShipWeaponEnum {
            Projectile,
            Laser,
            MiningLaser
        }
        /* 0x0 */ public AIShipWeaponEnum AIShipWeapon;
    }
}
