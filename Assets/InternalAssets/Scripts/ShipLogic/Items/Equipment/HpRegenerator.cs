using System;
using InternalAssets.Scripts.Other;
using UnityEngine;

namespace InternalAssets.Scripts.ShipLogic.Items.Equipment
{
    public class HpRegenerator : Item
    {
        private int _healthRegenerationPerSecond;

        protected override int Health { get; set; }
        public override Enums.Items ItemType { get; set; }
        
        public override void Init()
        {
            _healthRegenerationPerSecond = 1;
            ItemType = Enums.Items.HpRegenerator;
            base.Init();
        }

        public override void Upgrade()
        {
            base.Upgrade();
            _healthRegenerationPerSecond += 1;
            Debug.Log("HP per second of " + ItemType + " now is " + _healthRegenerationPerSecond);
        }
    }
}
