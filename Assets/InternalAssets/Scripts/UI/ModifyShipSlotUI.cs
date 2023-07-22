using System;
using System.Linq;
using InternalAssets.ScriptableObjects;
using InternalAssets.Scripts.Other;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace InternalAssets.Scripts.UI
{
    public class ModifyShipSlotUI : MonoBehaviour
    {
        [Inject] private Interfaces.IShip _ship;
        [Inject] private Interfaces.IUiSystem _uiSystem;

        [SerializeField] private ScriptableObjectItem items;
        [SerializeField] private TMP_Dropdown typeOfItemDropdown;
        [SerializeField] private Button modifySlotButton;

        private void Start()
        {
            SetTypesOfItemsToDropDown();
            modifySlotButton.onClick.AddListener(InstallItemToSlot);
            _uiSystem.GetCreateShipSlotUI().SlotsCreated += SetModifyButtonActive;
        }

        private void SetModifyButtonActive()
        {
            modifySlotButton.interactable = true;
            _uiSystem.GetCreateShipSlotUI().SlotsCreated -= SetModifyButtonActive;
        }

        private void SetTypesOfItemsToDropDown()
        {
            if (items == null || items.itemsData == null) return;
            typeOfItemDropdown.ClearOptions();
            foreach (var itemType in items.itemsData)
                Utilities.AddNewDropDownOption(typeOfItemDropdown, itemType.item.ToString());
        }

        private void InstallItemToSlot()
        {
            var selectedIndex = typeOfItemDropdown.value;
            var selectedValue = typeOfItemDropdown.options[selectedIndex].text;
            var matchedEnumValue = Enum.GetValues(typeof(Enums.Items))
                .Cast<Enums.Items>()
                .FirstOrDefault(e => e.ToString() == selectedValue);
            _ship.EquipmentManager.InstallEquipmentToSlot(matchedEnumValue);
        }

        private void OnDestroy() => modifySlotButton.onClick.RemoveListener(InstallItemToSlot);
    }
}
