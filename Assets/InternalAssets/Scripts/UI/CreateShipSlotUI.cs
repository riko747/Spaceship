using System;
using InternalAssets.Scripts.Other;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace InternalAssets.Scripts.UI
{
    public class CreateShipSlotUI : MonoBehaviour
    {
        [Inject] private Interfaces.IShip _ship;
        
        [SerializeField] private TMP_Dropdown typeOfSlotDropdown;
        [SerializeField] private Button createSlotsButton;
        
        public Action SlotsCreated { get; set; }

        private void Start()
        {
            SetTypesOfSlotsToDropDown();
            createSlotsButton.onClick.AddListener(InstallSlotsToShip);
        }

        private void SetTypesOfSlotsToDropDown()
        {
            typeOfSlotDropdown.ClearOptions();
            foreach (var equipmentType in Enum.GetValues(typeof(Enums.EquipmentSlotType)))
                Utilities.AddNewDropDownOption(typeOfSlotDropdown, equipmentType.ToString());

            typeOfSlotDropdown.value = 3;
        }

        private void InstallSlotsToShip()
        {
            var selectedValue = typeOfSlotDropdown.captionText.text;

            if (Enum.TryParse(selectedValue, out Enums.EquipmentSlotType equipmentSlotType))
            {
                _ship.EquipmentManager.CreateEquipmentSlot(equipmentSlotType);
                SlotsCreated?.Invoke();
            }
            else
                Debug.LogError("Invalid equipment slot type selected.");
        }

        private void OnDestroy() => createSlotsButton.onClick.RemoveListener(InstallSlotsToShip);
    }
}
