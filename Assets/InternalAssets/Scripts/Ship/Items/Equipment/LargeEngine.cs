using InternalAssets.Scripts.Other;

namespace InternalAssets.Scripts.Ship.Items.Equipment
{
    public class LargeEngine : Item
    {
        private int _thrust;

        protected override void Init()
        {
            EquipmentSlotType = Enums.EquipmentSlotType.Heavy;
        }

        public override void Upgrade()
        {
            
        }
    }
}
