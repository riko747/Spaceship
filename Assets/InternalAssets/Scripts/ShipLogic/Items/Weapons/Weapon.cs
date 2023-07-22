using System.Collections.Generic;
using InternalAssets.Scripts.Other;
using UnityEngine;

namespace InternalAssets.Scripts.ShipLogic.Items.Weapons
{
    public class Weapon : Item, Interfaces.IWeapon
    {
        public int NumberOfWeaponBarrels { get; set; }
        public int RateOfWeaponFire { get; set; }
        public int SizeOfWeaponClip { get; set; }
        public int WeaponRechargeTime { get; set; }
        public IEnumerable<Interfaces.IAmmo> Ammo { get; set; }

        public override void Upgrade()
        {
            Debug.Log("Number of weapon barrels of " + ItemType + " weapon now is " + NumberOfWeaponBarrels);
            Debug.Log("Rate of weapon fire of " + ItemType + " weapon now is " + RateOfWeaponFire);
            Debug.Log("Size of weapon clip of " + ItemType + " weapon now is " + SizeOfWeaponClip);
            Debug.Log("Weapon recharge time of " + ItemType + " weapon now is " + WeaponRechargeTime);
        }
    }
}
