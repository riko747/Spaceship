using System;
using System.Collections.Generic;
using System.Linq;
using InternalAssets.Scripts.Other;
using InternalAssets.Scripts.Ship.Items;
using InternalAssets.Scripts.Ship.Items.Equipment;
using InternalAssets.Scripts.Ship.Items.Weapons;
using InternalAssets.Scripts.Ship.Turrets;
using UnityEngine;

namespace InternalAssets.Scripts.Ship
{
    public class ShipData : MonoBehaviour, Interfaces.IHealth, Interfaces.IShipData
    {
        private int _health;
        private List<EquipmentSlot> _equipmentSlots;

        private void Start()
        {
            _equipmentSlots = new List<EquipmentSlot>();
        }

        public int GetHealth() => _health;
        public void IncreaseHealth(int healthPoints) => _health += healthPoints;
        public void DecreaseHealth(int healthPoints) => _health -= healthPoints;

        public void CreateEquipmentSlot(Enums.EquipmentSlotType equipmentSlotType)
        {
            var equipmentSlot = new EquipmentSlot(equipmentSlotType);
            _equipmentSlots.Add(equipmentSlot);
        }

        public void InstallEquipmentToSlot(Enums.Items itemEnum)
        {
            EquipmentSlot freeSlot;
            switch (itemEnum)
            {
                case Enums.Items.MachineGun:
                    freeSlot = _equipmentSlots.FirstOrDefault(e => e.EquipmentSlotType == Enums.EquipmentSlotType.Light && e.SlotIsBusy == false);
                    if (freeSlot != null)
                        freeSlot.InstallInEquipmentSlot(new MachineGun(), Enums.EquipmentSlotType.Light);
                    else
                        Debug.Log("There is no suitable slot");
                    break;
                case Enums.Items.MachineGunPlasmaCannonEnergyShield:
                    freeSlot = _equipmentSlots.FirstOrDefault(e => e.EquipmentSlotType == Enums.EquipmentSlotType.Heavy && e.SlotIsBusy == false);
                    if (freeSlot != null)
                    {
                        var itemsToInstall = new List<Item> { new MachineGun(), new PlasmaCannon(), new EnergyShield() };
                        freeSlot.InstallInEquipmentSlots(itemsToInstall, Enums.EquipmentSlotType.Light);
                    }
                    else
                        Debug.Log("There is no suitable slot");
                    break;
                case Enums.Items.MachineGunX2:
                    freeSlot = _equipmentSlots.FirstOrDefault(e => e.EquipmentSlotType == Enums.EquipmentSlotType.Medium && e.SlotIsBusy == false);
                    if (freeSlot != null)
                    {
                        var itemsToInstall = new List<Item> { new MachineGun(), new MachineGun()};
                        freeSlot.InstallInEquipmentSlots(itemsToInstall, Enums.EquipmentSlotType.Light);
                    }
                    else
                        Debug.Log("There is no suitable slot");
                    break;
                case Enums.Items.MachineGunX2PlasmaCannonX2:
                    break;
                case Enums.Items.PlasmaCannon:
                    break;
                case Enums.Items.EnergyShield:
                    break;
                case Enums.Items.HpRegenerator:
                    break;
                case Enums.Items.SmallEngine:
                    break;
                case Enums.Items.LargeEngine:
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(itemEnum), itemEnum, null);
            }
        }
    }
}
