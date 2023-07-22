using System;
using InternalAssets.Scripts.Other;

namespace InternalAssets.Scripts.ShipLogic.Items.Equipment.Engines
{
    public class SmallEngine : Engine
    {
        private int Thrust
        {
            get => EngineThrust;
            set => EngineThrust = Math.Max(value, 1000);
        }
        
        public override void Init()
        {
            Thrust = 400;
            ItemType = Enums.Items.SmallEngine;
            base.Init();
        }

        public override void Upgrade()
        {
            Thrust += 100;
            base.Upgrade();
        }
    }
}
