using UnityEngine;

namespace InternalAssets.Scripts.ShipLogic.Items.Equipment.Engines
{
    public class Engine : Item
    {
        protected int EngineThrust;

        public override void Upgrade()
        {
            Debug.Log("Engine thrust of " + ItemType + " engine now is " + EngineThrust);
        }
    }
}
