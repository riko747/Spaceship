using System;
using InternalAssets.Scripts.Other;

namespace InternalAssets.Scripts.ShipLogic.Items.Equipment.Engines
{
    public class LargeEngine : Engine
    {
        private int Thrust
        {
            get => EngineThrust;
            set => EngineThrust = Math.Max(value, 1000);
        }
        
        public override void Init()
        {
            Thrust = 200;
            ItemType = Enums.Items.LargeEngine;
            base.Init();
        }

        public override void Upgrade()
        {
            Thrust += 100;
            base.Upgrade();
        }
    }
}
