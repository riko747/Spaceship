using InternalAssets.Scripts.Other;

namespace InternalAssets.Scripts.ShipLogic.Items.Bullets
{
    public class MachineGunBullet : Interfaces.IAmmo
    {
        private int _damage;
        public Enums.AmmoType AmmoType { get; set; }

        public void SetAmmoType(Enums.AmmoType ammoType) => AmmoType = ammoType;

    }
}
