using InternalAssets.Scripts.Other;

namespace InternalAssets.Scripts.Ship.Items
{
    public abstract class Item : Interfaces.IHealth, Interfaces.IUpgradeable
    {
        private int _health;
        
        protected Enums.EquipmentSlotType EquipmentSlotType;
        protected abstract void Init();
        
        public int GetHealth() => _health;
        public void IncreaseHealth(int healthPoints) => _health += healthPoints;
        public void DecreaseHealth(int healthPoints) => _health -= healthPoints;
        public Enums.EquipmentSlotType GetEquipmentSlotType() => EquipmentSlotType;

        public abstract void Upgrade();
    }
}
