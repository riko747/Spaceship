using System.Collections.Generic;

namespace InternalAssets.Scripts.Other
{
    public static class Upgradeables
    {
        private static List<Interfaces.IUpgradeable> _upgradeables;

        public static void CreateNewUpgradeables() => _upgradeables = new List<Interfaces.IUpgradeable>();

        public static List<Interfaces.IUpgradeable> GetUpgradeables() => _upgradeables;

        public static void AddToUpgradeables(Interfaces.IUpgradeable upgradeable) => _upgradeables.Add(upgradeable);
    }
}
