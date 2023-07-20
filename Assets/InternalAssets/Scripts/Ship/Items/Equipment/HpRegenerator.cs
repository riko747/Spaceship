using InternalAssets.Scripts.Other;

namespace InternalAssets.Scripts.Ship.Items.Equipment
{
    public class HpRegenerator : Item
    {
        private int _healthRegenerationPerSecond = 1;

        protected override void Init()
        {
            EquipmentSlotType = Enums.EquipmentSlotType.None;
        }

        public override void Upgrade()
        {
            
        }
    }
}
