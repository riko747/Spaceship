using System;
using InternalAssets.Scripts.Other;
using UnityEngine;
using Zenject;

namespace InternalAssets.Scripts.ShipLogic.Items
{
    public class Item : Interfaces.IHealth, Interfaces.IUpgradeable
    {
        [Inject] private Interfaces.IShip _ship;
        
        private int _health;
        private Enums.Items _itemType;

        protected virtual int Health
        {
            get => _health;
            set => _health = Math.Max(value, 0);
        }
        
        public virtual Enums.Items ItemType { get; set; }

        public virtual void Init()
        {
            Health = 100;
            Upgradeables.AddToUpgradeables(this);
        }

        public int GetCurrentHealth() => Health;
        public void IncreaseTotalHealth(int healthPoints) => Health += healthPoints;
        public void DecreaseCurrentHealth(int healthPoints) => Health -= healthPoints;

        public virtual void Upgrade()
        {
            Health += 5;
            Debug.Log("Health of " + ItemType + " now is " + Health + " points ");
        }
    }
}
