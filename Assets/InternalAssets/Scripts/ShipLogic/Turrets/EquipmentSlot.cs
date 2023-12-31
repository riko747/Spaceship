using System.Collections.Generic;
using InternalAssets.Scripts.Other;
using InternalAssets.Scripts.ShipLogic.Items;

namespace InternalAssets.Scripts.ShipLogic.Turrets
{
    public class EquipmentSlot
    {
        public bool SlotIsBusy { get; set; }
        public Enums.EquipmentSlotType EquipmentSlotType { get; set; }
        public List<Item> SlotItem { get; } = new();

        public EquipmentSlot(Enums.EquipmentSlotType equipmentSlotType)
        {
            EquipmentSlotType = equipmentSlotType;
        }

        public void InstallInEquipmentSlot(Item item, Enums.EquipmentSlotType equipmentSlotType)
        {
            EquipmentSlotType = equipmentSlotType;
            SlotItem.Add(item);
            item.Init();
            SlotIsBusy = true;
        }

        public void InstallInEquipmentSlots(List<Item> items, Enums.EquipmentSlotType equipmentSlotType)
        {
            EquipmentSlotType = equipmentSlotType;
            foreach (var item in items)
            {
                SlotItem.Add(item);
                item.Init();
            }

            SlotIsBusy = true;
        }

        public void InstallHpRegenerationInEquipmentSlot(Item item)
        {
            SlotItem.Add(item);
            item.Init();
        }
    }
    
}
