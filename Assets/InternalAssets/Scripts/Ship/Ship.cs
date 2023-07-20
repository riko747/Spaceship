using InternalAssets.Scripts.Other;
using UnityEngine;

namespace InternalAssets.Scripts.Ship
{
    public class Ship : MonoBehaviour, Interfaces.IUpgradeable
    {
        private ShipData _shipData;
        private void Awake()
        {
            Init();
        }

        private void Init()
        {
            _shipData = new ShipData();
        }

        public void Upgrade()
        {
            
        }
    }
}
