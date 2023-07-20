using InternalAssets.Scripts.Other;

namespace InternalAssets.Scripts.Ship.Items.Equipment
{
    public class EnergyShield : Item
    {
        private int _counteringDamage;

        protected override void Init()
        {
            EquipmentSlotType = Enums.EquipmentSlotType.Heavy;
        }

        public override void Upgrade()
        {
            
        }
    }
}
