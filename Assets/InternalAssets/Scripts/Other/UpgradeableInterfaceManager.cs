using System;
using System.Collections.Generic;
using UnityEngine;

namespace InternalAssets.Scripts.Other
{
    
    public class UpgradeableInterfaceManager : MonoBehaviour, Interfaces.IUpgradeableInterfaceManager
    {
        private List<Interfaces.IUpgradeable> _upgradeables;

        private void Awake()
        {
            _upgradeables = new List<Interfaces.IUpgradeable>();
        }

        public void AddUpgradeable(Interfaces.IUpgradeable currentInterface) => _upgradeables.Add(currentInterface);

        public List<Interfaces.IUpgradeable> GetAllUpgradeables() => _upgradeables;


    }
}
