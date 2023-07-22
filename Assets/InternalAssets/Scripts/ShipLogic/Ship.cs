using System.Collections;
using System.Linq;
using InternalAssets.Scripts.Other;
using InternalAssets.Scripts.ShipLogic.Items.Equipment;
using InternalAssets.Scripts.ShipLogic.Turrets;
using UnityEngine;

namespace InternalAssets.Scripts.ShipLogic
{
    public class Ship : MonoBehaviour, Interfaces.IUpgradeable, Interfaces.IShip
    {
        [SerializeField] private ShipData shipData;

        public EquipmentManager EquipmentManager { get; set; }
        public ShipData ShipData
        {
            get => shipData;
            set => shipData = value;
        }

        private void Start()
        {
            Upgradeables.CreateNewUpgradeables();
            Upgradeables.AddToUpgradeables(this);
            EquipmentManager = new EquipmentManager(shipData);
        }

        public void Upgrade()
        {
            shipData.IncreaseTotalHealth(10);
            Debug.Log("Health of ship now is " + shipData.GetTotalHealth());
        }

        public void DamageTheShip(int damageCount, bool isPlasmaCannon)
        {
            if (shipData.GetCurrentHealth() == 0)
            {
                DestroyPlayer();
                return;
            }

            var shipHasEnergyShield = false;
            var shipHasHpRegenerator = false;
            HpRegenerator hpRegenerator = null;

            foreach (var item in shipData.GetEquipmentSlots().Where(slot => slot.SlotItem != null).SelectMany(slot => slot.SlotItem))
            {
                switch (item.ItemType)
                {
                    case Enums.Items.EnergyShield when item is EnergyShield energyShield:
                    {
                        if (isPlasmaCannon)
                            damageCount = energyShield.CalculateCounteringDamage(damageCount);
                        shipHasEnergyShield = true;
                        break;
                    }
                    case Enums.Items.HpRegenerator when item is HpRegenerator currentHpRegenerator:
                        hpRegenerator = currentHpRegenerator;
                        shipHasHpRegenerator = true;
                        break;
                }
            }

            shipData.DecreaseCurrentHealth(damageCount);
            Debug.Log("Ship damaged on: " + damageCount + " points ");

            if (!shipHasEnergyShield || !shipHasHpRegenerator) return;
            
            StopAllCoroutines();
            StartCoroutine(RegenerateHealth(hpRegenerator.GetHealthRegenerationPercentage()));
        }
        
        private IEnumerator RegenerateHealth(int healthRegenerationPercentage)
        {
            var hpToHeal = ShipData.GetTotalHealth() * healthRegenerationPercentage / 100;
            var initialHealth = ShipData.GetCurrentHealth();
    
            while (ShipData.GetCurrentHealth() < ShipData.GetTotalHealth() && ShipData.GetCurrentHealth() < initialHealth + hpToHeal)
            {
                yield return new WaitForSeconds(1);
                ShipData.IncreaseCurrentHealth(1);
                Debug.Log("Ship heals on " + healthRegenerationPercentage + "hp. Current health is: " + ShipData.GetCurrentHealth());
            }
        }

        private void DestroyPlayer() => Debug.Log("Ship is destroyed!");

    }
}
