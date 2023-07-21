using System;
using System.Collections.Generic;
using System.Reflection;
using InternalAssets.Scripts.Other;
using InternalAssets.Scripts.Ship.Items;
using TMPro;
using UnityEngine;

namespace InternalAssets.Scripts.UI
{
    public class CreateSlotForShipUI : MonoBehaviour
    {
        [SerializeField] private TMP_Dropdown typeOfSlotDropdown;
        [SerializeField] private TMP_Dropdown typeOfItemDropdown;
        [SerializeField] private TMP_Dropdown typeOfWeaponDropDown;
        [SerializeField] private TMP_Dropdown typeOfAmmoDropDown;

        private void Start()
        {
            PrepareDropDowns();
            typeOfItemDropdown.onValueChanged.AddListener(delegate
            {
                SetTypesOfWeaponDropDown(typeOfItemDropdown.value);
            });
        }

        private void PrepareDropDowns()
        {
            SetTypesOfSlotsToDropDown();
            SetTypesOfItemsToDropDown();
        }

        private void SetTypesOfSlotsToDropDown()
        {
            typeOfSlotDropdown.ClearOptions();
            foreach (var equipmentType in Enum.GetValues(typeof(Enums.EquipmentSlotType)))
                Utilities.AddNewDropDownOption(typeOfSlotDropdown, equipmentType.ToString());
        }

        private void SetTypesOfItemsToDropDown()
        {
            var baseType = typeof(Item);
            var assembly = Assembly.GetExecutingAssembly();
            var types = assembly.GetTypes();
            var typeNames = new List<string>();

            foreach (var type in types)
            {
                if (!type.IsSubclassOf(baseType) || type == baseType) continue;
                var currentBaseType = type.BaseType;
                while (currentBaseType != null)
                {
                    if (currentBaseType == baseType)
                    {
                        typeNames.Add(type.Name);
                        break;
                    }
                    currentBaseType = currentBaseType.BaseType;
                }
            }

            typeOfItemDropdown.ClearOptions();
            typeOfItemDropdown.AddOptions(typeNames);
        }

        private void SetTypesOfWeaponDropDown(int value)
        {
            
        }
    }
}
