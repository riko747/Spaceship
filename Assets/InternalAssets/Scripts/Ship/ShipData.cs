using System.Collections.Generic;
using InternalAssets.Scripts.Ship.Turrets;

namespace InternalAssets.Scripts.Ship
{
    public class ShipData
    {
        private int _health;
        private List<EquipmentSlot> _equipmentSlots;

        public int GetHealth() => _health;
        public void IncreaseHealth(int healthPoints) => _health += healthPoints;
        public void DecreaseHealth(int healthPoints) => _health -= healthPoints;

        public void CreatEquipmentSlots(int numberOfSlots)
        {
            _equipmentSlots = new List<EquipmentSlot>();
            for (var i = 0; i != numberOfSlots; i++)
            {
                var newEquipmentSlot = new EquipmentSlot();
                _equipmentSlots.Add(newEquipmentSlot);
            }
        }
        
        
    }
}
