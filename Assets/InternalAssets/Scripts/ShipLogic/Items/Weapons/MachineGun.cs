using System;
using System.Collections.Generic;
using InternalAssets.Scripts.Other;
using InternalAssets.Scripts.ShipLogic.Items.Bullets;

namespace InternalAssets.Scripts.ShipLogic.Items.Weapons
{
    public class MachineGun : Weapon
    {
        public override void Init()
        {
            NumberOfWeaponBarrels = 1;
            RateOfWeaponFire = 10;
            SizeOfWeaponClip = 100;
            WeaponRechargeTime = 5;
            Ammo = new List<MachineGunBullet>();
            ItemType = Enums.Items.MachineGun;
            base.Init();
        }

        public override void Upgrade()
        {
            NumberOfWeaponBarrels += 1;
            RateOfWeaponFire += 10;
            SizeOfWeaponClip += 10;
            WeaponRechargeTime -= 1;
            base.Upgrade();
        }
    }
}
