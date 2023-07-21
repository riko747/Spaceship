using InternalAssets.Scripts.Other;

namespace InternalAssets.Scripts.ShipLogic.Items
{
    public class Item : Interfaces.IHealth, Interfaces.IUpgradeable
    {
        private int _health;

        public int GetHealth() => _health;
        public void IncreaseHealth(int healthPoints) => _health += healthPoints;
        public void DecreaseHealth(int healthPoints) => _health -= healthPoints;

        public virtual void Upgrade()
        {
            
        }
    }
}
