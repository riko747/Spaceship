using InternalAssets.Scripts.Other;
using UnityEngine;

namespace InternalAssets.Scripts.ShipLogic.Items.Equipment
{
    public class EnergyShield : Item
    {
        private int _counteringDamage;

        protected override int Health { get; set; }
        public override Enums.Items ItemType { get; set; }

        public override void Init()
        {
            _counteringDamage = 15;
            ItemType = Enums.Items.EnergyShield;
            base.Init();
        }

        public int CalculateCounteringDamage(int damage) => damage - _counteringDamage * damage / 100;

        public override void Upgrade()
        {
            base.Upgrade();
            _counteringDamage += 5;
            Debug.Log("Countering damage of " + ItemType + " now is " + _counteringDamage);
        }
    }
}
