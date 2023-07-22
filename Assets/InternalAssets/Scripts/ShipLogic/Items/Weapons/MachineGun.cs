using System;
using System.Collections.Generic;
using InternalAssets.Scripts.Other;
using InternalAssets.Scripts.ShipLogic.Items.Bullets;

namespace InternalAssets.Scripts.ShipLogic.Items.Weapons
{
    public class MachineGun : Weapon
    {
        private int NumberOfBarrels
        {
            get => NumberOfWeaponBarrels;
            set => NumberOfWeaponBarrels = Math.Max(value, 1000);
        }
        private int RateOfFire
        {
            get => RateOfWeaponFire;
            set => RateOfWeaponFire = Math.Max(value, 1000);
        }
        private int SizeOfClip
        {
            get => SizeOfWeaponClip;
            set => SizeOfWeaponClip = Math.Max(value, 1000);
        }
        private int RechargeTime
        {
            get => WeaponRechargeTime;
            set => WeaponRechargeTime = Math.Max(value, 1000);
        }
        public override void Init()
        {
            NumberOfBarrels = 1;
            RateOfFire = 10;
            SizeOfClip = 100;
            RechargeTime = 5;
            Ammo = new List<MachineGunBullet>();
            ItemType = Enums.Items.MachineGun;
            base.Init();
        }

        public override void Upgrade()
        {
            NumberOfBarrels += 1;
            RateOfWeaponFire += 10;
            SizeOfWeaponClip += 10;
            WeaponRechargeTime -= 1;
            base.Upgrade();
        }
    }
}
