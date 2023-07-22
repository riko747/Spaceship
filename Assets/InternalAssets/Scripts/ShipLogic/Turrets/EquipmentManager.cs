using System.Collections.Generic;
using System.Linq;
using InternalAssets.Scripts.Other;
using InternalAssets.Scripts.ShipLogic.Items;
using InternalAssets.Scripts.ShipLogic.Items.Equipment;
using InternalAssets.Scripts.ShipLogic.Items.Equipment.Engines;
using InternalAssets.Scripts.ShipLogic.Items.Weapons;
using UnityEngine;
using Zenject;

namespace InternalAssets.Scripts.ShipLogic.Turrets
{
    public class EquipmentManager
    {
        [Inject] private Interfaces.IUpgradeableInterfaceManager _upgradeableInterfaceManager;
        private readonly ShipData _shipData;

        public EquipmentManager(ShipData shipData) => _shipData = shipData;

        public void CreateEquipmentSlot(Enums.EquipmentSlotType equipmentSlotType)
        {
            var equipmentSlot = new EquipmentSlot(equipmentSlotType);
            _shipData.GetEquipmentSlots().Add(equipmentSlot);
            Debug.Log("Slot installed to ship: " + equipmentSlotType);
        }

        public void InstallEquipmentToSlot(Enums.Items itemEnum)
        {
            EquipmentSlot freeSlot;
            Enums.EquipmentSlotType requiredSlotType;
            var itemsToInstall = new List<Item>();
            var installedItems = new List<string>();
            switch (itemEnum)
            {
                case Enums.Items.MachineGun:
                    requiredSlotType = Enums.EquipmentSlotType.Light;
                    itemsToInstall.Add(new MachineGun());
                    installedItems.Add(Enums.Items.MachineGun.ToString());
                    break;

                case Enums.Items.MachineGunPlasmaCannonEnergyShield:
                    requiredSlotType = Enums.EquipmentSlotType.Heavy;
                    itemsToInstall.AddRange(new Item[] { new MachineGun(), new PlasmaCannon(), new EnergyShield() });
                    installedItems.AddRange(new[]
                    {
                        Enums.Items.MachineGun.ToString(), Enums.Items.PlasmaCannon.ToString(),
                        Enums.Items.EnergyShield.ToString()
                    });
                    break;

                case Enums.Items.MachineGunX2:
                    requiredSlotType = Enums.EquipmentSlotType.Medium;
                    itemsToInstall.AddRange(new Item[] { new MachineGun(), new MachineGun() });
                    installedItems.AddRange(new[]
                    {
                        Enums.Items.MachineGun.ToString(), Enums.Items.MachineGun.ToString()
                    });
                    break;

                case Enums.Items.MachineGunX2PlasmaCannonX2:
                    requiredSlotType = Enums.EquipmentSlotType.Heavy;
                    itemsToInstall.AddRange(new Item[]
                        { new MachineGun(), new MachineGun(), new PlasmaCannon(), new PlasmaCannon() });
                    installedItems.AddRange(new[]
                    {
                        Enums.Items.MachineGun.ToString(), Enums.Items.MachineGun.ToString(),
                        Enums.Items.PlasmaCannon.ToString(), Enums.Items.PlasmaCannon.ToString()
                    });
                    break;

                case Enums.Items.PlasmaCannon:
                    requiredSlotType = Enums.EquipmentSlotType.Light;
                    itemsToInstall.Add(new PlasmaCannon());
                    installedItems.Add(Enums.Items.PlasmaCannon.ToString());
                    break;

                case Enums.Items.EnergyShield:
                    requiredSlotType = Enums.EquipmentSlotType.Medium;
                    itemsToInstall.Add(new EnergyShield());
                    installedItems.Add(Enums.Items.EnergyShield.ToString());
                    break;

                case Enums.Items.HpRegenerator:
                    freeSlot = _shipData.GetEquipmentSlots().FirstOrDefault();
                    freeSlot?.InstallHpRegenerationInEquipmentSlot(new HpRegenerator());
                    installedItems.Add(Enums.Items.HpRegenerator.ToString());
                    Debug.Log("Item installed on ship: " + installedItems[0]);
                    return;

                case Enums.Items.SmallEngine:
                    requiredSlotType = Enums.EquipmentSlotType.Medium;
                    itemsToInstall.Add(new SmallEngine());
                    installedItems.Add(Enums.Items.SmallEngine.ToString());
                    break;

                case Enums.Items.LargeEngine:
                    requiredSlotType = Enums.EquipmentSlotType.Heavy;
                    itemsToInstall.Add(new LargeEngine());
                    installedItems.Add(Enums.Items.LargeEngine.ToString());
                    break;

                default:
                    Debug.Log("There is no such item");
                    return;
            }

            freeSlot = _shipData.GetEquipmentSlots()
                .FirstOrDefault(e => e.EquipmentSlotType == requiredSlotType && e.SlotIsBusy == false);

            if (freeSlot != null)
            {
                if (itemsToInstall.Count == 1)
                    freeSlot.InstallInEquipmentSlot(itemsToInstall[0], requiredSlotType);
                else
                    freeSlot.InstallInEquipmentSlots(itemsToInstall, requiredSlotType);

                foreach (var installedItem in installedItems)
                    Debug.Log("Item installed on ship: " + installedItem);
            }
            else
                Debug.Log("There is no suitable slot");
        }

        public void DamageEquipment(int damage)
        {
            foreach (var equipmentSlot in _shipData.GetEquipmentSlots())
            {
                foreach (var item in equipmentSlot.SlotItem)
                {
                    item.DecreaseHealth(damage);
                    Debug.Log("Item: " + item.ItemType + " damaged on " + damage + "points");
                }
                Debug.Log("Equipment current health is: " + string.Join(", ", equipmentSlot.SlotItem.Select(currentItem => currentItem.GetHealth())) + " points");   
            }
        }
    }
}
