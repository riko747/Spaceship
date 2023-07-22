using System.Collections;
using InternalAssets.Scripts.Other;
using UnityEngine;
using Zenject;

namespace InternalAssets.Scripts.ShipLogic.Items.Equipment
{
    public class HpRegenerator : Item
    {
        [Inject] private Interfaces.IShip _ship;
        private int _healthRegenerationPercentage;

        protected override int Health { get; set; }
        public override Enums.Items ItemType { get; set; }

        public override void Init()
        {
            _healthRegenerationPercentage = 20;
            ItemType = Enums.Items.HpRegenerator;
            base.Init();
        }

        public int GetHealthRegenerationPercentage() => _healthRegenerationPercentage;
        
        public override void Upgrade()
        {
            base.Upgrade();
            _healthRegenerationPercentage += 5;
            Debug.Log("HP per second of " + ItemType + " now is " + _healthRegenerationPercentage);
        }
    }
}
