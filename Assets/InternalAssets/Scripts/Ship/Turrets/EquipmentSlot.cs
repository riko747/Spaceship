using InternalAssets.Scripts.Other;
using InternalAssets.Scripts.Ship.Items;

namespace InternalAssets.Scripts.Ship.Turrets
{
    public class EquipmentSlot
    {
        private Interfaces.IAmmo _ammunition;
        
        public bool SlotIsBusy { get; set; }
        public Enums.EquipmentSlotType EquipmentSlotType { get; set; }
        public Item SlotItem { get; set; }

        public EquipmentSlot InstallInEquipmentSlot(Item item)
        {
            switch (item.GetEquipmentSlotType())
            {
                case Enums.EquipmentSlotType.None:
                    EquipmentSlotType = Enums.EquipmentSlotType.None;
                    SlotIsBusy = true;
                    return this;
                case Enums.EquipmentSlotType.Light:
                    EquipmentSlotType = Enums.EquipmentSlotType.Light;
                    SlotIsBusy = true;
                    return this;
                case Enums.EquipmentSlotType.Medium:
                    EquipmentSlotType = Enums.EquipmentSlotType.Medium;
                    SlotIsBusy = true;
                    return this;
                case Enums.EquipmentSlotType.Heavy:
                    EquipmentSlotType = Enums.EquipmentSlotType.Heavy;
                    SlotIsBusy = true;
                    return this;
                default:
                    return null;
            }
        }
    }
    
}