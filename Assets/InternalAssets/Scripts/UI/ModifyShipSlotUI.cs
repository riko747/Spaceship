using System;
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
        [Inject] private Interfaces.IShipData _shipData;

        [SerializeField] private ScriptableObjectItem items;
        [SerializeField] private TMP_Dropdown typeOfItemDropdown;
        [SerializeField] private Button modifySlotButton;

        private void Start()
        {
            SetTypesOfItemsToDropDown();
            modifySlotButton.onClick.AddListener(InstallItemToSlot);
        }

        private void SetTypesOfItemsToDropDown()
        {
            if (items == null || items.itemsData == null) return;
            typeOfItemDropdown.ClearOptions();
            foreach (var itemType in items.itemsData)
            {
                Utilities.AddNewDropDownOption(typeOfItemDropdown, itemType.item.ToString());
            }
        }

        private void InstallItemToSlot()
        {
            //_shipData
        }

        private void OnDestroy() => modifySlotButton.onClick.RemoveListener(InstallItemToSlot);
    }
}
