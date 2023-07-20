using System.Collections.Generic;

namespace InternalAssets.Scripts.Other
{
    public static class Interfaces
    {
        public interface IUISystem
        {
            
        }
        
        public interface IHealth
        {
            public int GetHealth();
            public void IncreaseHealth(int healthPoints);
            public void DecreaseHealth(int healthPoints);
        }

        public interface IUpgradeable
        {
            abstract void Upgrade();
        }
        
        public interface IAmmo
        {
            Enums.AmmoType AmmoType { get; set; }
            void SetAmmoType(Enums.AmmoType ammoType);
        }

        public interface IWeapon
        {
            int NumberOfBarrels { get; set; }
            int RateOfFire { get; set; }
            int SizeOfClip { get; set; }
            int RechargeTime { get; set; }
            IEnumerable<Interfaces.IAmmo> Ammo { get; set; }
        }
    }
}
