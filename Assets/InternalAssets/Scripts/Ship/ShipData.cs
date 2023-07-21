using System;
using System.Collections.Generic;
using InternalAssets.Scripts.Other;
using InternalAssets.Scripts.Ship.Turrets;
using UnityEngine;

namespace InternalAssets.Scripts.Ship
{
    public class ShipData : MonoBehaviour, Interfaces.IHealth, Interfaces.IShipData
    {
        private int _health;
        private List<EquipmentSlot> _equipmentSlots;

        private void Start()
        {
            _equipmentSlots = new List<EquipmentSlot>();
        }

        public int GetHealth() => _health;
        public void IncreaseHealth(int healthPoints) => _health += healthPoints;
        public void DecreaseHealth(int healthPoints) => _health -= healthPoints;

        public void CreateEquipmentSlot(Enums.EquipmentSlotType equipmentSlotType)
        {
            var equipmentSlot = new EquipmentSlot(equipmentSlotType);
            _equipmentSlots.Add(equipmentSlot);
        }
    }
}
