using System;
using InternalAssets.Scripts.Other;
using UnityEngine;

namespace InternalAssets.Scripts.ShipLogic.Items.Equipment
{
    public class EnergyShield : Item
    {
        private int _counteringDamage;

        private int CounteringDamage
        {
            get => _counteringDamage;
            set => _counteringDamage = Math.Max(value, 80);
        }
        
        protected override int Health { get; set; }
        public override Enums.Items ItemType { get; set; }

        public override void Init()
        {
            CounteringDamage = 15;
            ItemType = Enums.Items.EnergyShield;
            base.Init();
        }

        public override void Upgrade()
        {
            base.Upgrade();
            CounteringDamage += 5;
            Debug.Log("Countering damage of " + ItemType + " now is " + CounteringDamage);
        }
    }
}
