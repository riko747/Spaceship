using System.Collections.Generic;
using System.Linq;
using InternalAssets.Scripts.Ship.Items;
using InternalAssets.Scripts.Ship.Turrets;
using TMPro;

namespace InternalAssets.Scripts.Other
{
    public static class Utilities
    {
        public static EquipmentSlot HasFreeEquipmentSlot(IEnumerable<EquipmentSlot> equipmentSlots, Item item)
        {
            return (from equipmentSlot in equipmentSlots
                where equipmentSlot.EquipmentSlotType == item.GetEquipmentSlotType() && !equipmentSlot.SlotIsBusy
                select equipmentSlot.InstallInEquipmentSlot(item)).FirstOrDefault();
        }

        public static void AddNewDropDownOption(TMP_Dropdown dropdown, string optionText)
        {
            var newOption = new TMP_Dropdown.OptionData(optionText);
            dropdown.options.Add(newOption);
        }
    }
}
