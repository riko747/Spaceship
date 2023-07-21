using InternalAssets.Scripts.Other;

namespace InternalAssets.Scripts.ShipLogic.Items.Bullets
{
    public class HybridAmmoBullet : Interfaces.IAmmo
    {
        public Enums.AmmoType AmmoType { get; set; }
        
        public void SetAmmoType(Enums.AmmoType ammoType) => AmmoType = ammoType;
    }
}
