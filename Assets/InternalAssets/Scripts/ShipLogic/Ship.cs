using System.Collections.Generic;
using System.Linq;
using InternalAssets.Scripts.Other;
using InternalAssets.Scripts.Ship;
using InternalAssets.Scripts.ShipLogic.Items;
using InternalAssets.Scripts.ShipLogic.Items.Equipment;
using InternalAssets.Scripts.ShipLogic.Items.Weapons;
using InternalAssets.Scripts.ShipLogic.Turrets;
using UnityEngine;

namespace InternalAssets.Scripts.ShipLogic
{
    public class Ship : MonoBehaviour, Interfaces.IUpgradeable, Interfaces.IShip
    {
        [SerializeField] private ShipData shipData;

        public void Upgrade()
        {
            
        }
        
        public void CreateEquipmentSlot(Enums.EquipmentSlotType equipmentSlotType)
        {
            var equipmentSlot = new EquipmentSlot(equipmentSlotType);
            shipData.GetEquipmentSlots().Add(equipmentSlot);
        }

        public void InstallEquipmentToSlot(Enums.Items itemEnum)
        {
            EquipmentSlot freeSlot;
            switch (itemEnum)
            {
                case Enums.Items.MachineGun:
                    freeSlot = shipData.GetEquipmentSlots().FirstOrDefault(e => e.EquipmentSlotType == Enums.EquipmentSlotType.Light && e.SlotIsBusy == false);
                    if (freeSlot != null)
                        freeSlot.InstallInEquipmentSlot(new MachineGun(), Enums.EquipmentSlotType.Light);
                    else
                        Debug.Log("There is no suitable slot");
                    break;
                case Enums.Items.MachineGunPlasmaCannonEnergyShield:
                    freeSlot = shipData.GetEquipmentSlots().FirstOrDefault(e => e.EquipmentSlotType == Enums.EquipmentSlotType.Heavy && e.SlotIsBusy == false);
                    if (freeSlot != null)
                    {
                        var itemsToInstall = new List<Item> { new MachineGun(), new PlasmaCannon(), new EnergyShield() };
                        freeSlot.InstallInEquipmentSlots(itemsToInstall, Enums.EquipmentSlotType.Heavy);
                    }
                    else
                        Debug.Log("There is no suitable slot");
                    break;
                case Enums.Items.MachineGunX2:
                    freeSlot = shipData.GetEquipmentSlots().FirstOrDefault(e => e.EquipmentSlotType == Enums.EquipmentSlotType.Medium && e.SlotIsBusy == false);
                    if (freeSlot != null)
                    {
                        var itemsToInstall = new List<Item> { new MachineGun(), new MachineGun()};
                        freeSlot.InstallInEquipmentSlots(itemsToInstall, Enums.EquipmentSlotType.Medium);
                    }
                    else
                        Debug.Log("There is no suitable slot");
                    break;
                case Enums.Items.MachineGunX2PlasmaCannonX2:
                    freeSlot = shipData.GetEquipmentSlots().FirstOrDefault(e => e.EquipmentSlotType == Enums.EquipmentSlotType.Heavy && e.SlotIsBusy == false);
                    if (freeSlot != null)
                    {
                        var itemsToInstall = new List<Item> { new MachineGun(), new MachineGun(), new PlasmaCannon(), new PlasmaCannon()};
                        freeSlot.InstallInEquipmentSlots(itemsToInstall, Enums.EquipmentSlotType.Heavy);
                    }
                    else
                        Debug.Log("There is no suitable slot");
                    break;
                case Enums.Items.PlasmaCannon:
                    freeSlot = shipData.GetEquipmentSlots().FirstOrDefault(e => e.EquipmentSlotType == Enums.EquipmentSlotType.Light && e.SlotIsBusy == false);
                    if (freeSlot != null)
                        freeSlot.InstallInEquipmentSlot(new PlasmaCannon(), Enums.EquipmentSlotType.Light);
                    else
                        Debug.Log("There is no suitable slot");
                    break;
                case Enums.Items.EnergyShield:
                    freeSlot = shipData.GetEquipmentSlots().FirstOrDefault(e => e.EquipmentSlotType == Enums.EquipmentSlotType.Medium && e.SlotIsBusy == false);
                    if (freeSlot != null)
                        freeSlot.InstallInEquipmentSlot(new EnergyShield(), Enums.EquipmentSlotType.Medium);
                    else
                        Debug.Log("There is no suitable slot");
                    break;
                case Enums.Items.HpRegenerator:
                    freeSlot = shipData.GetEquipmentSlots().FirstOrDefault();
                    if (freeSlot != null)
                        freeSlot.InstallInEquipmentSlot(new HpRegenerator(), Enums.EquipmentSlotType.None);
                    else
                        Debug.Log("There is no suitable slot");
                    break;
                case Enums.Items.SmallEngine:
                    freeSlot = shipData.GetEquipmentSlots().FirstOrDefault(e => e.EquipmentSlotType == Enums.EquipmentSlotType.Medium && e.SlotIsBusy == false);
                    if (freeSlot != null)
                        freeSlot.InstallInEquipmentSlot(new SmallEngine(), Enums.EquipmentSlotType.Medium);
                    else
                        Debug.Log("There is no suitable slot");
                    break;
                case Enums.Items.LargeEngine:
                    freeSlot = shipData.GetEquipmentSlots().FirstOrDefault(e => e.EquipmentSlotType == Enums.EquipmentSlotType.Heavy && e.SlotIsBusy == false);
                    if (freeSlot != null)
                        freeSlot.InstallInEquipmentSlot(new LargeEngine(), Enums.EquipmentSlotType.Heavy);
                    else
                        Debug.Log("There is no suitable slot");
                    break;
                default:
                    Debug.Log("There is no such item");
                    return;
            }
        }
    }
}
