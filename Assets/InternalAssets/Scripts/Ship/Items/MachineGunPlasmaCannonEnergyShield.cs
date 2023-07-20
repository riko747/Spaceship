using System.Collections.Generic;
using InternalAssets.Scripts.Other;
using InternalAssets.Scripts.Ship.Items.Bullets;

namespace InternalAssets.Scripts.Ship.Items
{
    public class MachineGunPlasmaCannonEnergyShield : Item, Interfaces.IWeapon
    {
        private int _counteringDamage;
        
        public int NumberOfBarrels { get; set; }
        public int RateOfFire { get; set; }
        public int SizeOfClip { get; set; }
        public int RechargeTime { get; set; }
        public IEnumerable<Interfaces.IAmmo> Ammo { get; set; }
        
        protected override void Init()
        {
            NumberOfBarrels = 2;
            EquipmentSlotType = Enums.EquipmentSlotType.Heavy;
            Ammo = new List<HybridAmmoBullet>();
        }

        public override void Upgrade()
        {
            throw new System.NotImplementedException();
        }
    }
}
