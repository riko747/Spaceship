using System.Collections.Generic;
using InternalAssets.Scripts.Other;
using InternalAssets.Scripts.Ship.Items.Bullets;

namespace InternalAssets.Scripts.Ship.Items.Weapons
{
    public class MachineGun : Item, Interfaces.IWeapon
    {
        public int NumberOfBarrels { get; set; }
        public int RateOfFire { get; set; }
        public int SizeOfClip { get; set; }
        public int RechargeTime { get; set; }
        public IEnumerable<Interfaces.IAmmo> Ammo { get; set; }
        
        protected override void Init()
        {
            NumberOfBarrels = 1;
            EquipmentSlotType = Enums.EquipmentSlotType.Light;
            Ammo = new List<MachineGunBullet>();
        }

        public override void Upgrade()
        {
            
        }
        
    }
}
