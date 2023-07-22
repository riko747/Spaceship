using System;
using System.Collections.Generic;
using InternalAssets.Scripts.Other;
using InternalAssets.Scripts.ShipLogic.Turrets;
using UnityEngine;

namespace InternalAssets.Scripts.ShipLogic
{
    public class ShipData : MonoBehaviour, Interfaces.IHealth
    {
        private int _health;
        
        protected virtual int Health
        {
            get => _health;
            set => _health = Math.Max(value, 0);
        }
        
        private List<EquipmentSlot> _equipmentSlots;

        private void Awake()
        {
            Init();
        }

        public void Init()
        {
            Health = 100;
            _equipmentSlots = new List<EquipmentSlot>();
        }

        public int GetHealth() => _health;
        public void IncreaseHealth(int healthPoints) => Health += healthPoints;
        public void DecreaseHealth(int healthPoints) => Health -= healthPoints;

        public List<EquipmentSlot> GetEquipmentSlots() => _equipmentSlots;
    }
}
