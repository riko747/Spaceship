using System;
using InternalAssets.Scripts.Other;
using UnityEngine;

namespace InternalAssets.Scripts.ShipLogic.Items.Equipment
{
    public class HpRegenerator : Item
    {
        private int _healthRegenerationPerSecond;

        private int HealthRegenerationPerSecond
        {
            get => _healthRegenerationPerSecond;
            set => _healthRegenerationPerSecond = Math.Max(value, 20);
        }
        
        protected override int Health { get; set; }
        public override Enums.Items ItemType { get; set; }
        
        public override void Init()
        {
            HealthRegenerationPerSecond = 1;
            ItemType = Enums.Items.HpRegenerator;
            base.Init();
        }

        public override void Upgrade()
        {
            base.Upgrade();
            HealthRegenerationPerSecond += 1;
            Debug.Log("HP per second of " + ItemType + " now is " + HealthRegenerationPerSecond);
        }
    }
}
