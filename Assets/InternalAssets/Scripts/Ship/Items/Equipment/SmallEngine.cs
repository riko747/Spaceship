using InternalAssets.Scripts.Other;

namespace InternalAssets.Scripts.Ship.Items.Equipment
{
    public class SmallEngine : Item
    {
        private int _thrust;

        protected override void Init()
        {
            EquipmentSlotType = Enums.EquipmentSlotType.Medium;
        }

        public override void Upgrade()
        {
            
        }
    }
}
