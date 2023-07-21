using System;
using System.Collections.Generic;
using System.Linq;
using InternalAssets.Scripts.Other;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace InternalAssets.Scripts.UI
{
    public class CreateShipSlotUI : MonoBehaviour
    {
        [Inject] private Interfaces.IShipData _shipData;
        
        [SerializeField] private List<TMP_Dropdown> typeOfSlotDropdowns;
        [SerializeField] private Button createSlotsButton;

        private void Start()
        {
            SetTypesOfSlotsToDropDown();
            createSlotsButton.onClick.AddListener(InstallSlotsToShip);
        }

        private void SetTypesOfSlotsToDropDown()
        {
            foreach (var typeOfSlotDropdown in typeOfSlotDropdowns)
            {
                typeOfSlotDropdown.ClearOptions();
                foreach (var equipmentType in Enum.GetValues(typeof(Enums.EquipmentSlotType)))
                {
                    Utilities.AddNewDropDownOption(typeOfSlotDropdown, equipmentType.ToString());
                }
            }

            foreach (var typeOfSlotDropdown in typeOfSlotDropdowns)
                typeOfSlotDropdown.value = 3;
        }

        private void InstallSlotsToShip()
        {
            foreach (var equipmentSlotType in typeOfSlotDropdowns
                         .Select(typeOfSlotDropdown => typeOfSlotDropdown.captionText.text)
                         .Select(selectedValue =>
                             (Enums.EquipmentSlotType)Enum.Parse(typeof(Enums.EquipmentSlotType), selectedValue)))
                _shipData.CreateEquipmentSlot(equipmentSlotType);
        }

        /*private void SetTypesOfItemsToDropDown(int index = 0)
        {
            if (items == null || items.itemsData == null) return;
            typeOfItemDropdown.ClearOptions();

            foreach (var item in items.itemsData.Where(item => item.equipmentSlotType.ToString() == typeOfSlotDropdown.options[index].text))
            {
                Utilities.AddNewDropDownOption(typeOfItemDropdown, item.value.ToString());
            }

            typeOfItemDropdown.value = index;
        }*/

        private void OnDestroy() => createSlotsButton.onClick.RemoveListener(InstallSlotsToShip);
    }
}
