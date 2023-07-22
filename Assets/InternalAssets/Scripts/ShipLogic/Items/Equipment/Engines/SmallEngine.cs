using InternalAssets.Scripts.Other;

namespace InternalAssets.Scripts.ShipLogic.Items.Equipment.Engines
{
    public class SmallEngine : Engine
    {
        public override void Init()
        {
            EngineThrust = 400;
            ItemType = Enums.Items.SmallEngine;
            base.Init();
        }

        public override void Upgrade()
        {
            EngineThrust += 100;
            base.Upgrade();
        }
    }
}
