using System.Collections.Generic;
using InternalAssets.Scripts.Other;
using InternalAssets.Scripts.ShipLogic.Turrets;
using UnityEngine;
using Zenject;

namespace InternalAssets.Scripts.ShipLogic
{
    public class Ship : MonoBehaviour, Interfaces.IUpgradeable, Interfaces.IShip
    {
        [SerializeField] private ShipData shipData;

        public EquipmentManager EquipmentManager { get; set; }

        private void Start()
        {
            Upgradeables.CreateNewUpgradeables();
            Upgradeables.AddToUpgradeables(this);
            EquipmentManager = new EquipmentManager(shipData);
        }

        public void Upgrade()
        {
            shipData.IncreaseHealth(10);
            Debug.Log("Health of ship now is " + shipData.GetHealth());
        }

        public void DamageTheShip(int damageCount)
        {
            if (shipData.GetHealth() == 0)
            {
                DestroyPlayer();
                return;
            }

            shipData.DecreaseHealth(10);
            Debug.Log("Ship damaged on: " + damageCount + " points ");
            Debug.Log("Ship current health is: " + shipData.GetHealth());
        }

        private void DestroyPlayer() => Debug.Log("Ship is destroyed!");

    }
}
