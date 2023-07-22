using InternalAssets.Scripts.Other;

namespace InternalAssets.Scripts.ShipLogic.Items.Bullets
{
    public class PlasmaCannonRay : Interfaces.IAmmo
    {
        private int _shotRange;
        public Enums.AmmoType AmmoType { get; set; }
        public void SetAmmoType(Enums.AmmoType ammoType) => AmmoType = ammoType;
    }
}
