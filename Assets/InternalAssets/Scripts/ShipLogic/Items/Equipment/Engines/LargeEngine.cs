using InternalAssets.Scripts.Other;

namespace InternalAssets.Scripts.ShipLogic.Items.Equipment.Engines
{
    public class LargeEngine : Engine
    {
        public override void Init()
        {
            EngineThrust = 200;
            ItemType = Enums.Items.LargeEngine;
            base.Init();
        }

        public override void Upgrade()
        {
            EngineThrust += 100;
            base.Upgrade();
        }
    }
}
