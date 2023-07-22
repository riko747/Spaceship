using System.Collections.Generic;
using InternalAssets.Scripts.ShipLogic;
using InternalAssets.Scripts.ShipLogic.Turrets;
using InternalAssets.Scripts.UI;

namespace InternalAssets.Scripts.Other
{
    public static class Interfaces
    {
        public interface IUiSystem
        {
            CreateShipSlotUI GetCreateShipSlotUI();
            ModifyShipSlotUI GetModifyShipSlotUI();
        }
        
        public interface IShip
        {
            ShipData ShipData { get; set; }
            EquipmentManager EquipmentManager { get; set; }
            void DamageTheShip(int damageCount, bool isPlasmaCannon);
        }

        public interface IHealth
        {
            int GetCurrentHealth();
            void Init();
            void IncreaseTotalHealth(int healthPoints);
            void DecreaseCurrentHealth(int healthPoints);
        }

        public interface IUpgradeable
        {
            void Upgrade();
        }
        
        public interface IAmmo
        {
            Enums.AmmoType AmmoType { get; set; }
            void SetAmmoType(Enums.AmmoType ammoType);
        }

        public interface IWeapon
        {
            int NumberOfWeaponBarrels { get; set; }
            int RateOfWeaponFire { get; set; }
            int SizeOfWeaponClip { get; set; }
            int WeaponRechargeTime { get; set; }
            IEnumerable<IAmmo> Ammo { get; set; }
        }
    }
}
