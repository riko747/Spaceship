using System;
using System.Collections.Generic;
using InternalAssets.Scripts.Other;
using InternalAssets.Scripts.ShipLogic.Turrets;
using UnityEngine;

namespace InternalAssets.Scripts.ShipLogic
{
    public class ShipData : MonoBehaviour, Interfaces.IHealth
    {
        private int _currentHealth;
        private int _totalHealth;
        
        protected virtual int CurrentHealth
        {
            get => _currentHealth;
            set => _currentHealth = Math.Max(value, 0);
        }
        
        private List<EquipmentSlot> _equipmentSlots;

        private void Awake()
        {
            Init();
        }

        public void Init()
        {
            _totalHealth = 100;
            CurrentHealth = _totalHealth;
            _equipmentSlots = new List<EquipmentSlot>();
        }

        public int GetCurrentHealth() => _currentHealth;

        public int GetTotalHealth() => _totalHealth;

        public void IncreaseTotalHealth(int healthPoints) => _totalHealth += healthPoints;
        public void IncreaseCurrentHealth(int healthPoints) => _currentHealth += healthPoints;

        public void DecreaseCurrentHealth(int healthPoints) => CurrentHealth -= healthPoints;

        public List<EquipmentSlot> GetEquipmentSlots() => _equipmentSlots;
    }
}
