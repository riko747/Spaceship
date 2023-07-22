using System.Collections.Generic;
using InternalAssets.Scripts.ShipLogic.Turrets;
using InternalAssets.Scripts.UI;

namespace InternalAssets.Scripts.Other
{
    public static class Interfaces
    {
        public interface IUpgradeableInterfaceManager
        {
            void AddUpgradeable(IUpgradeable currentInterface);
            List<Interfaces.IUpgradeable> GetAllUpgradeables();
        }
        
        public interface IUiSystem
        {
            CreateShipSlotUI GetCreateShipSlotUI();
            ModifyShipSlotUI GetModifyShipSlotUI();
        }
        
        public interface IShip
        {
            EquipmentManager EquipmentManager { get; set; }
            void DamageTheShip(int damageCount);
        }

        public interface IHealth
        {
            int GetHealth();
            void Init();
            void IncreaseHealth(int healthPoints);
            void DecreaseHealth(int healthPoints);
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
            int NumberOfWeaponBarrels { get; set; }
            int RateOfWeaponFire { get; set; }
            int SizeOfWeaponClip { get; set; }
            int WeaponRechargeTime { get; set; }
            IEnumerable<Interfaces.IAmmo> Ammo { get; set; }
        }
    }
}
