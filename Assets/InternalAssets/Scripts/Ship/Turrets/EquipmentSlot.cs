using System.Collections.Generic;
using InternalAssets.Scripts.Other;
using InternalAssets.Scripts.Ship.Items;

namespace InternalAssets.Scripts.Ship.Turrets
{
    public class EquipmentSlot
    {
        public bool SlotIsBusy { get; set; }
        public Enums.EquipmentSlotType EquipmentSlotType { get; set; }
        public List<Item> SlotItem { get; set; }

        public EquipmentSlot(Enums.EquipmentSlotType equipmentSlotType)
        {
            EquipmentSlotType = equipmentSlotType;
        }

        public void InstallInEquipmentSlot(Item item, Enums.EquipmentSlotType equipmentSlotType)
        {
            EquipmentSlotType = equipmentSlotType;
            SlotItem.Add(item);
            SlotIsBusy = true;
        }
        
        public void InstallInEquipmentSlots(List<Item> items, Enums.EquipmentSlotType equipmentSlotType)
        {
            EquipmentSlotType = equipmentSlotType;
            foreach (var item in items)
                SlotItem.Add(item);
            SlotIsBusy = true;
        }
    }
    
}
