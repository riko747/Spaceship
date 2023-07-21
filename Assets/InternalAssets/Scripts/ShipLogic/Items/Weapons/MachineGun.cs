using System.Collections.Generic;
using InternalAssets.Scripts.Other;
using InternalAssets.Scripts.ShipLogic.Items.Bullets;

namespace InternalAssets.Scripts.ShipLogic.Items.Weapons
{
    public class MachineGun : Item, Interfaces.IWeapon
    {
        public int NumberOfBarrels { get; set; }
        public int RateOfFire { get; set; }
        public int SizeOfClip { get; set; }
        public int RechargeTime { get; set; }
        public IEnumerable<Interfaces.IAmmo> Ammo { get; set; }
        
        protected virtual void Init()
        {
            NumberOfBarrels = 1;
            Ammo = new List<MachineGunBullet>();
        }

        public override void Upgrade()
        {
            
        }
        
    }
}
